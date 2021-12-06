using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public TimeSpan? BirthTime { get; set; }
        public string CollegeProgram { get; set; }
        public int? YearInSchool { get; set; }
    }
}
