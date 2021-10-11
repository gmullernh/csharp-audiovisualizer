using AudioVisualizer.AudioFX;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace AudioVisualizer.Visualizations
{
    class SimpleConverter : AbstractVisualization
    {
        private List<ConsoleColor> consoleColors = new List<ConsoleColor>()
        {
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Blue
        };

        private Random _random;

        public SimpleConverter() {
            _random = new Random();
        }

        public override void RenderFrame(byte[] content)
        {
            // Filtra os dados de input
            foreach (string s in BitConverter.ToString(content).Split('-'))
            {
                WriteChunck(s);
            }
        }

        private void WriteChunck(string s)
        {
            string b = Convert.ToString(Convert.ToInt64(s, 16), 2);
            ConsoleColor _color = ConsoleColor.White;

            // Itera os binários
            foreach (char c in b)
            {
                // Se for 1, altera a cor
                if (c == '1') _color = GenerateNewColor();

                Console.ForegroundColor = _color;
                //Console.BackgroundColor = GenerateNewColor();

                Console.Write(_chars[_random.Next(0, _chars.Length)]);
            }
        }

        private char[] _chars = { '█', '▒' };

        private ConsoleColor GenerateNewColor()
        {
            return consoleColors[_random.Next(0, consoleColors.Count)];
        }

    }
}
