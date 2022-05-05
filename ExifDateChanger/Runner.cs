using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifDateChanger
{
    public class Runner
    {
        private readonly Process _process;

        public Runner(string exifToolPath)
        {
            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exifToolPath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage)
                }
            };
        }

        public List<string> Command(string args)
        {
            _process.StartInfo.Arguments = args;

            var output = new List<string>();

            _process.Start();
            while (!_process.StandardOutput.EndOfStream)
            {
                output.Add(_process.StandardOutput.ReadLine());
            }

            return output;
        }
    }
}
