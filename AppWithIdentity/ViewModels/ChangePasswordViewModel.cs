﻿using System.ComponentModel.DataAnnotations;

namespace AppWithIdentity.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        [Required]
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }
}
