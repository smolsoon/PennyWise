﻿namespace PennyWise.Shared.Infrastructure.Modules;

internal record ModuleInfo(string Name, string Path, IEnumerable<string> Policies);