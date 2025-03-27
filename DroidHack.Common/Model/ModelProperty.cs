using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Common.Model;

public class ModelProperty
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class ModelPropertySet
{
    public Dictionary<string, ModelProperty> Properties { get; set; }
}