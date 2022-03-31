/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.WaterfallLib
{
    /// <summary>
    ///     Constrain the size of text inside or outside a bar to be no larger than
    ///     the bar itself.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ConstrainTextEnum
    {
        [EnumMember(Value=@"both")]
        Both = 0,
        [EnumMember(Value=@"inside")]
        Inside,
        [EnumMember(Value=@"outside")]
        Outside,
        [EnumMember(Value=@"none")]
        None
    }
}