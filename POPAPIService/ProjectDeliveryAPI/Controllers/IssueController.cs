using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectDeliveryAPI.Models;
namespace ProjectDeliveryAPI.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class IssueController : ControllerBase
        {
            // GET: api/<StudentAdmissionController>
            [HttpGet]
            public IEnumerable<IssueModel> Get()
            {
                IssueModel issueModel1 = new IssueModel();
                IssueModel issueModel2 = new IssueModel();
                issueModel1.IssueId = 1;
                issueModel1.Subject = "Joins Release 2.1 Maybe Delay";
                issueModel1.IssueBy = "DuongJai";
                issueModel1.Status = "Pending";
                issueModel1.IssueDate = DateTime.Now;
                issueModel2.IssueId = 2;
                issueModel2.Subject = "POP phase 2 Additional Requirement";
                issueModel2.IssueBy = "Napa";
                issueModel2.Status = "Closed";
                issueModel2.IssueDate = DateTime.Now;
                List<IssueModel> lissuemodel = new List<IssueModel>
            {
                issueModel1,
                issueModel2
            };
                return lissuemodel;
            }
        }
    
}
