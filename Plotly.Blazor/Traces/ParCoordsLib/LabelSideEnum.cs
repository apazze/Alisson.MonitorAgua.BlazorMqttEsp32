/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ParCoordsLib
{
    /// <summary>
    ///     Specifies the location of the <c>label</c>. <c>top</c> positions labels
    ///     above, next to the title <c>bottom</c> positions labels below the graph
    ///     Tilted labels with <c>labelangle</c> may be positioned better inside margins
    ///     when <c>labelposition</c> is set to <c>bottom</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum LabelSideEnum
    {
        [EnumMember(Value=@"top")]
        Top = 0,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}