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
    using System.Collections.Generic;
    using System.Linq;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.assets = new HashSet<asset>();
        }

        public int EmployeeID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string passowrd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asset> assets { get; set; }
        public virtual Department Department { get; set; }

        public static bool CheckIfExists(int ID)
        {

            using (mssql2100902Entities check = new mssql2100902Entities())
            {
                var find = check.Employees.Where(e => e.EmployeeID == ID).SingleOrDefault<Employee>();
                if (find != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



        }

        public static void AddEmployee(Employee employee)
        {
            using (mssql2100902Entities NewE = new mssql2100902Entities())
            {
                NewE.Employees.Add(employee);
                NewE.SaveChanges();
            }
        }

        public static void UpdateEmployee(Employee ToUpdate)
        {
            using (mssql2100902Entities Update = new mssql2100902Entities())
            {
                var find = Update.Employees.Where(e => e.EmployeeID == ToUpdate.EmployeeID).SingleOrDefault<Employee>();
                find.FName = ToUpdate.FName;
                find.SName = ToUpdate.SName;
                find.Email = ToUpdate.Email;
                find.DepartmentID = ToUpdate.DepartmentID;
                Update.SaveChanges();
            }
        }

        public static void DelEmployee(int ID)
        {
            using (mssql2100902Entities Del = new mssql2100902Entities())
            {

                var find = Del.Employees.Where(e => e.EmployeeID == ID).SingleOrDefault<Employee>();
                Del.Employees.Remove(find);
                Del.SaveChanges();
            }
        }

        public static bool CheckEmail(string Email)
        {
            using (mssql2100902Entities check = new mssql2100902Entities())
            {
                var find = check.Employees.Where(e => e.Email == Email).SingleOrDefault<Employee>();
                if (find == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool CheckPass(string Pass)
        {
            using (mssql2100902Entities check = new mssql2100902Entities())
            {
                var find = check.Employees.Where(e => e.passowrd == Pass).SingleOrDefault<Employee>();
                if (find == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
