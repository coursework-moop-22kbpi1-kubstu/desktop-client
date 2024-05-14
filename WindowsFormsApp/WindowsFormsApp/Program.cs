using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            ViewModel viewModel = new ViewModel();
            DesktopAppForm view = new DesktopAppForm();
            model.viewModel = viewModel;
            viewModel.view = view;
            viewModel.model = model;
            view.viewModel = viewModel;

            Application.Run(view);
        }
    }
}
