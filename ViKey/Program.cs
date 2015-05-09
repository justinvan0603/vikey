using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ViKey
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool _ownMutex;
            using (Mutex mutex = new Mutex(true, "ViKey", out _ownMutex))
            {
                if (_ownMutex)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ViKey());
                    mutex.ReleaseMutex();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
