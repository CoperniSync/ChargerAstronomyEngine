using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Information about an ascending or descending node of a body.
    /// </summary>
    /// <remarks>
    /// This structure is returned by #Astronomy.SearchMoonNode and #Astronomy.NextMoonNode
    /// to report information about the center of the Moon passing through the ecliptic plane.
    /// </remarks>
    public struct NodeEventInfo
    {
        /// <summary>The time when the body passes through the ecliptic plane.</summary>
        public AstroTime time;

        /// <summary>Whether the node is ascending (south to north) or descending (north to south).</summary>
        public NodeEventKind kind;
    }
}
