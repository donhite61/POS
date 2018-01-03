using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POS
{
    class TableUpdateTimes
    {
        public string TblName { get; set; }
        public DateTime UpdateTime { get; set; }
        public static string ConnString = "server=69.89.31.188;user=hitephot_don;database=hitephot_pos;port=3306;password=Hite1985;";

        public static bool CheckIfTableIsDirty(string _tblName, DateTime _locUpdateTimeDate)
        {
            
            var sql = "select upd_UpdateTime from tableUpdateTime where upd_TblName = '" + _tblName + "'";
            using (var conn = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result == null)
                    return false; // if table updatetime not found, table new?

                DateTime webUpdTime;
                if (DateTime.TryParse(result.ToString(), out webUpdTime))
                    if (webUpdTime == _locUpdateTimeDate)
                        return false;
            }
            return true;
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
                var result = cmd.ExecuteScalar();
                var success = cmd.ExecuteNonQuery() > 0 ? true : false;
                return success;
            }
        }
    }

    class Location
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    class Departments
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public UInt32 LocId { get; set; }
        public decimal DailyAvailTime { get; set; }//Hours
        public int CostPerHourToRun { get; set; }//Pennies
        public int FloorspaceUsed { get; set; } //SqFeet
        public string status { get; set; } //normal,down,delayed enum? or multiplier?
    }

    class Vendors
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    class Inventory
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public UInt32 DeptId { get; set; }
        public int Cost { get; set; }
        public string Units { get; set; }
        public int Quant { get; set; }
        public UInt32 VendId { get; set; }
    }

    class Components
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public UInt32 InvId { get; set; }
        public int InvQuant { get; set; }
        public UInt32 InkId { get; set; }
        public int InkQuant { get; set; }
        public int FirstDeptTime { get; set; }
        public int AddnlDeptTime { get; set; }
        public UInt32 ComponantQuantityPriceListId { get; set; } //price
        public UInt32 ComponantQuantityServiceTimeListId { get; set; } //service time
        public bool FirstItemFullPrice { get; set; }
    }

    class ComponantQuantityPriceList
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    class ComponantQuantityServiceTimeList
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    class ComponantQuantityPriceListItem
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public UInt32 CompPriceListId { get; set; }
        public int Quant { get; set; }
        public int PriceReg { get; set; }
        public int PriceModRush { get; set; }
        public int PriceModDelay { get; set; }
        public int PriceMin { get; set; }
        public bool PriceModIsPercent { get; set; }
    }

    class ComponantQuantityServiceTimeListItem
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public UInt32 CompPriceListId { get; set; }
        public int Quant { get; set; }
        public int ServiceTimeReg { get; set; } //hours
        public int ServiceTimeRush { get; set; }
        public int ServiceTimeDelay { get; set; }
    }



    class Products
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<Components> list { get; set; }
        public int CalcRetailPrice { get; set; }
        public int CalcSerTime { get; set; }
    }
}
