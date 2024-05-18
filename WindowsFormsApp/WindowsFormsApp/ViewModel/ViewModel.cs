using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ViewModel
    {
        public DesktopAppForm Form;
        public Model.Model model;
        public Color FColor = Color.Black;
        public Color BColor = Color.White;

        public void StartAuthorizationProcess()
        {
            Form.PnlContent.Controls.Add(Form.PnlUserLogin);
        }
        public void EndAuthorizationProcess()
        {
            Form.PnlContent.Controls.Remove(Form.PnlUserLogin);
        }


        public void StartRegistrationProcess()
        {
            Form.PnlContent.Controls.Add(Form.PnlRegistrationUser);
        }
        public void EndRegistrationProcess()
        {
            Form.PnlContent.Controls.Remove(Form.PnlRegistrationUser);
        }


        public void EndWorkProcess()
        {
            Form.PnlContent.Controls.Remove(Form.PnlMainMenu);
        }
        public void StartWorkProcess()
        {
            Form.PnlContent.Controls.Add(Form.PnlMainMenu);
        }
    }
}