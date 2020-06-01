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

namespace ExpendedoraEnFormularios
{
    public partial class FormIngresarLata : Form
    {
        private Expendedora _expendedora;
        public FormIngresarLata(Expendedora e, Form formPropietario)
        {
            this._expendedora = e;
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();
        }

        public FormIngresarLata()
        {
        }
        #region "Métodos"
        private void CargarListaLatas(List<Lata> latas)
        {
            lstLatasIngreso.DataSource = null;
            lstLatasIngreso.DataSource = latas;
            LimpiarCampos();
        }
        private void CargarComboCodigo()
        {
            List<String> tipos = new List<string>();
            tipos.Add("(Elija una opción)");
            tipos.Add("CO1");
            tipos.Add("CO2");
            tipos.Add("SP1");
            tipos.Add("SP2");
            tipos.Add("FA1");
            tipos.Add("FA2");
            cmbCodigo.DataSource = tipos;
        }
        private void Cambiarlbl()
        {
            string codigo = cmbCodigo.Text;
            switch (codigo)
            {
                case "CO1":
                    lblPrecio.Text = "Precio: $35";
                    lblMarca.Text = "Marca: Coca Cola";
                    lblSabor.Text = "Sabor: Regular";
                    break;
                case "CO2":
                    lblPrecio.Text = "Precio: $45";
                    lblMarca.Text = "Marca: Coca Cola";
                    lblSabor.Text = "Sabor: Zero";
                    break;
                case "SP1":
                    lblPrecio.Text = "Precio: $33";
                    lblMarca.Text = "Marca: Sprite";
                    lblSabor.Text = "Sabor: Regular";
                    break;
                case "SP2":
                    lblPrecio.Text = "Precio: $43";
                    lblMarca.Text = "Marca: Sprite";
                    lblSabor.Text = "Sabor: Zero";
                    break;
                case "FA1":
                    lblPrecio.Text = "Precio: $50";
                    lblMarca.Text = "Marca: Fanta";
                    lblSabor.Text = "Sabor: Regular";
                    break;
                case "FA2":
                    lblPrecio.Text = "Precio: $60";
                    lblMarca.Text = "Marca: Fanta";
                    lblSabor.Text = "Sabor: Zero";
                    break;
                default:
                    lblPrecio.Text = "Precio:";
                    lblMarca.Text = "Marca:";
                    lblSabor.Text = "Sabor:";
                    break;
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (cmbCodigo.SelectedValue.ToString() == "(Elija una opción)")
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
            txtVolumen.Text = string.Empty;
            cmbCodigo.SelectedIndex = 0;
        }
        private string TraerTipoSeleccionado()
        {
            string codigo = cmbCodigo.Text;
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
                    cmbCodigo.SelectedIndex = 1;
                    break;
                case "CO2":
                    cmbCodigo.SelectedIndex = 2;
                    break;
                case "SP1":
                    cmbCodigo.SelectedIndex = 3;
                    break;
                case "SP2":
                    cmbCodigo.SelectedIndex = 4;
                    break;
                case "FA1":
                    cmbCodigo.SelectedIndex = 5;
                    break;
                case "FA2":
                    cmbCodigo.SelectedIndex = 6;
                    break;
                default:
                    cmbCodigo.SelectedIndex = 0;
                    break;
            }
            txtVolumen.Text = seleccionada.Volumen.ToString();
        }
        private void GrisarCampos()
        {
            cmbCodigo.Enabled = false;
            txtVolumen.Enabled = false;
            btnIngresar.Enabled = false;
        }
        private void BloquearIngreso()
        {
            MessageBox.Show("Se alcanzó la capacidad máxima de la expendedora. No se podrán ingresar más latas hasta que se alguna sea extraída.", "Límite de latas alcanzado");
            GrisarCampos();
        }
        #endregion
        #region "Eventos"
        private void FormIngresarLata_Load(object sender, EventArgs e)
        {
            CargarComboCodigo();
            CargarListaLatas(_expendedora.Latas);
            if (_expendedora.GetCapacidadRestante() == 0)
            {
                BloquearIngreso();
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != 0 || txtVolumen.Text != String.Empty)
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
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = cmbCodigo.SelectedValue.ToString();
            if (cod != "(Elija una opción)")
            {
                foreach (Lata l in ((List<Lata>)lstLatasIngreso.DataSource))
                {
                    if (l.Codigo == cod)
                    {
                        lstLatasIngreso.SelectedItem = l;
                    }
                }
            }
            else
            {
                txtVolumen.Text = String.Empty;
                lstLatasIngreso.SelectedIndex = -1;
            }
            Cambiarlbl();
        }
        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != 0 || txtVolumen.Text != String.Empty)
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtVolumen.Text == String.Empty)
            {
                MessageBox.Show("Debe especificar el volumen de la lata");
            }
            else
            {
                try
                {
                    if (ValidarCampos())
                    {
                        _expendedora.AgregarLata(new Lata(TraerTipoSeleccionado(), Convert.ToDouble(txtVolumen.Text)));
                        MessageBox.Show("Se ha añadido la lata a la expendedora.");
                        CargarListaLatas(_expendedora.Latas);
                        if (_expendedora.GetCapacidadRestante() == 0)
                        {
                            BloquearIngreso();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void lstLatasIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lata seleccionada = (Lata)lstLatasIngreso.SelectedItem;
            if (seleccionada != null)
            {
                CompletarFormulario(seleccionada);
            }
        }
        private void FormIngresarLata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void txtVolumen_TextChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion
}
