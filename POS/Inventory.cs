using System;
using System.Data;
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
        public static bool CheckIfTableIsDirty(string _tblName, DateTime _locUpdateTimeDate)
        {
            var webUpdTime = Sql.GetUpdateTimeOfTable(_tblName);
            int result = DateTime.Compare(webUpdTime, _locUpdateTimeDate);
            return result >= 0 ? false : true;
        }

        public static bool UpdateWebTableDate(string _tblName, DateTime _locUpdateTimeDate)
        {
            var result = Sql.UpdateWebTableDate(_tblName, _locUpdateTimeDate);
            return result;
        }
    }

        public class Location
    {
        public UInt32? Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public static DateTime UpdateTime { get; set; }
        public static List<Location> locList { get; set; }

        public static void LoadLocations()
        {
            locList = Sql.GetLocationsList();
        }

        public void SaveLocation()
        {
            if (this.Id == null)
                Sql.InsertLocation(this.Code, this.Description);
            
            else
                Sql.UpdateLocation(Convert.ToUInt32(this.Id), this.Code, this.Description);
        }

        public void DeleteLocation()
        {
            Sql.DeleteLocation();
        }

        
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
