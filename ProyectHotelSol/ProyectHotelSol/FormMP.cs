using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectHotelSol
{
    public partial class FormMP : Form
    {
        public FormMP()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                int opcion = int.Parse(TbIndex.Text.Trim());

                switch (opcion)
                {
                    case 1:
                        FormOpc1 form1 = new FormOpc1();
                        form1.Show();
                        this.Close();
                        break;

                    case 2:
                        FormOpc2 form2 = new FormOpc2();
                        form2.Show();
                        this.Close();
                        break;

                    case 3:
                        FormOpc3 form3 = new FormOpc3();
                        form3.Show();
                        this.Close();
                        break;

                    case 4:
                        FormOpc4 form4 = new FormOpc4();
                        form4.Show();
                        this.Close();
                        break;

                    case 5:
                        FormContra form5 = new FormContra();
                        form5.Show();
                        this.Close();
                        break;

                    case 6:
                        MessageBox.Show("Nos vemos hasta la próxima", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                        break;

                    default:
                        MessageBox.Show("Inserte un valor válido según las opciones del menú", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Inserte un valor válido según las opciones del menú", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LblIndex_Click(object sender, EventArgs e)
        {

        }
    }
}
