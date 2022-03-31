/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.HistogramLib.CumulativeLib
{
    /// <summary>
    ///     Only applies if cumulative is enabled. If <c>increasing</c> (default) we
    ///     sum all prior bins, so the result increases from left to right. If <c>decreasing</c>
    ///     we sum later bins so the result decreases from left to right.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value=@"increasing")]
        Increasing = 0,
        [EnumMember(Value=@"decreasing")]
        Decreasing
    }
}