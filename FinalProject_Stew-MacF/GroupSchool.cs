using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupSchool : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ElementarySchool { get; set; }
        public string MiddleSchool { get; set; }
        public string HighSchool { get; set; }
        public string University { get; set; }
    }
}
