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
    public class GroupInformationController : ControllerBase
    {
        private readonly ILogger<GroupInformationController> _logger;

        public GroupInformationController(ILogger<GroupInformationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GroupInformation> Get()
        {
            return null;
        }
    }
}
