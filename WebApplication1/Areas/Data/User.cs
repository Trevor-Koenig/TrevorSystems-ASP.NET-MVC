using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Areas.Identity.Data;

public class User : IdentityUser
{
    [PersonalData]
    public DateTime DOB { get; set; }

    // these fields may potentially be used for personal high scores in games I may add in the future
    [ScaffoldColumn(false)]
    public ulong highscore1 { get; set; }

    [ScaffoldColumn(false)]
    public ulong highscore2 { get; set; }

    [ScaffoldColumn(false)]
    public ulong highscore3 { get; set; }

    [ScaffoldColumn(false)]
    public ulong highscore4 { get; set; }

    [ScaffoldColumn(false)]
    public ulong highscore5 { get; set; }
}