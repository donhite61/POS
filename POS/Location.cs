using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Locations
    {
        public UInt32 Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        private static string _tableName = "locations";
        public static DateTime _updateTime = DateTime.MinValue;
        private static List<Locations> _locList = null;
        public static List<Locations> LocList
        {
            get
            {
                if(_locList == null || Sql.ListIsDirty(_tableName, _updateTime))
                {
                    _locList = Sql.GetLocationsList();
                    _updateTime = Sql.GetUpdateTimeOfTable(_tableName);
                }
                return _locList;
            }
            set
            {
                _locList = LocList;
            }
        }

        public static void DeleteLocation(UInt32 _id)
        {
            Sql.DeleteLocation(_id);
            _updateTime = Sql.GetServerTime();
            Sql.UpdateWebTableDate(_tableName, _updateTime);

            var itemToRemove = _locList.Single(r => r.Id == _id);
            _locList.Remove(itemToRemove);
        }

        internal static UInt32 SaveRow(uint? cell0, string cell1, string cell2)
        {
            UInt32 sqlId;
            if (cell0 != 0) //if not a new record LocList must not be null
            {
                sqlId = Convert.ToUInt32(cell0);
                foreach (Locations loc in LocList) //find record in list
                {
                    if (loc.Id == cell0) // set new values
                    {
                        loc.Code = cell1;
                        loc.Description = cell2;
                        Sql.UpdateLocation(_tableName, loc.Id, cell1, cell2);
                        _updateTime = Sql.GetServerTime();
                        Sql.UpdateWebTableDate(_tableName, _updateTime);
                        break;
                    }
                }
            }
            else
            {
                sqlId = Convert.ToUInt32(Sql.InsertLocation(_tableName, cell1, cell2));
                _updateTime = Sql.GetServerTime();
                Sql.UpdateWebTableDate(_tableName, _updateTime);

                if (sqlId != null)
                {
                    Locations lastLoc = LocList.Last();
                    lastLoc.Id = sqlId;
                    //var loc = new Locations();
                    //loc.Id = Convert.ToUInt32(sqlId);
                    //loc.Code = cell1;
                    //loc.Description = cell2;
                    //if (LocList == null)
                    //    LocList = new List<Locations>();

                   // LocList.Add(loc);
                }
            }
            return sqlId;
        }
    }
}
