using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Academy_Coding
{
public  class gerais
    {
        public bool campoVazio(Control control, string campo)
        {
            if(control.Text == "" || control.Text =="inválido")
            {
                MessageBox.Show("É necessario o preenchimento do campo "+campo);
                control.Focus();
                return true;
            }
            else {
                return false;
            }
        }
    }
}
