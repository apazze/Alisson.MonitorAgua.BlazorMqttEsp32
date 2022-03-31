/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.Scatter3DLib.LineLib
{
    /// <summary>
    ///     Sets the dash style of the lines.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DashEnum
    {
        [EnumMember(Value=@"solid")]
        Solid = 0,
        [EnumMember(Value=@"dash")]
        Dash,
        [EnumMember(Value=@"dashdot")]
        DashDot,
        [EnumMember(Value=@"dot")]
        Dot,
        [EnumMember(Value=@"longdash")]
        LongDash,
        [EnumMember(Value=@"longdashdot")]
        LongDashDot
    }
}