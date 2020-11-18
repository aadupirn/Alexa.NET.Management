using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.Management.ReferenceCatalogManagement
{
    public enum CatalogResourceType
    {
        [EnumMember(Value="Catalog")]
        Catalog,
        [EnumMember(Value="SlotType")]
        SlotType,
        [EnumMember(Value="InterationModel")]
        InterationModel
    }
}