using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string TbFirstName { get; set; }
        public string TbSurname { get; set; }
        public string TbTellNo { get; set; }
        public string TbEmail { get; set; }
        public string UserID { get; set; }
    }
}