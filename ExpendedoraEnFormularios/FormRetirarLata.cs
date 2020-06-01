using ClassGeneral;
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
    public partial class FormRetirarLata : Form
    {
        private Expendedora _expendedora;
        public FormRetirarLata(Expendedora e, Form formPropietario)
        {
            this._expendedora = e;
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();
        }

        public FormRetirarLata()
        {
        }
        #region "Métodos"
        private void CargarComboCodigoEx()
        {
            List<String> tipos = new List<string>();
            tipos.Add("(Elija una opción)");
            tipos.Add("CO1");
            tipos.Add("CO2");
            tipos.Add("SP1");
            tipos.Add("SP2");
            tipos.Add("FA1");
            tipos.Add("FA2");
            cmbCodigoEx.DataSource = tipos;
        }
        private void CargarListaLatas(List<Lata> latas)
        {
            lstExtraerLata.DataSource = null;
            lstExtraerLata.DataSource = latas;
            LimpiarCampos();
        }
        private void Cambiarlbl()
        {
            string codigo = cmbCodigoEx.Text;
            switch (codigo)
            {
                case "CO1":
                    lblPrecioEx.Text = "Precio: $35";
                    lblMarcaEx.Text = "Marca: Coca Cola";
                    lblSaborEx.Text = "Sabor: Regular";
                    lblVolumen.Text = "Volumen: 355cc";
                    break;
                case "CO2":
                    lblPrecioEx.Text = "Precio: $45";
                    lblMarcaEx.Text = "Marca: Coca Cola";
                    lblSaborEx.Text = "Sabor: Zero";
                    lblVolumen.Text = "Volumen: 355cc";
                    break;
                case "SP1":
                    lblPrecioEx.Text = "Precio: $33";
                    lblMarcaEx.Text = "Marca: Sprite";
                    lblSaborEx.Text = "Sabor: Regular";
                    lblVolumen.Text = "Volumen: 220cc";
                    break;
                case "SP2":
                    lblPrecioEx.Text = "Precio: $43";
                    lblMarcaEx.Text = "Marca: Sprite";
                    lblSaborEx.Text = "Sabor: Zero";
                    lblVolumen.Text = "Volumen: 220cc";
                    break;
                case "FA1":
                    lblPrecioEx.Text = "Precio: $50";
                    lblMarcaEx.Text = "Marca: Fanta";
                    lblSaborEx.Text = "Sabor: Regular";
                    lblVolumen.Text = "Volumen: 355cc";
                    break;
                case "FA2":
                    lblPrecioEx.Text = "Precio: $60";
                    lblMarcaEx.Text = "Marca: Fanta";
                    lblSaborEx.Text = "Sabor: Zero";
                    lblVolumen.Text = "Volumen: 355cc";
                    break;
                default:
                    lblPrecioEx.Text = "Precio:";
                    lblMarcaEx.Text = "Marca:";
                    lblSaborEx.Text = "Sabor:";
                    lblVolumen.Text = "Volumen:";
                    break;
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (cmbCodigoEx.SelectedValue.ToString() == "(Elija una opción)")
            {
                msg = "Debe seleccionar un tipo\n";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }
        private void LimpiarCampos()
        {
            txtDinero.Text = string.Empty;
            cmbCodigoEx.SelectedIndex = 0;
        }
        private string TraerTipoSeleccionado()
        {
            string codigo = cmbCodigoEx.Text;
            switch (codigo)
            {
                case "CO1":
                    return "CO1";
                case "CO2":
                    return "CO2";
                case "SP1":
                    return "SP1";
                case "SP2":
                    return "SP2";
                case "FA1":
                    return "FA1";
                case "FA2":
                    return "FA2";
                default:
                    return "";
            }
        }
        private void CompletarFormulario(Lata seleccionada)
        {
            switch (seleccionada.Codigo)
            {
                case "CO1":
                    cmbCodigoEx.SelectedIndex = 1;
                    break;
                case "CO2":
                    cmbCodigoEx.SelectedIndex = 2;
                    break;
                case "SP1":
                    cmbCodigoEx.SelectedIndex = 3;
                    break;
                case "SP2":
                    cmbCodigoEx.SelectedIndex = 4;
                    break;
                case "FA1":
                    cmbCodigoEx.SelectedIndex = 5;
                    break;
                case "FA2":
                    cmbCodigoEx.SelectedIndex = 6;
                    break;
                default:
                    cmbCodigoEx.SelectedIndex = 0;
                    break;
            }
            txtDinero.Text = seleccionada.Precio.ToString();
        }
        private void GrisarCampos()
        {
            cmbCodigoEx.Enabled = false;
            txtDinero.Enabled = false;
            btnExtraer.Enabled = false;
        }
        private void BloquearExtraccion()
        {
            MessageBox.Show("No hay latas para extraer, por favor ingrese latas en la opción correspondiente", "Expendedora vacía");
            GrisarCampos();
        }
        #endregion
        #region "Eventos"
        private void FormRetirarLata_Load(object sender, EventArgs e)
        {
            CargarComboCodigoEx();
            CargarListaLatas(_expendedora.Latas);
            if (_expendedora.Latas.Count == 0)
            {
                BloquearExtraccion();
            }
            lstExtraerLata.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = cmbCodigoEx.SelectedValue.ToString();
            if (cod != "(Elija una opción)")
            {
                foreach (Lata l in ((List<Lata>)lstExtraerLata.DataSource))
                {
                    if (l.Codigo == cod)
                    {
                        lstExtraerLata.SelectedItem = l;
                    }
                }
            }
            else
            {
                txtDinero.Text = String.Empty;
            }
            Cambiarlbl();
        }
        private void btnApagarEx_Click(object sender, EventArgs e)
        {
            if (cmbCodigoEx.SelectedIndex != 0 || txtDinero.Text != String.Empty)
            {
                DialogResult pregunta = MessageBox.Show("Se perderán los datos ingresados. ¿Está seguro de cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo);
                if (pregunta.ToString() == "Yes")
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void btnVolverEx_Click(object sender, EventArgs e)
        {
            if (cmbCodigoEx.SelectedIndex != 0 || txtDinero.Text != String.Empty)
            {
                DialogResult pregunta = MessageBox.Show("Se perderán los datos ingresados. ¿Está seguro de volver al menú principal?", "Atención", MessageBoxButtons.YesNo);
                if (pregunta.ToString() == "Yes")
                {
                    ((ExpendedoraForms.FormMaqExpendedora)this.Owner).ShowReload();
                    this.Dispose();
                }
            }
            else
            {
                ((ExpendedoraForms.FormMaqExpendedora)this.Owner).ShowReload();
                this.Dispose();
            }
        }
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (txtDinero.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el dinero para comprar la lata.");
            }
            else
            {
                try
                {
                    if (ValidarCampos())
                    {
                        ExtraccionObtenida result = _expendedora.ExtraerLata(TraerTipoSeleccionado(), Convert.ToDouble(txtDinero.Text));
                        if (Convert.ToDouble(txtDinero.Text) > result.Lata.Precio)
                        {
                            MessageBox.Show("Ha comprado la lata: " + result.Lata.Nombre + " sabor " + result.Lata.Sabor + "\nSu vuelto: $" + result.Vuelto.ToString());
                        }
                        else if (Convert.ToDouble(txtDinero.Text) == result.Lata.Precio)
                        {
                            MessageBox.Show("Ha comprado la lata: " + result.Lata.Nombre + " sabor " + result.Lata.Sabor);
                        }
                        CargarListaLatas(_expendedora.Latas);
                        lstExtraerLata.SelectedIndex = -1;
                        if (_expendedora.Latas.Count == 0)
                        {
                            BloquearExtraccion();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void lstExtraerLata_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lata seleccionada = (Lata)lstExtraerLata.SelectedItem;
            if (seleccionada != null)
            {
                CompletarFormulario(seleccionada);
            }
        }
        private void FormRetirarLata_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
