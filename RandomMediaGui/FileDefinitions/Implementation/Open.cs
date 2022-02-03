using System.Diagnostics;

namespace RandomMediaGui.FileDefinitions.Implementation
{
    class Open
    {

        public Open(string filePath) {
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }
    }
}
