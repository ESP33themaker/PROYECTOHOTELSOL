namespace ProyectHotelSol
{
    partial class FormMP
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
            this.LblHotelSol = new System.Windows.Forms.Label();
            this.LblMenu = new System.Windows.Forms.Label();
            this.LblOpc1 = new System.Windows.Forms.Label();
            this.LblOpc2 = new System.Windows.Forms.Label();
            this.LblOpc3 = new System.Windows.Forms.Label();
            this.LblOpc4 = new System.Windows.Forms.Label();
            this.LblOpc5 = new System.Windows.Forms.Label();
            this.LblOpc6 = new System.Windows.Forms.Label();
            this.LblIndex = new System.Windows.Forms.Label();
            this.TbIndex = new System.Windows.Forms.TextBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHotelSol
            // 
            this.LblHotelSol.AutoSize = true;
            this.LblHotelSol.Location = new System.Drawing.Point(177, 9);
            this.LblHotelSol.Name = "LblHotelSol";
            this.LblHotelSol.Size = new System.Drawing.Size(125, 13);
            this.LblHotelSol.TabIndex = 0;
            this.LblHotelSol.Text = "Bienvenido a Hotel \"Sol\"";
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Location = new System.Drawing.Point(197, 31);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(77, 13);
            this.LblMenu.TabIndex = 1;
            this.LblMenu.Text = "Menu Principal";
            // 
            // LblOpc1
            // 
            this.LblOpc1.AutoSize = true;
            this.LblOpc1.Location = new System.Drawing.Point(133, 59);
            this.LblOpc1.Name = "LblOpc1";
            this.LblOpc1.Size = new System.Drawing.Size(141, 13);
            this.LblOpc1.TabIndex = 2;
            this.LblOpc1.Text = "1.- Consulta de habitaciones";
            // 
            // LblOpc2
            // 
            this.LblOpc2.AutoSize = true;
            this.LblOpc2.Location = new System.Drawing.Point(133, 72);
            this.LblOpc2.Name = "LblOpc2";
            this.LblOpc2.Size = new System.Drawing.Size(128, 13);
            this.LblOpc2.TabIndex = 3;
            this.LblOpc2.Text = "2.- Registro de habitacion";
            // 
            // LblOpc3
            // 
            this.LblOpc3.AutoSize = true;
            this.LblOpc3.Location = new System.Drawing.Point(133, 85);
            this.LblOpc3.Name = "LblOpc3";
            this.LblOpc3.Size = new System.Drawing.Size(121, 13);
            this.LblOpc3.TabIndex = 4;
            this.LblOpc3.Text = "3.- Salida de huespedes";
            // 
            // LblOpc4
            // 
            this.LblOpc4.AutoSize = true;
            this.LblOpc4.Location = new System.Drawing.Point(133, 98);
            this.LblOpc4.Name = "LblOpc4";
            this.LblOpc4.Size = new System.Drawing.Size(96, 13);
            this.LblOpc4.TabIndex = 5;
            this.LblOpc4.Text = "4.- Imprimir Factura";
            // 
            // LblOpc5
            // 
            this.LblOpc5.AutoSize = true;
            this.LblOpc5.Location = new System.Drawing.Point(133, 111);
            this.LblOpc5.Name = "LblOpc5";
            this.LblOpc5.Size = new System.Drawing.Size(97, 13);
            this.LblOpc5.TabIndex = 6;
            this.LblOpc5.Text = "5.- CRUD Usuarios";
            // 
            // LblOpc6
            // 
            this.LblOpc6.AutoSize = true;
            this.LblOpc6.Location = new System.Drawing.Point(133, 124);
            this.LblOpc6.Name = "LblOpc6";
            this.LblOpc6.Size = new System.Drawing.Size(42, 13);
            this.LblOpc6.TabIndex = 7;
            this.LblOpc6.Text = "6.- Salir";
            // 
            // LblIndex
            // 
            this.LblIndex.AutoSize = true;
            this.LblIndex.Location = new System.Drawing.Point(52, 152);
            this.LblIndex.Name = "LblIndex";
            this.LblIndex.Size = new System.Drawing.Size(250, 13);
            this.LblIndex.TabIndex = 8;
            this.LblIndex.Text = "Ingrese el numero de la operacion q desea realizar: ";
            this.LblIndex.Click += new System.EventHandler(this.LblIndex_Click);
            // 
            // TbIndex
            // 
            this.TbIndex.Location = new System.Drawing.Point(309, 149);
            this.TbIndex.Name = "TbIndex";
            this.TbIndex.Size = new System.Drawing.Size(135, 20);
            this.TbIndex.TabIndex = 9;
            this.TbIndex.Text = "Ingrese la opcion deseada ";
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(155, 192);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 10;
            this.BtnMenu.Text = "Seleccionar";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FormMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 280);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.TbIndex);
            this.Controls.Add(this.LblIndex);
            this.Controls.Add(this.LblOpc6);
            this.Controls.Add(this.LblOpc5);
            this.Controls.Add(this.LblOpc4);
            this.Controls.Add(this.LblOpc3);
            this.Controls.Add(this.LblOpc2);
            this.Controls.Add(this.LblOpc1);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.LblHotelSol);
            this.Name = "FormMP";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHotelSol;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Label LblOpc1;
        private System.Windows.Forms.Label LblOpc2;
        private System.Windows.Forms.Label LblOpc3;
        private System.Windows.Forms.Label LblOpc4;
        private System.Windows.Forms.Label LblOpc5;
        private System.Windows.Forms.Label LblOpc6;
        private System.Windows.Forms.Label LblIndex;
        private System.Windows.Forms.TextBox TbIndex;
        private System.Windows.Forms.Button BtnMenu;
    }
}