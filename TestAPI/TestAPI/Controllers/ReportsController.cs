using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    public class ReportsController : ApiController
    {
        Report[] reports = new Report[]
        {
            new Report { Id = 1, Name = "Tomato Soup", PersonId = "32" },
            new Report { Id = 2, Name = "Yo-yo", PersonId = "23" },
            new Report { Id = 3, Name = "Hammer", PersonId = "345" }
        };

        // GET: api/Reports
        public IEnumerable<Report> GetAllReports()
        {
            return reports;
        }

        // GET: api/Reports/5
        public IHttpActionResult GetReport(int id)
        {
            var report = reports.FirstOrDefault((p) => p.Id == id);
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }

        // POST: api/Reports
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reports/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reports/5
        public void Delete(int id)
        {
        }
    }
}
