using System;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormGerirDados : Form
    {
        public FormGerirDados()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormEscolhaGestão form = new FormEscolhaGestão();
            form.ShowDialog();
             
        }

        private void buttonEditarRemover_Click(object sender, EventArgs e)
        {
            FormUpdateDelete form = new FormUpdateDelete(1);
            form.ShowDialog();
        }
    }
}
