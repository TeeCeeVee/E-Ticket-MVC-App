﻿using System.ComponentModel.DataAnnotations;

namespace eTicketApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string  ProfilePictureURl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
