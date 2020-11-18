using System;

namespace VoicifyAlexa.NET.Management.SkillSets
{
    public class InvalidStageException : Exception
    {
        public InvalidStageException(string message):base(message)
        {
            
        }
    }
}