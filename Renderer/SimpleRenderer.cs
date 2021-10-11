using AudioVisualizer.Visualizations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AudioVisualizer.Renderer
{
    class SimpleRenderer : AbstractRenderer
    {
        public AbstractVisualization Visualization { get; set; }

        private int FramesPerSecond => 60;

        private decimal Frametime => 1000 / FramesPerSecond;

        public SimpleRenderer(AbstractVisualization vis)
        {
            Visualization = vis;
        }

        public override void RenderFrame(byte[] content)
        {
            Visualization.RenderFrame(content);
            Thread.Sleep((int)Math.Round(Frametime));
        }
    }
}
