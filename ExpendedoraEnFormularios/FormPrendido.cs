using ClassGeneral;
using ExpendedoraForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpendedoraEnFormularios
{
    public partial class FormPrendido : Form
    {
        public FormPrendido()
        {
            InitializeComponent();
        }

        private void BtnPrender_Click(object sender, EventArgs e)
        {
            Expendedora appExpendedora = new Expendedora("FCE", 50);
            FormMaqExpendedora fexp = new FormMaqExpendedora(appExpendedora);
            fexp.Owner = this;
            fexp.Show();
            this.Hide();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEncendido_Load(object sender, EventArgs e)
        {

        }
    }
}
