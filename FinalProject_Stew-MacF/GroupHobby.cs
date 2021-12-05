using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FinalProject_Stew_MacF
{
    public partial class GroupHobby : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FavoriteGame { get; set; }
        public string PlayedInstrument { get; set; }
        public string FavoriteClub { get; set; }
        public string FavoriteSport { get; set; }
    }
}
