using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Common.Model;

public class DroidHackUser
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }

}
