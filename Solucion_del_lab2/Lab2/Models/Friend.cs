using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public enum TypeList
    {
        Adriana,
        Adrian,
        Andrea,
        Alejandra,
        Andres
    }
    public class Friend
    {
        public int FriendId { get; set; }
        public string Name { get; set; }
        public TypeList List { get; set; }
        public string Email { get; set; }
        public int Birthdate { get; set; }

    }
}