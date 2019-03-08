using Microsoft.Ajax.Utilities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    [EnableCors("*", "*", "GET")]
    public class PatientsController : ApiController
    {
        ApplicationDbContext _context = new ApplicationDbContext();
       
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _context.Patients; 
        }
        [HttpGet]
        public HttpResponseMessage Get(int Id)
        {
            var Patient =  _context.Patients.Find(Id); 
            if (Patient == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient not found! ");
            }
            return Request.CreateResponse(Patient);
        }
        [HttpGet]
        [Route("api/Patients/{Id}/Medications")]
        public HttpResponseMessage GetMedications(int Id)
        {
            var Patients = _context.Patients.Find(Id); 
            
            if (Patients == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient not found! ");
            }
            return Request.CreateResponse(Patients.Medications);
        }
    }
}
