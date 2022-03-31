/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterTernaryLib.LineLib
{
    /// <summary>
    ///     Determines the line shape. With <c>spline</c> the lines are drawn using
    ///     spline interpolation. The other available values correspond to step-wise
    ///     line shapes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear = 0,
        [EnumMember(Value=@"spline")]
        Spline
    }
}