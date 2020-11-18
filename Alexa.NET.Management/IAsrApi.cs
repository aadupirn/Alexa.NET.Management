using System;
using System.Collections.Generic;
using System.Text;

namespace VoicifyAlexa.NET.Management
{
    public interface IAsrApi
    {
        IAsrAnnotationSetsApi AnnotationSets { get; }

        IAsrEvaluationsApi Evaluations { get; }
    }
}
