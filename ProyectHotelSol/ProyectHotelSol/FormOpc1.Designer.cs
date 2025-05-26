namespace ProyectHotelSol
{
    partial class FormOpc1
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnHSencillo = new System.Windows.Forms.Button();
            this.BtnHDoble = new System.Windows.Forms.Button();
            this.BtnHSuite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNmOcupadas = new System.Windows.Forms.Label();
            this.LblNmLibres = new System.Windows.Forms.Label();
            this.TbNmOcupadas = new System.Windows.Forms.TextBox();
            this.TbNmLibres = new System.Windows.Forms.TextBox();
            this.LbLibre = new System.Windows.Forms.ListBox();
            this.LbOcupada = new System.Windows.Forms.ListBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(146, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(126, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Consulta de habitaciones";
            this.LblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnHSencillo
            // 
            this.BtnHSencillo.Location = new System.Drawing.Point(47, 86);
            this.BtnHSencillo.Name = "BtnHSencillo";
            this.BtnHSencillo.Size = new System.Drawing.Size(110, 23);
            this.BtnHSencillo.TabIndex = 1;
            this.BtnHSencillo.Text = "Habitación sencilla";
            this.BtnHSencillo.UseVisualStyleBackColor = true;
            this.BtnHSencillo.Click += new System.EventHandler(this.BtnHSencillo_Click);
            // 
            // BtnHDoble
            // 
            this.BtnHDoble.Location = new System.Drawing.Point(47, 115);
            this.BtnHDoble.Name = "BtnHDoble";
            this.BtnHDoble.Size = new System.Drawing.Size(110, 23);
            this.BtnHDoble.TabIndex = 2;
            this.BtnHDoble.Text = "Habitación doble";
            this.BtnHDoble.UseVisualStyleBackColor = true;
            this.BtnHDoble.Click += new System.EventHandler(this.BtnHDoble_Click);
            // 
            // BtnHSuite
            // 
            this.BtnHSuite.Location = new System.Drawing.Point(47, 144);
            this.BtnHSuite.Name = "BtnHSuite";
            this.BtnHSuite.Size = new System.Drawing.Size(110, 23);
            this.BtnHSuite.TabIndex = 3;
            this.BtnHSuite.Text = "Habitación suite";
            this.BtnHSuite.UseVisualStyleBackColor = true;
            this.BtnHSuite.Click += new System.EventHandler(this.BtnHSuite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ocupadas";
            // 
            // LblNmOcupadas
            // 
            this.LblNmOcupadas.AutoSize = true;
            this.LblNmOcupadas.Location = new System.Drawing.Point(47, 217);
            this.LblNmOcupadas.Name = "LblNmOcupadas";
            this.LblNmOcupadas.Size = new System.Drawing.Size(162, 13);
            this.LblNmOcupadas.TabIndex = 6;
            this.LblNmOcupadas.Text = "Total de habitaciones ocupadas:";
            // 
            // LblNmLibres
            // 
            this.LblNmLibres.AutoSize = true;
            this.LblNmLibres.Location = new System.Drawing.Point(47, 249);
            this.LblNmLibres.Name = "LblNmLibres";
            this.LblNmLibres.Size = new System.Drawing.Size(139, 13);
            this.LblNmLibres.TabIndex = 7;
            this.LblNmLibres.Text = "Total de habitaciones libres:";
            // 
            // TbNmOcupadas
            // 
            this.TbNmOcupadas.Location = new System.Drawing.Point(212, 214);
            this.TbNmOcupadas.Name = "TbNmOcupadas";
            this.TbNmOcupadas.Size = new System.Drawing.Size(47, 20);
            this.TbNmOcupadas.TabIndex = 8;
            // 
            // TbNmLibres
            // 
            this.TbNmLibres.Location = new System.Drawing.Point(212, 246);
            this.TbNmLibres.Name = "TbNmLibres";
            this.TbNmLibres.Size = new System.Drawing.Size(47, 20);
            this.TbNmLibres.TabIndex = 9;
            // 
            // LbLibre
            // 
            this.LbLibre.FormattingEnabled = true;
            this.LbLibre.Location = new System.Drawing.Point(207, 86);
            this.LbLibre.Name = "LbLibre";
            this.LbLibre.Size = new System.Drawing.Size(92, 95);
            this.LbLibre.TabIndex = 10;
            // 
            // LbOcupada
            // 
            this.LbOcupada.FormattingEnabled = true;
            this.LbOcupada.Location = new System.Drawing.Point(305, 86);
            this.LbOcupada.Name = "LbOcupada";
            this.LbOcupada.Size = new System.Drawing.Size(92, 95);
            this.LbOcupada.TabIndex = 11;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(296, 226);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(84, 36);
            this.BtnMenu.TabIndex = 12;
            this.BtnMenu.Text = "Regresar al Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(47, 33);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(271, 13);
            this.LblDescripcion.TabIndex = 13;
            this.LblDescripcion.Text = "Seleccione el tipo de habitaciones que desea consultar.";
            // 
            // FormOpc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 301);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.LbOcupada);
            this.Controls.Add(this.LbLibre);
            this.Controls.Add(this.TbNmLibres);
            this.Controls.Add(this.TbNmOcupadas);
            this.Controls.Add(this.LblNmLibres);
            this.Controls.Add(this.LblNmOcupadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnHSuite);
            this.Controls.Add(this.BtnHDoble);
            this.Controls.Add(this.BtnHSencillo);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FormOpc1";
            this.Text = "Consulta de habitaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnHSencillo;
        private System.Windows.Forms.Button BtnHDoble;
        private System.Windows.Forms.Button BtnHSuite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNmOcupadas;
        private System.Windows.Forms.Label LblNmLibres;
        private System.Windows.Forms.TextBox TbNmOcupadas;
        private System.Windows.Forms.TextBox TbNmLibres;
        private System.Windows.Forms.ListBox LbLibre;
        private System.Windows.Forms.ListBox LbOcupada;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblDescripcion;
    }
}