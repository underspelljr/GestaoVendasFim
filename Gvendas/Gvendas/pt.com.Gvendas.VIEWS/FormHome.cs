using Gvendas.pt.com.Gvendas.VIEWS;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonManipular_Click(object sender, EventArgs e)
        {
            FormGerirDados form = new FormGerirDados();
            form.ShowDialog();
             
        }
    }
}
