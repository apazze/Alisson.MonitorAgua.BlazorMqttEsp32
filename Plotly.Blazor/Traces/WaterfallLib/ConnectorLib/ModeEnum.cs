/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.WaterfallLib.ConnectorLib
{
    /// <summary>
    ///     Sets the shape of connector lines.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeEnum
    {
        [EnumMember(Value=@"between")]
        Between = 0,
        [EnumMember(Value=@"spanning")]
        Spanning
    }
}