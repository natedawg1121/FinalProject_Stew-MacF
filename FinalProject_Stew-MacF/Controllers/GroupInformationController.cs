using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Stew_MacF.Controllers
{
    [ApiController]
    [Route("api/group-information")]
    public class GroupInformationController : BaseController<GroupInformation>
    {
        public GroupInformationController(BaseControllerDBContext context) : base(context)
        {

        }
    }
}
