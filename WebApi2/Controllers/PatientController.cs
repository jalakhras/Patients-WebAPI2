using Microsoft.Ajax.Utilities;
using System.Collections.Generic;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class PatientsController : ApiController
    {
        ApplicationDbContext _context = new ApplicationDbContext();
       
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _context.Patients; 
        }
    }
}
