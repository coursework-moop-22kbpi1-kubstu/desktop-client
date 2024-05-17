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

            Model.Model model = new Model.Model();
            ViewModel viewModel = new ViewModel();
            DesktopAppForm view = new DesktopAppForm();
            model.ViewModel = viewModel;
            viewModel.view = view;
            viewModel.model = model;
            view.viewModel = viewModel;

            Application.Run(view);
        }
    }
}
