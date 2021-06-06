using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SVService.App_Data
{
    /// <summary>
    /// Convert Object
    /// </summary>
    public class ConvertUtil
    {
        /// <summary>
        /// convert data table to list object
        /// </summary>
        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName.ToLower())
                .ToList();

            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        if (row[pro.Name] != null && !string.IsNullOrEmpty(row[pro.Name].ToString()))
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                    }
                }
                return objT;
            }).ToList();
        }

        /// <summary>
        /// convert data table to object
        /// </summary>
        public static T ConvertToObject<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName.ToLower())
                .ToList();

            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        if (row[pro.Name] != null && !string.IsNullOrEmpty(row[pro.Name].ToString()))
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                    }
                }
                return objT;
            }).FirstOrDefault();
        }

        /// <summary>
        /// encrypt MD5
        /// </summary>
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// Convert object to data table
        /// </summary>
        public static DataTable ConvertToDataTable<T>(T obj)
        {
            var tableReturn = new DataTable("param");
            {
                var properties = obj.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    var propertyType = prop.PropertyType;
                    if (propertyType.IsGenericType &&
                        propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        propertyType = propertyType.GetGenericArguments()[0];
                    }

                    tableReturn.Columns.Add(prop.Name, propertyType);
                }
                var rowValue = new object[properties.Length];
                var i = 0;
                foreach (var prop in properties)
                {
                    rowValue[i] = prop.GetValue(obj, null);
                    i++;
                }

                tableReturn.Rows.Add(rowValue);
            }

            return tableReturn;
        }

        /// <summary>
        /// Convert to datetime
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime ConvertDateTimeWithFormat(string datetime, string format)
        {
            DateTime resultDateTime;

            DateTime.TryParseExact(datetime, format, null, DateTimeStyles.None, out resultDateTime);
            return resultDateTime;
        }

        /// <summary>
        /// Convert string -> int
        /// </summary>
        public static int? ConvertToIntWithNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return Convert.ToInt32(value.Replace(",", string.Empty));
        }

        /// <summary>
        /// Convert string -> int
        /// </summary>
        public static int ConvertToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }

            return Convert.ToInt32(value.Replace(",", string.Empty));
        }

        /// <summary>
        /// Convert string -> int
        /// </summary>
        public static string ConvertToStringWithNull(string value)
        {
            return !string.IsNullOrEmpty(value) ? value : null;
        }

        /// <summary>
        /// Convert to datetime
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime? ConvertToDateTime(string datetime)
        {
            if (string.IsNullOrEmpty(datetime))
            {
                return null;
            }

            return Convert.ToDateTime(datetime);
        }

        /// <summary>
        /// Convert TimeSpan -> HH:mm
        /// </summary>
        public static string FormatHHmm(TimeSpan? val)
        {
            if (val == null) return string.Empty;
            return string.Format("{0:00}:{1:00}", val.Value.Hours, val.Value.Minutes);
        }

        /// <summary>
        /// Convert string -> TimeSpan
        /// </summary>
        public static TimeSpan? ConvertToTimeSpan(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return TimeSpan.Parse(value);
        }

        /// <summary>
        /// Convert HH:mm -> TimeSpan
        /// </summary>
        public static TimeSpan? ConvertTotalHourToTimeSpan(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            var segment = value.Split(':');

            return new TimeSpan(0, ConvertToInt(segment[0]), ConvertToInt(segment[1]), 0);
        }

        /// <summary>
        /// Convert object -> TimeSpan
        /// </summary>
        public static TimeSpan? ConvertToTimeSpan(object val)
        {
            if (val == null)
            {
                return null;
            }

            return TimeSpan.Parse(val.ToString());
        }

        /// <summary>
        /// 下5桁を抽出し前方ゼロサプレス
        /// 例)961081205135→5135
        /// </summary>
        public static string ConvertPostCode(string postCd)
        {
            if (string.IsNullOrEmpty(postCd) || postCd.Length <= 5)
            {
                return postCd?.TrimStart('0');
            }

            // 下5桁を抽出し前方ゼロサプレス
            postCd = postCd.Substring(postCd.Length - 5);

            return postCd.TrimStart('0');
        }

        /// <summary>
        /// Convert Entity to SQL string
        /// </summary>
        public static string EntityToStringSQLSelect<T>(T objectEntity, string alias)
        {
            StringBuilder sbSQL = new StringBuilder();

            var properties = objectEntity.GetType().GetProperties();

            foreach (var prop in properties)
            {
                sbSQL.AppendFormat($"    {alias}{"."}{prop.Name}{"'"}").AppendLine();
            }

            return sbSQL.ToString();
        }

        /// <summary>
        /// Convert Integer to TimeSpan
        /// 例)90 -> 1:30
        /// </summary>
        public static TimeSpan? IntToTimeSpan(int? value)
        {
            if (value == null)
            {
                return null;
            }

            int hours = (int)value / 60;
            int minus = (int)(value - 60 * (value / 60));

            return new TimeSpan(hours, minus, 0);
        }

        /// <summary>
        /// Convert TimeSpan to Integer(minute)
        /// 例)1:30 -> 90
        /// </summary>
        public static int? TimeSpanToInt(TimeSpan? value)
        {
            if (value == null)
            {
                return null;
            }

            return (int)((TimeSpan)value).TotalMinutes;
        }

        /// <summary>
        /// Convert TimeSpan? to TimeSpan
        /// if null -> Min value
        /// </summary>
        public static TimeSpan TimeSpanNullToTimeSpan(TimeSpan? value)
        {
            if (value == null)
            {
                return TimeSpan.MinValue;
            }

            return TimeSpan.Parse(value.ToString());
        }

        /// <summary>
        /// Convert DateTime? to DateTime
        /// if null -> Min value
        /// </summary>
        public static DateTime DateTimeNullToDateTime(DateTime? value)
        {
            if (value == null)
            {
                return DateTime.MinValue;
            }

            return DateTime.Parse(value.ToString());
        }

        /// <summary>
        /// Convert int? to int
        /// if null -> 0
        /// </summary>
        public static int IntNullToInt(int? value)
        {
            return Convert.ToInt32(value);
        }
        

        public static decimal RoundDecimal(decimal value, int dec)
        {
            return Math.Round(value, dec);
        }
    }
}