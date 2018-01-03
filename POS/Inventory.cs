using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class TableUpdateTimes
    {
        public string TblName { get; set; }
        public DateTime UpdateTime { get; set; }
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
