using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Stew_MacF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupSchoolController : ControllerBase
    {
        private readonly ILogger<GroupSchoolController> _logger;

        public GroupSchoolController(ILogger<GroupSchoolController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GroupSchool> Get()
        {
            return null;
        }
    }
}
