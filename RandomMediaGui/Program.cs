using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace RandomMediaGui
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
