using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using System.Windows.Forms;
using therapyDB.data;

namespace therapyDB
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GCSettings.LatencyMode = GCLatencyMode.LowLatency;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WarmUpEntityFramework();
            Application.Run(new Index());
        }

        private static void WarmUpEntityFramework()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var _ = db.patients.FirstOrDefault();
                _ = null;
            }

            GC.Collect();
        }
    }
}
