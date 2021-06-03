using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AcademyCoding
{
    public class Gerais
    {
        public bool CampoVazio(Control control, string campo)
        {
            if (control.Text == "")
            {
                MessageBox.Show("É necessario o preenchimento do campo " + campo);
                control.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
