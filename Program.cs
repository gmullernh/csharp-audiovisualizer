using System;

namespace AudioVisualizer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Rendering Engine";

            Visualizations.SimpleConverter simpleConverter = new Visualizations.SimpleConverter();
            Renderer.SimpleRenderer simpleRenderer = new Renderer.SimpleRenderer(simpleConverter);
            using Loopback.LoopbackWatcher loopbackWatcher = new Loopback.LoopbackWatcher(simpleRenderer);
        }

    }
}
