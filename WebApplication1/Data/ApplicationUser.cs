using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { set; get; }
    }
}
