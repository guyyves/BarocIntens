using BarrocIntens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntens
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static AppDbContext dbContext;

        [STAThread]
        static void Main()
        {
            dbContext = new AppDbContext();
            // De lijn hieronder uncommenten om database opnieuw aan te maken
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            dbContext?.Dispose();
            dbContext = null;
        }
    }
}
