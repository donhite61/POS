using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Sql
    {
        public static string ConnString = "server=69.89.31.188;user=hitephot_don;database=hitephot_pos;port=3306;password=Hite1985;";

        internal static DateTime GetServerTime()
        {
            DateTime webUpdTime = DateTime.MinValue;
            var sql = "SELECT NOW() FROM DUAL";

            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                    DateTime.TryParse(result.ToString(), out webUpdTime);
            }
            return webUpdTime;
        }

        public static DateTime UpdateWebTableDate(string _tblName, DateTime _locUpdateTime) //return stored time
        {
            var dateTimeMySql = _locUpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            var sql = "INSERT INTO tableUpdateTime(upd_TblName, upd_UpdateTime) VALUES(?tblName, ?locUpdateTime)" +
                      "ON DUPLICATE KEY UPDATE upd_UpdateTime = '" + dateTimeMySql + "'";

            DateTime webUpdTime = DateTime.MinValue;
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?tblName", _tblName);
                cmd.Parameters.AddWithValue("?locUpdateTime", dateTimeMySql);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.CommandText = "select upd_UpdateTime from tableUpdateTime where upd_TblName = ?tblName";
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        DateTime.TryParse(result.ToString(), out webUpdTime);
                }
            }
            return webUpdTime;
        }

        public static bool ListIsDirty(string _tblName, DateTime _locUpdateTimeDate)
        {
            DateTime webUpdTime = GetUpdateTimeOfTable(_tblName);
            if (webUpdTime != DateTime.MinValue)
                if (DateTime.Compare(webUpdTime, _locUpdateTimeDate) > 0)
                    return true;

            return false;
        }

        public static DateTime GetUpdateTimeOfTable(string _tblName)
        {
            DateTime webUpdTime = DateTime.MinValue;
            var sql = "select upd_UpdateTime from tableUpdateTime where upd_TblName = '" + _tblName + "'";

            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                    DateTime.TryParse(result.ToString(), out webUpdTime);
            }
            return webUpdTime;
        }

        internal static UInt32? InsertLocation(string _tableName, string _code, string _descr)
        {
            UInt32? sqlIdUint32 = null;
            object sqlId = null;
            var sql = "INSERT INTO locations (loc_Code, loc_Description) VALUES(?Code, ?Descr)";
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?TableName", _tableName);
                cmd.Parameters.AddWithValue("?Code", _code);
                cmd.Parameters.AddWithValue("?Descr", _descr);
                conn.Open();
                var result = cmd.ExecuteNonQuery();
                if( result > 0 )
                {
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    sqlId = cmd.ExecuteScalar();
                    sqlIdUint32 = Convert.ToUInt32(sqlId);
                }
            }
            
            return sqlIdUint32;
        }

        internal static bool UpdateLocation(string _tableName, UInt32 _id, string _code, string _descr)
        {
            var sql = "UPDATE locations SET loc_Code = ?Code, loc_Description = ?Desc WHERE loc_Id = ?Id";
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?TableName", _tableName);
                cmd.Parameters.AddWithValue("?Id", _id);
                cmd.Parameters.AddWithValue("?Code", _code);
                cmd.Parameters.AddWithValue("?Desc", _descr);
                conn.Open();
                var result = cmd.ExecuteNonQuery();
                return result > 0 ? true : false;
            }
        }

        internal static void DeleteLocation(UInt32 sqlId)
        {
            var sql = "DELETE FROM locations WHERE loc_Id = ?sqlId";

            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?sqlId", sqlId);
                conn.Open();
                var result = cmd.ExecuteScalar();
            }
        }



        public static List<Locations> GetLocationsList()
        {
            string sql = "select loc_Id,loc_Code,loc_Description from locations";

            var list = new List<Locations>();
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while( reader.Read())
                    {
                        var loc = new Locations();
                        loc.Id = Convert.ToUInt32(reader[0]);
                        loc.Code = Convert.ToString(reader[1]);
                        loc.Description = Convert.ToString(reader[2]);
                        list.Add(loc);
                    }
                }
                conn.Close();
            }
            return list;
        }

        public static DataTable GetLocationsTable()
        {
                string sql = "select locId,locCode,locDescription from locations";

                DataTable dtable = new DataTable();
                using (var conn = new MySqlConnection(ConnString))
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dtable.Load(reader);
                    }

                }

                dtable.Columns["locId"].ColumnName = "Id";
                dtable.Columns["locCode"].ColumnName = "Code";
                dtable.Columns["locDescription"].ColumnName = "Name";
                return dtable;
            }

    }
}
