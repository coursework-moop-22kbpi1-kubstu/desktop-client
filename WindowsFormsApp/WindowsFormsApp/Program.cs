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

            DesktopAppForm desktopAppForm = new DesktopAppForm();

            Model.Model model = new Model.Model();
            ViewModel.ViewModel viewModel = new ViewModel.ViewModel();
            View.View view = new View.View(desktopAppForm);
            desktopAppForm.view = view;

            viewModel.model = model;
            viewModel.view = view;
            view.ViewModel = viewModel;

            model.AddNewUserEvent += viewModel.EventNewUser;
            model.AddNewNotificationEvent += viewModel.EventNewNotification;

            viewModel.AddNewUserEvent += view.EventNewUser;
            viewModel.AddNewNotificationEvent += view.EventNewNotification;

            desktopAppForm.Init();
            Application.Run(desktopAppForm);
        }
    }
}
