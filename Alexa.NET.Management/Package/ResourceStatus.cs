using System;
using System.Collections.Generic;
using System.Text;

namespace VoicifyAlexa.NET.Management.Package
{
    public enum ResourceStatus
    {
        FAILED,
        IN_PROGRESS,
        SKIPPED,
        SUCCEEDED,
        ROLLBACK_IN_PROGRESS,
        ROLLBACK_SUCCEEDED,
        ROLLBACK_FAILED
    }
}
