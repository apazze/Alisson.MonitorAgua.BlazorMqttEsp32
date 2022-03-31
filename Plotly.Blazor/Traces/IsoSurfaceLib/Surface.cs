/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.IsoSurfaceLib
{
    /// <summary>
    ///     The Surface class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Surface : IEquatable<Surface>
    {
        /// <summary>
        ///     Sets the number of iso-surfaces between minimum and maximum iso-values.
        ///     By default this value is 2 meaning that only minimum and maximum surfaces
        ///     would be drawn.
        /// </summary>
        [JsonPropertyName(@"count")]
        public int? Count { get; set;} 

        /// <summary>
        ///     Sets the fill ratio of the iso-surface. The default fill value of the surface
        ///     is 1 meaning that they are entirely shaded. On the other hand Applying a
        ///     <c>fill</c> ratio less than one would allow the creation of openings parallel
        ///     to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public decimal? Fill { get; set;} 

        /// <summary>
        ///     Sets the surface pattern of the iso-surface 3-D sections. The default pattern
        ///     of the surface is <c>all</c> meaning that the rest of surface elements would
        ///     be shaded. The check options (either 1 or 2) could be used to draw half
        ///     of the squares on the surface. Using various combinations of capital <c>A</c>,
        ///     <c>B</c>, <c>C</c>, <c>D</c> and <c>E</c> may also be used to reduce the
        ///     number of triangles on the iso-surfaces and creating other patterns of interest.
        /// </summary>
        [JsonPropertyName(@"pattern")]
        public Plotly.Blazor.Traces.IsoSurfaceLib.SurfaceLib.PatternFlag? Pattern { get; set;} 

        /// <summary>
        ///     Hides/displays surfaces between minimum and maximum iso-values.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Surface other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Surface other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Count == other.Count ||
                    Count != null &&
                    Count.Equals(other.Count)
                ) && 
                (
                    Fill == other.Fill ||
                    Fill != null &&
                    Fill.Equals(other.Fill)
                ) && 
                (
                    Pattern == other.Pattern ||
                    Pattern != null &&
                    Pattern.Equals(other.Pattern)
                ) && 
                (
                    Show == other.Show ||
                    Show != null &&
                    Show.Equals(other.Show)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Count != null) hashCode = hashCode * 59 + Count.GetHashCode();
                if (Fill != null) hashCode = hashCode * 59 + Fill.GetHashCode();
                if (Pattern != null) hashCode = hashCode * 59 + Pattern.GetHashCode();
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Surface and the right Surface.
        /// </summary>
        /// <param name="left">Left Surface.</param>
        /// <param name="right">Right Surface.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Surface left, Surface right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Surface and the right Surface.
        /// </summary>
        /// <param name="left">Left Surface.</param>
        /// <param name="right">Right Surface.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Surface left, Surface right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Surface</returns>
        public Surface DeepClone()
        {
            return this.Copy();
        }
    }
}