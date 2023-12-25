using Microsoft.AspNetCore.Mvc;

using SaleFunnelAPI.Models;
namespace SaleFunnelAPI.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class LeadController : ControllerBase
        {
            // GET: api/<LeadController>
            [HttpGet]
            public IEnumerable<LeadModel> Get()
            {
                LeadModel leadModel1 = new LeadModel();
                LeadModel leadModel2 = new LeadModel();
                leadModel1.LeadId = 1;
                leadModel1.LeadProjectName = "Paperless System";
                leadModel1.Customer = "AWC";
                leadModel1.Status = "Award";
                leadModel1.IssueDate = DateTime.Now;
                leadModel2.LeadId = 2;
                leadModel2.LeadProjectName = "PICO Loan Refinance System";
                leadModel2.Customer = "ลิ้มสุขใจ";
                leadModel2.Status = "Follow up";
                leadModel2.IssueDate = DateTime.Now;
                List<LeadModel> lLeadModel = new List<LeadModel>
            {
                leadModel1,
                leadModel2
            };
                return lLeadModel;
            }
        }
    
}
