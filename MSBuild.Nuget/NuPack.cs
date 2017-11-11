using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MSBuild.Nuget
{
    public class NuPack : Task
    {
        public override bool Execute()
        {
            Log.LogMessage("NuPack Message");
            Log.LogWarning("NuPack Warning");
            Log.LogError("NuPack Error");
            return true;
        }
    }
}
