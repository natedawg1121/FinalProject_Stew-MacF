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
    public class GroupSchoolsController : ControllerBase
    {
        private readonly ILogger<GroupSchoolsController> _logger;

        public GroupSchoolsController(ILogger<GroupSchoolsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GroupSchools> Get()
        {
            return null;
        }
    }
}
