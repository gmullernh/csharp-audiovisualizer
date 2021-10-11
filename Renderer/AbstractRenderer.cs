using System;
using System.Collections.Generic;
using System.Text;

namespace AudioVisualizer.Renderer
{
    /// <summary>
    /// Renderer is responsible for the rendering parameters.
    /// </summary>
    public abstract class AbstractRenderer
    {
        private decimal Frametime { get; }
        private int FramesPerSecond { get; }
        public abstract void RenderFrame(byte[] content);
        Visualizations.AbstractVisualization Visualization { get; set; }
    }
}
