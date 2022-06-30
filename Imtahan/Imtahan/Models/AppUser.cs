using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan.Models
{
    public class AppUser:IdentityUser
    {
        [Required,StringLength(maximumLength:20)]
        public string Firstname { get; set; }
        [Required, StringLength(maximumLength: 30)]
        public string Lastname { get; set; }
    }
}
