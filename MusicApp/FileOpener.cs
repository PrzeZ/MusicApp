using System.Threading.Tasks;

namespace MusicApp
{
    internal class FileOpener
    {
        public async Task OpenFileAsync(string path)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(path)
            {
                UseShellExecute = true
            };
            p.Start();

            await Task.Delay(1000);
        }
    }
}
