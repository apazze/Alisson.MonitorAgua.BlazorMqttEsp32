/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.GeoLib
{
    /// <summary>
    ///     Sets the resolution of the base layers. The values have units of km/mm e.g.
    ///     110 corresponds to a scale ratio of 1:110,000,000.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ResolutionEnum
    {
        [EnumMember(Value=@"110")]
        _110 = 0,
        [EnumMember(Value=@"50")]
        _50
    }
}