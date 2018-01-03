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

        internal static bool InsertLocation(string _code, string _descr)
        {
            var sql = "INSERT INTO location(loc_Code, loc_Description) VALUES(?Code, ?Descr)";
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?Code", _code);
                cmd.Parameters.AddWithValue("?Descr", _descr);
                conn.Open();
                var result = cmd.ExecuteNonQuery();
                return result > 0 ? true : false;
            }
        }

        internal static bool UpdateLocation(UInt32 _id, string _code, string _descr)
        {
            var sql = "UPDATE location SET loc_Code = ?Code, " +
                                         "loc_Description = ?Desc, " +
                       "WHERE loc_Id = ?id";
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?Id", _id = );
                cmd.Parameters.AddWithValue("?Code", _code);
                cmd.Parameters.AddWithValue("?Descr", _descr);
                conn.Open();
                var result = cmd.ExecuteNonQuery();
                return result > 0 ? true : false;
            }
        }

        internal static void DeleteLocation()
        {
            throw new NotImplementedException();
        }

        public static List<Location> GetLocationsList()
        {
            string sql = "select locId,locCode,locDescription from locations";

            var list = new List<Location>();
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while( reader.Read())
                    {
                        var loc = new Location();
                        loc.Id = Convert.ToUInt32(reader[0]);
                        loc.Code = Convert.ToString(reader[1]);
                        loc.Description = Convert.ToString(reader[2]);
                        list.Add(loc);
                    }
                }
                conn.Open();
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

        public static bool UpdateWebTableDate(string _tblName, DateTime _locUpdateTimeDate)
        {
            var dateTimeMySql = _locUpdateTimeDate.ToString("yyyy-MM-dd HH:mm:ss");
            var sql = "INSERT INTO tableUpdateTime(upd_TblName, upd_UpdateTime) VALUES(?tblName, ?locUpdateTimeDate)" +
                      "ON DUPLICATE KEY UPDATE upd_UpdateTime = '" + dateTimeMySql + "'";
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?tblName", _tblName);
                cmd.Parameters.AddWithValue("?locUpdateTimeDate", dateTimeMySql);
                conn.Open();
                return  cmd.ExecuteNonQuery() > 0 ? true : false;
            }
        }
    }
}
