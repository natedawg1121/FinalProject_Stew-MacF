using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupHobbies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FavoriteGame { get; set; }
        public string PlayedInstrument { get; set; }
        public string FavoriteClub { get; set; }
        public string FavoriteSport { get; set; }
    }
}
