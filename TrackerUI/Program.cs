using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize which databse connections we are going to talk to
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            // Pick the first form that will be open
            Application.Run(new CreatePrizeForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
