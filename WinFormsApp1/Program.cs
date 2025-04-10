using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Blackjack
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}