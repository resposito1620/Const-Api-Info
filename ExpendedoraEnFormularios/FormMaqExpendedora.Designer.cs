namespace ExpendedoraForms
{
    partial class FormMaqExpendedora
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
            this.lstLatas = new System.Windows.Forms.ListBox();
            this.btnIngresarLata = new System.Windows.Forms.Button();
            this.btnExtraerLata = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.lblMaqExpendedora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLatas
            // 
            this.lstLatas.FormattingEnabled = true;
            this.lstLatas.Location = new System.Drawing.Point(19, 59);
            this.lstLatas.Name = "lstLatas";
            this.lstLatas.Size = new System.Drawing.Size(315, 121);
            this.lstLatas.TabIndex = 0;
            this.lstLatas.SelectedIndexChanged += new System.EventHandler(this.lstLatas_SelectedIndexChanged);
            // 
            // btnIngresarLata
            // 
            this.btnIngresarLata.Location = new System.Drawing.Point(359, 59);
            this.btnIngresarLata.Name = "btnIngresarLata";
            this.btnIngresarLata.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarLata.TabIndex = 1;
            this.btnIngresarLata.Text = "Ingresar";
            this.btnIngresarLata.UseVisualStyleBackColor = true;
            // 
            // btnExtraerLata
            // 
            this.btnExtraerLata.Location = new System.Drawing.Point(359, 102);
            this.btnExtraerLata.Name = "btnExtraerLata";
            this.btnExtraerLata.Size = new System.Drawing.Size(75, 23);
            this.btnExtraerLata.TabIndex = 2;
            this.btnExtraerLata.Text = "Extraer";
            this.btnExtraerLata.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(19, 305);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(359, 147);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(75, 23);
            this.btnBalance.TabIndex = 4;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(359, 193);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(75, 23);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lblMaqExpendedora
            // 
            this.lblMaqExpendedora.AutoSize = true;
            this.lblMaqExpendedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaqExpendedora.Location = new System.Drawing.Point(12, 9);
            this.lblMaqExpendedora.Name = "lblMaqExpendedora";
            this.lblMaqExpendedora.Size = new System.Drawing.Size(338, 37);
            this.lblMaqExpendedora.TabIndex = 6;
            this.lblMaqExpendedora.Text = "Máquina Expendedora";
            // 
            // FormMaqExpendedora
            // 
            this.ClientSize = new System.Drawing.Size(597, 340);
            this.Controls.Add(this.lblMaqExpendedora);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnExtraerLata);
            this.Controls.Add(this.btnIngresarLata);
            this.Controls.Add(this.lstLatas);
            this.Name = "FormMaqExpendedora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLatas;
        private System.Windows.Forms.Button btnIngresarLata;
        private System.Windows.Forms.Button btnExtraerLata;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lblMaqExpendedora;
    }
}