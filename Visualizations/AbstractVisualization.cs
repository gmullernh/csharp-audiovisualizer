using System;
using System.Collections.Generic;
using System.Text;

namespace AudioVisualizer.Visualizations
{
    /// <summary>
    /// Visualization is responsible for the rendered content.
    /// </summary>
    public abstract class AbstractVisualization
    {
        public abstract void RenderFrame(byte[] content);
    }
}
