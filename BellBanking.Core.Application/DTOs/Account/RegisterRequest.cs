﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellBanking.Core.Application.DTOs.Account
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string NationalId { get; set; }
    }
}
