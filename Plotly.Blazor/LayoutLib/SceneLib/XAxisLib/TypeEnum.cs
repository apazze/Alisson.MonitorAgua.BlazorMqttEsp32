/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.SceneLib.XAxisLib
{
    /// <summary>
    ///     Sets the axis type. By default, plotly attempts to determined the axis type
    ///     by looking into the data of the traces that referenced the axis in question.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"-")]
        Minus = 0,
        [EnumMember(Value=@"linear")]
        Linear,
        [EnumMember(Value=@"log")]
        Log,
        [EnumMember(Value=@"date")]
        Date,
        [EnumMember(Value=@"category")]
        Category
    }
}