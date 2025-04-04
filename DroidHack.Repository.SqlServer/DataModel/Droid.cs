﻿using DroidHack.Common.Enums;
using System.Diagnostics.SymbolStore;

namespace DroidHack.Repository.SqlServer.DataModel;

public class Droid
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ParameterJson { get; set; }
    public string Code { get; set; }
    public string Version { get; set; }
    public DroidLanguage Language { get; set; }

    public Guid DroidHackId { get; set; }

    public DroidHackUser User { get; set; }
    public List<DroidDevice> DroidDevices { get; set; }
}

