using ClassGeneral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpendedoraForms
{
    public partial class FormMaqExpendedora : Form
    {
        private Expendedora _expendedora;
        public Expendedora Expendedora
        {
            get
            {
                return _expendedora;
            }
        }
        public FormMaqExpendedora(Expendedora exp)
        {
            _expendedora = exp;
            InitializeComponent();
        }

        public FormMaqExpendedora()
        {
        }
        #region "Métodos"
        private void CargarListaLatas(List<Lata> latas)
        {
            lstLatas.DataSource = null;
            lstLatas.DataSource = latas;
        }
        private string ObtenerStock()
        {
            string stock = "";
            if (_expendedora.EstaVacia())
            {
                stock = "La máquina expendedora no posee stock.";
            }
            else
            {
                foreach (Lata l in _expendedora.Latas)
                {
                    stock += String.Format("{0} - {1} ${2} / $/L {3}", l.Nombre, l.Sabor, l.Precio, l.GetPrecioPorLitro() + "\n");
                }
            }
            return stock;
        }
        public void ShowReload()
        {
            CargarListaLatas(_expendedora.Latas);
            lstLatas.SelectedIndex = -1;
            this.Show();
        }
        #endregion
        #region "Eventos"
        private void FormMaqExpendedora_Load(object sender, EventArgs e)
        {
            CargarListaLatas(_expendedora.Latas);
            lstLatas.SelectedIndex = -1;
        }
        private void lstLatas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnIngresarLata_Click(object sender, EventArgs e)
        {
            ExpendedoraEnFormularios.FormIngresarLata fexp = new ExpendedoraEnFormularios.FormIngresarLata(_expendedora, this);
            fexp.Owner = this;
            fexp.Show();
            this.Hide();
        }
        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            if (lstLatas == null)
            {
                MessageBox.Show("La máquina está vacía. No se pueden extraer latas.");
            }
            else
            {
                ExpendedoraEnFormularios.FormRetirarLata fexp = new ExpendedoraEnFormularios.FormRetirarLata(_expendedora, this);
                fexp.Owner = this;
                fexp.Show();
                this.Hide();
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balance de la máquina expendedora:\n" + _expendedora.GetBalance(), "Balance");
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ObtenerStock(), "Stock");
        }
        private void FormMaqExpendedora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    #endregion
}