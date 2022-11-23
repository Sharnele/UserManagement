using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class ApplicationUser : IdentityUser
    {       
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { set; get; }
                
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { set; get; }
    }
}
