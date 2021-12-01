﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Stew_MacF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupHobbiesController : ControllerBase
    {
        private readonly ILogger<GroupHobbiesController> _logger;

        public GroupHobbiesController(ILogger<GroupHobbiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GroupHobbies> Get()
        {
            return null;
        }
    }
}
