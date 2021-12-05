using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupInformation : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] BirthTime { get; set; }
        public string CollegeProgram { get; set; }
        public int? YearInSchool { get; set; }
    }
}
