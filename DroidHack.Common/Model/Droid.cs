using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Common.Model;

public class Droid
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid UserId { get; set; }
    public Guid UserName { get; set; }
    public ModelPropertySet Properties { get; set; }
    public string Code { get; set; }
    public List<DroidDevice> DroidDevices { get; set; }
}
