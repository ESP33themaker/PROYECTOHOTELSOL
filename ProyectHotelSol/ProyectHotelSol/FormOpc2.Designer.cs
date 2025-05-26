namespace ProyectHotelSol
{
    partial class FormOpc2
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
            this.LblRegistroUsuarios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRegistroC = new System.Windows.Forms.Button();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.BtnActDgv = new System.Windows.Forms.Button();
            this.TbCNombre = new System.Windows.Forms.TextBox();
            this.TbCAp = new System.Windows.Forms.TextBox();
            this.TbCRFC = new System.Windows.Forms.TextBox();
            this.TbCIde = new System.Windows.Forms.TextBox();
            this.TbCAm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbHNm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnHCheck = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblHTipo = new System.Windows.Forms.Label();
            this.LblHTarifa = new System.Windows.Forms.Label();
            this.LblRHab = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LblSub = new System.Windows.Forms.Label();
            this.LblTot = new System.Windows.Forms.Label();
            this.Lbliva = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TbRCliente = new System.Windows.Forms.TextBox();
            this.TbRAdultos = new System.Windows.Forms.TextBox();
            this.TbRNinos = new System.Windows.Forms.TextBox();
            this.TbRUsuario = new System.Windows.Forms.TextBox();
            this.BtnCrearReservacion = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegistroUsuarios
            // 
            this.LblRegistroUsuarios.AutoSize = true;
            this.LblRegistroUsuarios.Location = new System.Drawing.Point(72, 9);
            this.LblRegistroUsuarios.Name = "LblRegistroUsuarios";
            this.LblRegistroUsuarios.Size = new System.Drawing.Size(101, 13);
            this.LblRegistroUsuarios.TabIndex = 0;
            this.LblRegistroUsuarios.Text = "Registro de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Documento de Identificacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RFC:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnRegistroC
            // 
            this.BtnRegistroC.Location = new System.Drawing.Point(16, 138);
            this.BtnRegistroC.Name = "BtnRegistroC";
            this.BtnRegistroC.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistroC.TabIndex = 6;
            this.BtnRegistroC.Text = "Registrar";
            this.BtnRegistroC.UseVisualStyleBackColor = true;
            this.BtnRegistroC.Click += new System.EventHandler(this.BtnRegistroC_Click);
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(304, 12);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(266, 82);
            this.DgvClientes.TabIndex = 7;
            // 
            // BtnActDgv
            // 
            this.BtnActDgv.Location = new System.Drawing.Point(510, 110);
            this.BtnActDgv.Name = "BtnActDgv";
            this.BtnActDgv.Size = new System.Drawing.Size(75, 23);
            this.BtnActDgv.TabIndex = 8;
            this.BtnActDgv.Text = "Actualizar";
            this.BtnActDgv.UseVisualStyleBackColor = true;
            this.BtnActDgv.Click += new System.EventHandler(this.BtnActDgv_Click);
            // 
            // TbCNombre
            // 
            this.TbCNombre.Location = new System.Drawing.Point(173, 27);
            this.TbCNombre.Name = "TbCNombre";
            this.TbCNombre.Size = new System.Drawing.Size(100, 20);
            this.TbCNombre.TabIndex = 9;
            // 
            // TbCAp
            // 
            this.TbCAp.Location = new System.Drawing.Point(173, 47);
            this.TbCAp.Name = "TbCAp";
            this.TbCAp.Size = new System.Drawing.Size(100, 20);
            this.TbCAp.TabIndex = 10;
            // 
            // TbCRFC
            // 
            this.TbCRFC.Location = new System.Drawing.Point(173, 108);
            this.TbCRFC.Name = "TbCRFC";
            this.TbCRFC.Size = new System.Drawing.Size(100, 20);
            this.TbCRFC.TabIndex = 11;
            // 
            // TbCIde
            // 
            this.TbCIde.Location = new System.Drawing.Point(173, 86);
            this.TbCIde.Name = "TbCIde";
            this.TbCIde.Size = new System.Drawing.Size(100, 20);
            this.TbCIde.TabIndex = 12;
            // 
            // TbCAm
            // 
            this.TbCAm.Location = new System.Drawing.Point(173, 67);
            this.TbCAm.Name = "TbCAm";
            this.TbCAm.Size = new System.Drawing.Size(100, 20);
            this.TbCAm.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccion de habitacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numero de habitacion:";
            // 
            // TbHNm
            // 
            this.TbHNm.Location = new System.Drawing.Point(155, 190);
            this.TbHNm.Name = "TbHNm";
            this.TbHNm.Size = new System.Drawing.Size(100, 20);
            this.TbHNm.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tarifa: ";
            // 
            // BtnHCheck
            // 
            this.BtnHCheck.Location = new System.Drawing.Point(304, 185);
            this.BtnHCheck.Name = "BtnHCheck";
            this.BtnHCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnHCheck.TabIndex = 19;
            this.BtnHCheck.Text = "Seleccionar";
            this.BtnHCheck.UseVisualStyleBackColor = true;
            this.BtnHCheck.Click += new System.EventHandler(this.BtnHCheck_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Habitacion a reservar: ";
            // 
            // LblHTipo
            // 
            this.LblHTipo.AutoSize = true;
            this.LblHTipo.Location = new System.Drawing.Point(173, 216);
            this.LblHTipo.Name = "LblHTipo";
            this.LblHTipo.Size = new System.Drawing.Size(0, 13);
            this.LblHTipo.TabIndex = 23;
            // 
            // LblHTarifa
            // 
            this.LblHTarifa.AutoSize = true;
            this.LblHTarifa.Location = new System.Drawing.Point(173, 239);
            this.LblHTarifa.Name = "LblHTarifa";
            this.LblHTarifa.Size = new System.Drawing.Size(0, 13);
            this.LblHTarifa.TabIndex = 24;
            // 
            // LblRHab
            // 
            this.LblRHab.AutoSize = true;
            this.LblRHab.Location = new System.Drawing.Point(152, 283);
            this.LblRHab.Name = "LblRHab";
            this.LblRHab.Size = new System.Drawing.Size(0, 13);
            this.LblRHab.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Registro de reservacion";
            // 
            // DtpIngreso
            // 
            this.DtpIngreso.Location = new System.Drawing.Point(141, 372);
            this.DtpIngreso.Name = "DtpIngreso";
            this.DtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.DtpIngreso.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Adultos a hospedar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Niños a hospedar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Id del cliente:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Fecha de ingreso:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 395);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Fecha de salida: ";
            // 
            // DtpSalida
            // 
            this.DtpSalida.Location = new System.Drawing.Point(141, 398);
            this.DtpSalida.Name = "DtpSalida";
            this.DtpSalida.Size = new System.Drawing.Size(200, 20);
            this.DtpSalida.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Subtotal:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(337, 327);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Total:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(337, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "IVA:";
            // 
            // LblSub
            // 
            this.LblSub.AutoSize = true;
            this.LblSub.Location = new System.Drawing.Point(407, 283);
            this.LblSub.Name = "LblSub";
            this.LblSub.Size = new System.Drawing.Size(0, 13);
            this.LblSub.TabIndex = 37;
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Location = new System.Drawing.Point(407, 327);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(0, 13);
            this.LblTot.TabIndex = 38;
            // 
            // Lbliva
            // 
            this.Lbliva.AutoSize = true;
            this.Lbliva.Location = new System.Drawing.Point(407, 305);
            this.Lbliva.Name = "Lbliva";
            this.Lbliva.Size = new System.Drawing.Size(0, 13);
            this.Lbliva.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 430);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Id de usuario:";
            // 
            // TbRCliente
            // 
            this.TbRCliente.Location = new System.Drawing.Point(155, 305);
            this.TbRCliente.Name = "TbRCliente";
            this.TbRCliente.Size = new System.Drawing.Size(100, 20);
            this.TbRCliente.TabIndex = 41;
            // 
            // TbRAdultos
            // 
            this.TbRAdultos.Location = new System.Drawing.Point(155, 324);
            this.TbRAdultos.Name = "TbRAdultos";
            this.TbRAdultos.Size = new System.Drawing.Size(100, 20);
            this.TbRAdultos.TabIndex = 42;
            // 
            // TbRNinos
            // 
            this.TbRNinos.Location = new System.Drawing.Point(155, 342);
            this.TbRNinos.Name = "TbRNinos";
            this.TbRNinos.Size = new System.Drawing.Size(100, 20);
            this.TbRNinos.TabIndex = 43;
            // 
            // TbRUsuario
            // 
            this.TbRUsuario.Location = new System.Drawing.Point(155, 427);
            this.TbRUsuario.Name = "TbRUsuario";
            this.TbRUsuario.Size = new System.Drawing.Size(100, 20);
            this.TbRUsuario.TabIndex = 44;
            // 
            // BtnCrearReservacion
            // 
            this.BtnCrearReservacion.Location = new System.Drawing.Point(368, 362);
            this.BtnCrearReservacion.Name = "BtnCrearReservacion";
            this.BtnCrearReservacion.Size = new System.Drawing.Size(108, 23);
            this.BtnCrearReservacion.TabIndex = 45;
            this.BtnCrearReservacion.Text = "Crear reservacion";
            this.BtnCrearReservacion.UseVisualStyleBackColor = true;
            this.BtnCrearReservacion.Click += new System.EventHandler(this.BtnCrearReservacion_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(385, 427);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(142, 23);
            this.BtnMenu.TabIndex = 46;
            this.BtnMenu.Text = "Regresar al Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FormOpc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 452);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnCrearReservacion);
            this.Controls.Add(this.TbRUsuario);
            this.Controls.Add(this.TbRNinos);
            this.Controls.Add(this.TbRAdultos);
            this.Controls.Add(this.TbRCliente);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Lbliva);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.LblSub);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DtpSalida);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtpIngreso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblRHab);
            this.Controls.Add(this.LblHTarifa);
            this.Controls.Add(this.LblHTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnHCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbHNm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCAm);
            this.Controls.Add(this.TbCIde);
            this.Controls.Add(this.TbCRFC);
            this.Controls.Add(this.TbCAp);
            this.Controls.Add(this.TbCNombre);
            this.Controls.Add(this.BtnActDgv);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.BtnRegistroC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRegistroUsuarios);
            this.Name = "FormOpc2";
            this.Text = "Registro de habitacion";
            this.Load += new System.EventHandler(this.FormOpc2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistroUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRegistroC;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button BtnActDgv;
        private System.Windows.Forms.TextBox TbCNombre;
        private System.Windows.Forms.TextBox TbCAp;
        private System.Windows.Forms.TextBox TbCRFC;
        private System.Windows.Forms.TextBox TbCIde;
        private System.Windows.Forms.TextBox TbCAm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbHNm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnHCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblHTipo;
        private System.Windows.Forms.Label LblHTarifa;
        private System.Windows.Forms.Label LblRHab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpIngreso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker DtpSalida;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LblSub;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label Lbliva;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TbRCliente;
        private System.Windows.Forms.TextBox TbRAdultos;
        private System.Windows.Forms.TextBox TbRNinos;
        private System.Windows.Forms.TextBox TbRUsuario;
        private System.Windows.Forms.Button BtnCrearReservacion;
        private System.Windows.Forms.Button BtnMenu;
    }
}