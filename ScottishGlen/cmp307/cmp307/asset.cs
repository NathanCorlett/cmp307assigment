//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cmp307
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;
    
    public partial class asset
    {
        public int HardwareID { get; set; }
        public int EmployeeResponsible { get; set; }
        public string AssetName { get; set; }
        public string comment { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string type { get; set; }
        public string IPadress { get; set; }
        public Nullable<System.DateTime> DatePurchesed { get; set; }
        public string SystemName { get; set; }
    
        public virtual Employee Employee { get; set; }

        public static void AddAsset(asset NewAsset)
        {
            using (mssql2100902Entities NewA = new mssql2100902Entities())
            {
                    NewA.assets.Add(NewAsset);
                    NewA.SaveChanges();
              
                            
            }
        }

        public static bool CheckIDNum(int ID)
        {
            using (mssql2100902Entities check = new mssql2100902Entities())
            {
                var find = check.assets.Where(e => e.HardwareID == ID).SingleOrDefault<asset>();
                if (find == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void DeleteAsset(long ID)
        {
            using (mssql2100902Entities check = new mssql2100902Entities())
            {
                var find = check.assets.Where(e => e.HardwareID == ID).SingleOrDefault<asset>();
                check.assets.Remove(find);
                check.SaveChanges();
            }
        }

        public static void UpdateAsset(asset toUpdate)
        {
            using (mssql2100902Entities update = new mssql2100902Entities())
            {
                var find = update.assets.Where(e => e.HardwareID == toUpdate.HardwareID).SingleOrDefault<asset>();
                find.AssetName = toUpdate.AssetName;
                find.EmployeeResponsible = toUpdate.EmployeeResponsible;
                find.comment = toUpdate.comment;
                update.SaveChanges();

            }
        }

    }
}
