﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Classes
{
    public class SiteSettings
    {
        public JwtSettings JwtSettings { get; set; }
        public AdminUserSeed AdminUserSeed { get; set; }
    }

    public class JwtSettings
    {
        public string SecretKey { get; set; }
        public string EncrypKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int NotBeforeMinutes { get; set; }
        public int ExpirationMinutes { get; set; }

    }
    public class AdminUserSeed
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
    }
}
