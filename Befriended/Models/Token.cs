﻿using System;
namespace Befriended.Droid.Models
{
    class Token
    {
        public int id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }

        public Token() { }

    }
}