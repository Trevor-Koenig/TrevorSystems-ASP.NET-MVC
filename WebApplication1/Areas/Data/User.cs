using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace TAApplication.Areas.Data
{
    [Index( nameof( Uid), IsUnique = true )]
    public class TAUser : IdentityUser
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public string? ReferredTo { get; set; }
    }
}
