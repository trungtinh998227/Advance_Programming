using KaraokeApp.Views;
using System.Windows.Forms;

namespace KaraokeApp
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bill_Infor());
        }
    }
}
