using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        //Date of birth
        [Column(TypeName = "Date")]
        public DateTime DOB { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
    }
}
