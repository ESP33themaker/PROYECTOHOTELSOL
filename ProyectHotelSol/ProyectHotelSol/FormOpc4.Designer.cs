namespace ProyectHotelSol
{
    partial class FormOpc4
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
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.TbFactura = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(12, 12);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.Size = new System.Drawing.Size(240, 150);
            this.DgvFacturas.TabIndex = 0;
            // 
            // TbFactura
            // 
            this.TbFactura.Location = new System.Drawing.Point(270, 28);
            this.TbFactura.Name = "TbFactura";
            this.TbFactura.Size = new System.Drawing.Size(100, 20);
            this.TbFactura.TabIndex = 1;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(12, 169);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(129, 23);
            this.BtnMostrar.TabIndex = 2;
            this.BtnMostrar.Text = "Mostrar Facturas";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(270, 54);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 3;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(342, 169);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(109, 23);
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.Text = "Regresar al menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el Id de la factura a imprimir";
            // 
            // FormOpc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TbFactura);
            this.Controls.Add(this.DgvFacturas);
            this.Name = "FormOpc4";
            this.Text = "Impresion de factura";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.TextBox TbFactura;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label label1;
    }
}