using System;
using System.Collections.Generic;
using System.Text;

namespace AudioVisualizer.AudioFX
{
    interface IAudioFX
    {
        byte[] InputStream { get; set; }
        byte[] OutputStrem { get; set; }

    }
}
