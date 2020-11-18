using System;
using System.Collections.Generic;
using System.Text;

namespace VoicifyAlexa.NET.Management.Validation
{
    public class SkillValidationResponse
    {
        public string Id { get; set; }
        public ValidationStatus Status { get; set; }
        public ValidationResult Result { get; set; }
    }
}
