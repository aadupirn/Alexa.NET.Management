using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management
{
    public enum SortDirection
    {
        [EnumMember(Value ="asc")]
        Ascending,
        [EnumMember(Value="desc")]
        Descending
    }
}