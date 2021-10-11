using System;
using System.Collections.Generic;
using System.Text;
using AudioVisualizer.AudioFX;

namespace AudioVisualizer.Visualizations
{
    class ComplexConverter : AbstractVisualization
    {
        public override void RenderFrame(byte[] content)
        {
            Console.WriteLine(BitConverter.ToString(content));
        }
    }
}
