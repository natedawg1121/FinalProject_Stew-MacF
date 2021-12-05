using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Stew_MacF.Controllers
{
    [ApiController]
    [Route("api/group-hobby")]
    public class GroupHobbyController : BaseController<GroupHobby>
    {
        public GroupHobbyController(BaseControllerDBContext context) : base(context)
        {

        }
    }
}
