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
    public class GroupFoodsController : ControllerBase
    {
        private readonly ILogger<GroupFoodsController> _logger;

        public GroupFoodsController(ILogger<GroupFoodsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GroupFoods> Get()
        {
            return null;
        }
    }
}
