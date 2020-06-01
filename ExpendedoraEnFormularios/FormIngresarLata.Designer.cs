namespace ExpendedoraEnFormularios
{
    partial class FormIngresarLata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstLatasIngreso = new System.Windows.Forms.ListBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIngresarLata = new System.Windows.Forms.Label();
            this.lblSelCodigo = new System.Windows.Forms.Label();
            this.lblIngreseVolumen = new System.Windows.Forms.Label();
            this.lblDatosLata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLatasIngreso
            // 
            this.lstLatasIngreso.FormattingEnabled = true;
            this.lstLatasIngreso.Location = new System.Drawing.Point(502, 22);
            this.lstLatasIngreso.Name = "lstLatasIngreso";
            this.lstLatasIngreso.Size = new System.Drawing.Size(286, 199);
            this.lstLatasIngreso.TabIndex = 0;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(326, 77);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 1;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(16, 249);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(16, 292);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 18);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(16, 337);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(52, 18);
            this.lblSabor.TabIndex = 4;
            this.lblSabor.Text = "Sabor:";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(296, 132);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(114, 20);
            this.txtVolumen.TabIndex = 5;
            this.txtVolumen.TextChanged += new System.EventHandler(this.txtVolumen_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(613, 249);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(19, 415);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(372, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblIngresarLata
            // 
            this.lblIngresarLata.AutoSize = true;
            this.lblIngresarLata.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarLata.Location = new System.Drawing.Point(12, 9);
            this.lblIngresarLata.Name = "lblIngresarLata";
            this.lblIngresarLata.Size = new System.Drawing.Size(254, 39);
            this.lblIngresarLata.TabIndex = 9;
            this.lblIngresarLata.Text = "Ingrese su Lata";
            // 
            // lblSelCodigo
            // 
            this.lblSelCodigo.AutoSize = true;
            this.lblSelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelCodigo.Location = new System.Drawing.Point(14, 73);
            this.lblSelCodigo.Name = "lblSelCodigo";
            this.lblSelCodigo.Size = new System.Drawing.Size(306, 25);
            this.lblSelCodigo.TabIndex = 10;
            this.lblSelCodigo.Text = "Seleccione su código favorito: ";
            // 
            // lblIngreseVolumen
            // 
            this.lblIngreseVolumen.AutoSize = true;
            this.lblIngreseVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseVolumen.Location = new System.Drawing.Point(14, 127);
            this.lblIngreseVolumen.Name = "lblIngreseVolumen";
            this.lblIngreseVolumen.Size = new System.Drawing.Size(271, 25);
            this.lblIngreseVolumen.TabIndex = 11;
            this.lblIngreseVolumen.Text = "Ingrese volumen deseado: ";
            // 
            // lblDatosLata
            // 
            this.lblDatosLata.AutoSize = true;
            this.lblDatosLata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosLata.Location = new System.Drawing.Point(15, 197);
            this.lblDatosLata.Name = "lblDatosLata";
            this.lblDatosLata.Size = new System.Drawing.Size(311, 24);
            this.lblDatosLata.TabIndex = 12;
            this.lblDatosLata.Text = "Información sobre la lata a ingresar: ";
            // 
            // FormIngresarLata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatosLata);
            this.Controls.Add(this.lblIngreseVolumen);
            this.Controls.Add(this.lblSelCodigo);
            this.Controls.Add(this.lblIngresarLata);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbCodigo);
            this.Controls.Add(this.lstLatasIngreso);
            this.Name = "FormIngresarLata";
            this.Text = "FormIngresarLata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLatasIngreso;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblIngresarLata;
        private System.Windows.Forms.Label lblSelCodigo;
        private System.Windows.Forms.Label lblIngreseVolumen;
        private System.Windows.Forms.Label lblDatosLata;
    }
}