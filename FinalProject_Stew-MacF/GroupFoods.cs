using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupFoods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FavoriteBreakfastFood { get; set; }
        public string FavoriteLunchFood { get; set; }
        public string FavoriteDinnerFood { get; set; }
        public string FavoriteSnackFood { get; set; }
    }
}
