using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Data;
//using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        private IT_CompanyDBDataContext db = new IT_CompanyDBDataContext();

        // GET: api/Employee
        public IEnumerable<Models.Employee> Get()
        {
            //return new string[] { "value1", "value2" };

            List<Models.Employee> EmployeeData = new List<Models.Employee>();
            Models.Employee employee = new Models.Employee();

            var GetEmployeeData = from e in db.Employees
                                  select new
                                  {
                                      EmployeeID = e.employeeID,
                                      TbFirstName = e.tbFirstName,
                                      TbSurname = e.tbSurname,
                                      TbTellNo = e.tbTellNo,
                                      TbEmail =e.tbEmail,
                                      UserID = e.UserID
                                  };

            foreach (var ge in GetEmployeeData)
            {
                employee.EmployeeID = ge.EmployeeID;
                employee.TbFirstName = ge.TbFirstName;
                employee.TbSurname = ge.TbSurname;
                employee.TbTellNo = ge.TbTellNo;
                employee.TbEmail = ge.TbEmail;
                employee.UserID = ge.UserID;
                EmployeeData.Add(employee);
            }

            return EmployeeData;
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
