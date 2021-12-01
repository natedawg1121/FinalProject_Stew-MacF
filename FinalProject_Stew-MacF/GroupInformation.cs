using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Stew_MacF
{
    public class GroupInformation
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime BirthTime { get; set; }

        public string CollegeProgram { get; set; }

        public int YearInSchool { get; set; }
    }

    public class GroupSchool
    {
        public string Name { get; set; }

        public string SchoolCollege { get; set; }

        public string SchoolHigh { get; set; }

        public string SchoolMiddle { get; set; }

        public string SchoolElementary { get; set; }
    }

    public class GroupHobbies
    {
        public string Name { get; set; }

        public string HobbiesGame { get; set; }

        public string HobbiesInsturment { get; set; }

        public string HobbiesClub { get; set; }

        public string HobbiesSport { get; set; }
    }