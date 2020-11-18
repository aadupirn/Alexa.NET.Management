using System;
using System.Collections.Generic;
using System.Text;

namespace VoicifyAlexa.NET.Management.InteractionModel.ValidationRules
{
    public class HasEntityResolutionMatch : DialogSlotValidation
    {
        public const string ValidationType = "hasEntityResolutionMatch";
        public override string Type => ValidationType;

    }
}
