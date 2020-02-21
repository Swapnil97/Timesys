using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;


public class EmployeeController : ApiController
{

    public EmployeeController()
    {
    }

    public IHttpActionResult GetEmployees()
    {
        IList<Employee> employee = null;

        using (var ctx = new DBModel())
        {
            employee = ctx.Employees.Select(s => new Employee()
            {
                EmployeeID = s.EmployeeID,
                Name = s.Name,
                Position = s.Position,
                Age = s.Age,
                Salary = s.Salary
            }).ToList<Employee>();
        }

        if (employee.Count == 0)
        {
            return NotFound();
        }

        return Ok(employee);
    }
}



namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {

        public EmployeeController()
        {
        }

        public IHttpActionResult GetEmployees()
        {
            IList<Employee> employee = null;

            using (var ctx = new DBModel())
            {
                employee = ctx.Employees.Select(s => new Employee()
                {
                    EmployeeID = s.EmployeeID,
                    Name = s.Name,
                    Position = s.Position,
                    Age = s.Age,
                    Salary = s.Salary
                }).ToList<Employee>();
            }

            if (employee.Count == 0)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // GET: api/Employee



        //private DBModel db = new DBModel();

        //// GET: api/Employee
        //[HttpGet]
        //public IHttpActionResult GetEmployees()
        //{
        //    return db.Employees;
        //}


        // GET: api/Employee
        //public IQueryable<Employee> GetEmployees()
        //{
        //    return db.Employees;
        //}

        ////GET: api/Employee/5

        //[ResponseType(typeof(Employee))]
        //public IHttpActionResult GetEmployee(int id)
        //{
        //    Employee employee = db.Employees.Find(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(employee);
        //}

        //// PUT: api/Employee/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutEmployee(int id, Employee employee)
        //{
        //    if (id != employee.EmployeeID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(employee).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Employee
        //[ResponseType(typeof(Employee))]
        //public IHttpActionResult PostEmployee(Employee employee)
        //{
        //    db.Employees.Add(employee);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeID }, employee);
        //}

        //// DELETE: api/Employee/5
        //[ResponseType(typeof(Employee))]
        //public IHttpActionResult DeleteEmployee(int id)
        //{
        //    Employee employee = db.Employees.Find(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Employees.Remove(employee);
        //    db.SaveChanges();

        //    return Ok(employee);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool EmployeeExists(int id)
        //{
        //    return db.Employees.Count(e => e.EmployeeID == id) > 0;
        //}
    }
}