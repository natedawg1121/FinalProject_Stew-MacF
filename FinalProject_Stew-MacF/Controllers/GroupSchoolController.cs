using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Stew_MacF.Controllers
{
    [ApiController]
    [Route("api/group-school")]
    public class GroupSchoolController : BaseController<GroupSchool>
    {
        public GroupSchoolController(BaseControllerDBContext context) : base(context)
        {

        }
    }
}
