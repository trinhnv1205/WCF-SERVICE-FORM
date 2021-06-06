using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SVService.App_Data
{
    public class DbAccess : IDisposable
    {
        /// <summary>
        /// 接続文字列
        /// </summary>
        public string ConnectionString { get; protected set; }

        /// <summary>
        /// 接続オブジェクト
        /// </summary>
        protected SqlConnection _conn;
        /// <summary>
        /// トランザクション
        /// </summary>
        private SqlTransaction _tran;

        /// <summary>
        /// トランザクション (get/set)
        /// </summary>
        public SqlTransaction Tran
        {
            get => _tran;
            set => _tran = value;
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DbAccess()
        {
            this.ConnectionString = GetDefaultConnectionString();
            this._conn = this.GetConnection(this.ConnectionString);

            this._conn.Open();
        }

        /// <summary>
        /// デフォルト接続先
        /// TODO Web.config に切り出すべき内容
        /// </summary>
        /// <returns></returns>
        private string GetDefaultConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["firebase"].ConnectionString;
            return connectionString;
            // return DbAccess.GetConenctionString("localhost", 3306, "firebase", "root", "");
        }

        /// <summary>
        /// 接続オブジェクトを取得
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        protected SqlConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// IDispose実装
        /// </summary>
        public void Dispose()
        {
            if (!(_conn is null))
            {
                if (_conn.State != ConnectionState.Closed)
                {
                    _conn.Close();
                }

                _conn.Dispose();
                _conn = null;
            }
        }

        /// <summary>
        /// 接続文字列の作成支援
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="Port"></param>
        /// <param name="DatabaseName"></param>
        /// <param name="Userid"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        // public static string GetConenctionString(string Server, uint Port, string DatabaseName, string Userid,
        //     string Password)
        // {
        //     var builder = new SqlConnectionStringBuilder
        //     {
        //         Server = Server,
        //         Port = Port,
        //         Database = DatabaseName,
        //         UserID = Userid,
        //         Password = Password,
        //         Pooling = true,
        //         CharacterSet = "utf8"
        //     };
        //
        //     return builder.GetConnectionString(true);
        // }

        /// <summary>
        /// データ取得（Select Query）
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dtParam"></param>
        /// <returns></returns>
        public DataTable Select(string query, DataTable dtParam = null)
        {
            var dt = new DataTable("data");

            try
            {
                using (var adapter = new SqlDataAdapter())
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = query;
                    cmd.Connection = _conn;
                    cmd.CommandTimeout = 3600;
                    adapter.SelectCommand = cmd;

                    if (!(dtParam is null) && dtParam.Rows.Count != 0)
                    {
                        cmd.Prepare();

                        foreach (DataColumn item in dtParam.Columns)
                        {
                            cmd.Parameters.AddWithValue(item.ColumnName, dtParam.Rows[0][item.ColumnName]);
                        }
                    }


                    adapter.Fill(dt);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw;
            }

            return dt;
        }

        /// <summary>
        /// データ更新（Update, Delete Query）
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dtParam"></param>
        /// <returns></returns>
        public int ExecuteQuery(string query, DataTable dtParam = null)
        {
            int ret = -1;

            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = _conn;

                    cmd.Transaction = this.Tran;

                    cmd.CommandText = query;
                    cmd.CommandTimeout = 3600;

                    if (!(dtParam is null) && dtParam.Rows.Count != 0)
                    {
                        //パラメータ行数分のクエリを発行する
                        foreach (DataRow row in dtParam.Rows)
                        {
                            cmd.Prepare();
                            cmd.Parameters.Clear();

                            foreach (DataColumn col in dtParam.Columns)
                            {
                                cmd.Parameters.AddWithValue(col.ColumnName, row[col.ColumnName]);
                            }

                            ret += cmd.ExecuteNonQuery();
                        }
                    }

                    return ret;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public int InsertGetId(string query, DataTable dtParam = null)
        {
            int ret = -1;

            using (var cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = _conn;

                    cmd.Transaction = Tran;

                    query += "select last_insert_id();";
                    cmd.CommandText = query;
                    cmd.CommandTimeout = 3600;

                    if (!(dtParam is null) && dtParam.Rows.Count != 0)
                    {
                        //パラメータ行数分のクエリを発行する
                        foreach (DataRow row in dtParam.Rows)
                        {
                            cmd.Prepare();
                            cmd.Parameters.Clear();

                            foreach (DataColumn col in dtParam.Columns)
                            {
                                cmd.Parameters.AddWithValue(col.ColumnName, row[col.ColumnName]);
                            }

                            ret = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    return ret;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    throw;
                }
            }
        }

        #region Transaction管理

        public void BeginTransaction()
        {
            this.Tran = this._conn.BeginTransaction();
        }

        public void Commit()
        {
            this.Tran.Commit();
        }

        public void Rollback()
        {
            this.Tran.Rollback();
        }

        #endregion

        /// <summary>
        /// ストアドプロシージャ実行
        /// </summary>
        /// <param name="procedure">プロシージャ名</param>
        /// <param name="dtInParam">入力引数:1行目だけ使う</param>
        /// <param name="dtOutParam">出力</param>
        /// <returns>出力TBに指定したDataTableのDataRow1行</returns>
        public DataRow ExecuteProcedure(string procedure, DataTable dtInParam = null, DataTable dtOutParam = null)
        {
            int ret = -1;
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = this.Tran;
                    cmd.CommandText = procedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 3600;

                    cmd.Prepare();
                    cmd.Parameters.Clear();

                    //入力パラメータ
                    if (!(dtInParam is null) && dtInParam.Rows.Count != 0)
                    {
                        DataRow inputRow = dtInParam.Rows[0];
                        foreach (DataColumn col in inputRow.Table.Columns)
                        {
                            cmd.Parameters.AddWithValue(col.ColumnName, inputRow[col.ColumnName]);
                        }
                    }

                    //出力パラメータ
                    DataRow outputRow = dtOutParam.NewRow();
                    foreach (DataColumn col in outputRow.Table.Columns)
                    {
                        cmd.Parameters.Add(col.ColumnName, ConvertSqlDbType(col.DataType))
                            .Direction = ParameterDirection.Output;
                    }

                    ret = cmd.ExecuteNonQuery();

                    var retRow = dtOutParam.NewRow();
                    foreach (DataColumn col in outputRow.Table.Columns)
                    {
                        retRow[col.ColumnName] = cmd.Parameters[col.ColumnName].Value;
                    }

                    return retRow;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    throw;
                }
            }
        }

        /// <summary>
        /// SystemType > SqlDbType Conversion
        /// 本当に合ってる？
        /// </summary>
        /// <param name="giveType"></param>
        /// <returns></returns>
        public static SqlDbType ConvertSqlDbType(Type giveType)
        {
            var typeMap = new Dictionary<Type, SqlDbType>();

            typeMap[typeof(string)] = SqlDbType.VarChar;
            typeMap[typeof(char[])] = SqlDbType.VarChar;
            typeMap[typeof(int)] = SqlDbType.Int;
            typeMap[typeof(Int32)] = SqlDbType.Int;
            typeMap[typeof(Int16)] = SqlDbType.Int;
            typeMap[typeof(Int64)] = SqlDbType.Int;
            typeMap[typeof(Byte[])] = SqlDbType.VarBinary;
            typeMap[typeof(Boolean)] = SqlDbType.Bit;
            typeMap[typeof(DateTime)] = SqlDbType.DateTime;
            typeMap[typeof(DateTimeOffset)] = SqlDbType.DateTime;
            typeMap[typeof(Decimal)] = SqlDbType.Decimal;
            // typeMap[typeof(Double)] = SqlDbType.Double;
            typeMap[typeof(float)] = SqlDbType.Float;
            // typeMap[typeof(Byte)] = SqlDbType.Byte;
            typeMap[typeof(TimeSpan)] = SqlDbType.Time;

            return typeMap[(giveType)];
        }

        public void Excute(string query)
        {
            using (var cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = Tran;
                    cmd.CommandText = query;
                    cmd.CommandTimeout = 3600;
                    // cmd.CacheAge = 500000;
                    // cmd.EnableCaching = true;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    throw;
                }
            }
        }

    }
}