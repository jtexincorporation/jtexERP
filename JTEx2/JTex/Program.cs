using DevExpress.LookAndFeel;
using DevExpress.Skins;
using JTex.Forms;
using JTex.Forms.Accounts;
using JTex.Forms.ArTMS;
using JTex.Forms.ArTMS.Articles;
using JTex.Forms.HR;
using JTex.Forms.Inventory;
using JTex.Forms.Inventory.Yarn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTex
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
            Application.Run(new YarnMainForm());
        }
      
    }
}
