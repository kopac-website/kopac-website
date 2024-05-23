﻿using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAPI.Models
{
    public class PlayersModel
    {
        [Key]
        public int PlayerId { get; set; }
        public string? PlayerName { get; set; }
        public string? PlayerDescription { get; set;}
        public string? PlayerSkin { get; set; }

        public string? PlayerSocialNetwork1 { get; set; }

        public string? PlayerSocialNetwork2 { get; set; }

        public string? PlayerSocialNetwork3 { get; set; }
    }
}
