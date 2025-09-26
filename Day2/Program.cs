using System;
using System.Windows.Forms;

namespace WinFormsEfCrud
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using var context = new Models.UniversityContext(); // uses default constructor; edit connection string there
            var repo = new Repositories.GenericRepository<Models.Student>(context);
            Application.Run(new Forms.MainForm(repo));
        }
    }
}
