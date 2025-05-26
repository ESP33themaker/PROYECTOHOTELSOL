namespace ProyectHotelSol
{
    partial class FormOpc3
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbNh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPago = new System.Windows.Forms.TextBox();
            this.TbLlaves = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de habitacion:";
            // 
            // TbNh
            // 
            this.TbNh.Location = new System.Drawing.Point(147, 26);
            this.TbNh.Name = "TbNh";
            this.TbNh.Size = new System.Drawing.Size(100, 20);
            this.TbNh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Realizo su pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Entrego las llaves:";
            // 
            // TbPago
            // 
            this.TbPago.Location = new System.Drawing.Point(147, 61);
            this.TbPago.Name = "TbPago";
            this.TbPago.Size = new System.Drawing.Size(100, 20);
            this.TbPago.TabIndex = 4;
            this.TbPago.Text = "Si/No";
            // 
            // TbLlaves
            // 
            this.TbLlaves.Location = new System.Drawing.Point(147, 87);
            this.TbLlaves.Name = "TbLlaves";
            this.TbLlaves.Size = new System.Drawing.Size(100, 20);
            this.TbLlaves.TabIndex = 5;
            this.TbLlaves.Text = "Si/No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar salida y generar factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(214, 138);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 37);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Regresar al menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FormOpc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 184);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbLlaves);
            this.Controls.Add(this.TbPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbNh);
            this.Controls.Add(this.label1);
            this.Name = "FormOpc3";
            this.Text = "Salida de huespedes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPago;
        private System.Windows.Forms.TextBox TbLlaves;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnMenu;
    }
}