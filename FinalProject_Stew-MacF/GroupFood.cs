using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupFood : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FavoriteBreakfastFood { get; set; }
        public string FavoriteLunchFood { get; set; }
        public string FavoriteDinnerFood { get; set; }
        public string FavoriteSnackFood { get; set; }
    }
}
