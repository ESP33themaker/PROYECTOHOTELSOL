namespace ProyectHotelSol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.TbContraseña = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.LbContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbUsuario
            // 
            this.TbUsuario.Location = new System.Drawing.Point(85, 15);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(125, 20);
            this.TbUsuario.TabIndex = 0;
            this.TbUsuario.Text = "Ingrese su usuario...\r\n";
            // 
            // TbContraseña
            // 
            this.TbContraseña.Location = new System.Drawing.Point(85, 48);
            this.TbContraseña.Name = "TbContraseña";
            this.TbContraseña.Size = new System.Drawing.Size(125, 20);
            this.TbContraseña.TabIndex = 1;
            this.TbContraseña.Text = "Ingrese su contraseña...";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(55, 87);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Location = new System.Drawing.Point(12, 18);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(49, 13);
            this.LbUsuario.TabIndex = 3;
            this.LbUsuario.Text = "Usuario: ";
            this.LbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbContraseña
            // 
            this.LbContraseña.AutoSize = true;
            this.LbContraseña.Location = new System.Drawing.Point(12, 51);
            this.LbContraseña.Name = "LbContraseña";
            this.LbContraseña.Size = new System.Drawing.Size(67, 13);
            this.LbContraseña.TabIndex = 4;
            this.LbContraseña.Text = "Contraseña: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 115);
            this.Controls.Add(this.LbContraseña);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TbContraseña);
            this.Controls.Add(this.TbUsuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.TextBox TbContraseña;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Label LbContraseña;
    }
}

