using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mixer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();


            IModel model = new Model();
            IController controller = new Controller(model);
            View view = new View(controller);

            model.addObserver((IBeatObserver)view);
            model.addObserver((IBPMObserver)view);
            
            Application.Run(view);
        }
    }
}
