using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AudioVisualizer.Loopback
{
    class LoopbackWatcher : IDisposable
    {

        public LoopbackWatcher(Renderer.AbstractRenderer renderingEngine)
        {
            WasapiLoopbackCapture WasapiLoopbackCapture = new WasapiLoopbackCapture();
            WasapiLoopbackCapture.StartRecording();
            WasapiLoopbackCapture.DataAvailable += (s, a) =>
            {
                renderingEngine.RenderFrame(a.Buffer);
            };

        }

        public void Dispose()
        {
          //  WasapiLoopbackCapture.Dispose();
        }
    }
}
