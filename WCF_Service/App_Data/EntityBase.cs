using System;
using System.Data;
using System.Linq;
using System.Text;
namespace SVService.App_Data
{
    public class EntityBase
    {
        // public string create_id { get; set; }
        // public DateTime create_at { get; set; }
        // public string update_id { get; set; }
        // public DateTime update_at { get; set; }

        public string GetBaseInsertOrUpdateSql()
        {
            var tableNameAttr = GetType()
                .GetCustomAttributes(typeof(TableNameAttr), true)
                .FirstOrDefault() as TableNameAttr;
            if (tableNameAttr == null)
            {
                throw new ArgumentException("Attribute cannot be null", "TableNameAttr");
            }

            var tableName = tableNameAttr.Name;

            var strFields = "";
            var strParams = "";
            var strFieldUpdate = "";
            var properties = GetType().GetProperties();
            foreach (var prop in properties)
            {
                var keyAttr = prop.GetCustomAttributes(typeof(IsTableKeyAttr), true)
                    .FirstOrDefault() as IsTableKeyAttr;
                if ((keyAttr == null || !keyAttr.AutoIncrement)
                    // && !prop.Name.Equals("create_at") && !prop.Name.Equals("update_at")
                    )
                {
                    strFields += "" + prop.Name + "" + ",";
                }

                if (prop.Name.Equals("update_count"))
                {
                    // strParams += "0,";
                }
                else
                {
                    if ((keyAttr == null || !keyAttr.AutoIncrement)
                        && !prop.Name.Equals("id")
                        && !prop.Name.Equals("create_at") && !prop.Name.Equals("update_at"))
                    {
                        strParams += "@" + prop.Name + ",";
                    }
                }

                if (!prop.Name.Equals("create_id") && !prop.Name.Equals("create_at") && !prop.Name.Equals("update_at"))
                {
                    if (prop.Name.Equals("update_count"))
                    {
                        // strFieldUpdate += '`' + prop.Name + '`' + " = mod(" + prop.Name + " + 1, 9999),";
                    }
                    else
                    {
                        if (keyAttr == null || !keyAttr.AutoIncrement)
                        {
                            // strFieldUpdate += "" + prop.Name + "" + " = @" + prop.Name + ",";
                        }
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(strFields))
            {
                strFields = strFields.Substring(0, strFields.Length - 1);
            }

            if (!string.IsNullOrWhiteSpace(strParams))
            {
                strParams = strParams.Substring(0, strParams.Length - 1);
            }

            if (!string.IsNullOrWhiteSpace(strFieldUpdate))
            {
                strFieldUpdate = strFieldUpdate.Substring(0, strFieldUpdate.Length - 1);
            }

            var sqlReturn = "INSERT INTO " + tableName + "(" + strFields + ") VALUES (" + strParams +
                            ") ";
                            // "ON DUPLICATE KEY UPDATE " + strFieldUpdate;

            return sqlReturn;
        }

        public int GetIdBaseInsertOrUpdateSql(DataTable paramDataTable, DbAccess dbAccess = null)
        {
            StringBuilder sbSql = new StringBuilder(GetBaseInsertOrUpdateSql());
            sbSql.AppendLine(";SELECT LAST_INSERT_ID()");

            if (dbAccess == null)
            {
                dbAccess = new DbAccess();
            }

            return dbAccess.ExecuteQuery(sbSql.ToString(), paramDataTable);
        }

        public void BaseInsertOrUpdate()
        {
            var param = new DataTable("param");
            {
                var properties = GetType().GetProperties();
                foreach (var prop in properties)
                {
                    param.Columns.Add(prop.Name, prop.PropertyType);
                }

                var rowValue = new object[properties.Length];
                var i = 0;
                foreach (var prop in properties)
                {
                    rowValue[i] = prop.GetValue(this, null);
                    i++;
                }

                param.Rows.Add(rowValue);
            }

            var sqlInsertOrUpdate = GetBaseInsertOrUpdateSql();

            using (var dao = new DbAccess())
            {
                dao.ExecuteQuery(sqlInsertOrUpdate, param);
            }
        }

        public DataTable GetParamDataTable()
        {
            var paramDataTable = new DataTable("param");
            {
                var properties = GetType().GetProperties();
                foreach (var prop in properties)
                {
                    var propertyType = prop.PropertyType;
                    if (propertyType.IsGenericType &&
                        propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        propertyType = propertyType.GetGenericArguments()[0];
                    }

                    paramDataTable.Columns.Add(prop.Name, propertyType);
                }

                var rowValue = new object[properties.Length];
                var i = 0;
                foreach (var prop in properties)
                {
                    rowValue[i] = prop.GetValue(this, null);
                    i++;
                }

                paramDataTable.Rows.Add(rowValue);
            }

            return paramDataTable;
        }

        public string GetBaseInsertSql()
        {
            var tableNameAttr = GetType()
                .GetCustomAttributes(typeof(TableNameAttr), true)
                .FirstOrDefault() as TableNameAttr;
            if (tableNameAttr == null)
            {
                throw new ArgumentException("Attribute cannot be null", "TableNameAttr");
            }

            var tableName = tableNameAttr.Name;

            var properties = GetType().GetProperties();
            var strFields = "";
            var strParams = "";
            foreach (var prop in properties)
            {
                var keyAttr = prop.GetCustomAttributes(typeof(IsTableKeyAttr), true)
                    .FirstOrDefault() as IsTableKeyAttr;
                if ((keyAttr == null || !keyAttr.AutoIncrement)
                    && !prop.Name.Equals("id")
                    && !prop.Name.Equals("create_at") && !prop.Name.Equals("update_at"))
                {
                    strFields += prop.Name + ",";
                }

                if (prop.Name.Equals("update_count"))
                {
                    // strParams += "0,";
                }
                else
                {
                    if ((keyAttr == null || !keyAttr.AutoIncrement)
                        && !prop.Name.Equals("id")
                        && !prop.Name.Equals("create_at") && !prop.Name.Equals("update_at"))
                    {
                        strParams += "@" + prop.Name + ",";
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(strFields))
            {
                strFields = strFields.Substring(0, strFields.Length - 1);
            }

            if (!string.IsNullOrWhiteSpace(strParams))
            {
                strParams = strParams.Substring(0, strParams.Length - 1);
            }

            var sqlReturn = "INSERT INTO " + tableName + "(" + strFields + ") VALUES (" + strParams + ");";
            return sqlReturn;
        }

        public int GetIdBaseInsertSql(DbAccess dbAccess = null)
        {
            StringBuilder sbSql = new StringBuilder(GetBaseInsertSql());
            sbSql.AppendLine(";SELECT LAST_INSERT_ID()");

            if (dbAccess == null)
            {
                dbAccess = new DbAccess();
            }

            return dbAccess.ExecuteQuery(sbSql.ToString(), null);
        }

        public void BaseInsert()
        {
            var sqlInsert = GetBaseInsertSql();

            var param = new DataTable("param");
            {
                var properties = GetType().GetProperties();
                foreach (var prop in properties)
                {
                    param.Columns.Add(prop.Name, prop.PropertyType);
                }

                var rowValue = new object[properties.Length];
                var i = 0;
                foreach (var prop in properties)
                {
                    rowValue[i] = prop.GetValue(this, null);
                    i++;
                }

                param.Rows.Add(rowValue);
            }

            using (var dao = new DbAccess())
            {
                dao.ExecuteQuery(sqlInsert, param);
            }
        }

        public string GetBaseUpdateSql()
        {
            var tableNameAttr = GetType()
                .GetCustomAttributes(typeof(TableNameAttr), true)
                .FirstOrDefault() as TableNameAttr;
            if (tableNameAttr == null)
            {
                throw new ArgumentException("Attribute cannot be null", "TableNameAttr");
            }

            var tableName = tableNameAttr.Name;

            var properties = GetType().GetProperties();
            var strFields = "";
            var strWhereCondition = "";
            foreach (var prop in properties)
            {
                var isKey = Attribute.IsDefined(prop, typeof(IsTableKeyAttr));
                if (isKey)
                {
                    strWhereCondition += prop.Name + " = @" + prop.Name + " AND ";
                    continue;
                }

                if (prop.Name.Equals("update_count"))
                {
                    // strFields += prop.Name + " = mod(" + prop.Name + " + 1, 9999),";
                }
                else
                {
                    if (!prop.Name.Equals("create_id") && !prop.Name.Equals("create_at") &&
                        !prop.Name.Equals("update_at"))
                    {
                        strFields += prop.Name + " = @" + prop.Name + ",";
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(strFields))
            {
                strFields = strFields.Substring(0, strFields.Length - 1);
            }

            if (!string.IsNullOrWhiteSpace(strWhereCondition))
            {
                strWhereCondition = strWhereCondition.Substring(0, strWhereCondition.Length - 5);
            }

            var sqlReturn = "UPDATE " + tableName + " SET " + strFields + " WHERE " + strWhereCondition;
            return sqlReturn;
        }

        public void BaseUpdate()
        {
            var param = new DataTable("param");
            {
                var properties = GetType().GetProperties();
                foreach (var prop in properties)
                {
                    param.Columns.Add(prop.Name, prop.PropertyType);
                }

                var rowValue = new object[properties.Length];
                var i = 0;
                foreach (var prop in properties)
                {
                    rowValue[i] = prop.GetValue(this, null);
                    i++;
                }

                param.Rows.Add(rowValue);
            }

            var sqlUpdate = GetBaseUpdateSql();

            using (var dao = new DbAccess())
            {
                dao.ExecuteQuery(sqlUpdate, param);
            }
        }

        public string GetBaseDeleteSql()
        {
            var tableNameAttr = GetType()
                .GetCustomAttributes(typeof(TableNameAttr), true)
                .FirstOrDefault() as TableNameAttr;

            if (tableNameAttr == null)
            {
                throw new ArgumentException("Attribute cannot be null", "TableNameAttr");
            }

            var primarys = GetType().GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(IsTableKeyAttr)))
                .ToList();

            if (primarys.Count == 0)
            {
                throw new ArgumentException("Attribute cannot be null", "IsTableKeyAttr");
            }

            var strWhereCondition = "";
            foreach (var key in primarys)
            {
                strWhereCondition += key.Name + " = @" + key.Name + " AND ";
            }

            if (!string.IsNullOrWhiteSpace(strWhereCondition))
            {
                strWhereCondition = strWhereCondition.Substring(0, strWhereCondition.Length - 5);
            }

            var sqlReturn = "DELETE FROM " + tableNameAttr.Name + " WHERE " + strWhereCondition;

            return sqlReturn;
        }

        public void BaseDelete()
        {
            var sqlDelete = GetBaseDeleteSql();

            var primarys = GetType().GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(IsTableKeyAttr)))
                .ToList();

            var dtParam = new DataTable("param");
            var paramValues = new object[primarys.Count];
            var i = 0;
            foreach (var key in primarys)
            {
                dtParam.Columns.Add(key.Name, key.PropertyType);
                paramValues[i] = key.GetValue(this, null);
                i++;
            }

            dtParam.Rows.Add(paramValues);

            using (var dao = new DbAccess())
            {
                dao.ExecuteQuery(sqlDelete, dtParam);
            }
        }

        public string GetBaseCreateTableTempSql()
        {
            var tableNameAttr = GetType()
                .GetCustomAttributes(typeof(TableNameAttr), true)
                .FirstOrDefault() as TableNameAttr;

            if (tableNameAttr == null)
            {
                throw new ArgumentException("Attribute cannot be null", "TableNameAttr");
            }

            var tableName = tableNameAttr.Name;
            var strFields = "";

            var properties = GetType().GetProperties();
            foreach (var prop in properties)
            {
                strFields += prop.Name;

                var type = prop.PropertyType;
                if (type == typeof(DateTime))
                {
                    strFields += " DATETIME,";
                }
                else if (type == typeof(short))
                {
                    strFields += " SMALLINT ,";
                }
                else if (type == typeof(int))
                {
                    strFields += " INT,";
                }
                else if (type == typeof(long))
                {
                    strFields += " BIGINT,";
                }
                else if (type == typeof(byte))
                {
                    strFields += " TINYINT,";
                }
                else if (type == typeof(decimal))
                {
                    strFields += " DECIMAL,";
                }
                else
                {
                    strFields += " VARCHAR,"; //" VARCHAR(32765),";
                }
            }

            if (!string.IsNullOrWhiteSpace(strFields))
            {
                strFields = strFields.Substring(0, strFields.Length - 1);
            }

            var sqlReturn = "CREATE TEMPORARY TABLE " + tableName + "_tmp(" + strFields + ");";

            return sqlReturn;
        }
    }
}