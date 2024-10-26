using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPrecioMotorHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int acumulador = 0;
        int total = 0;
        int personas = 0;
        int extras = 0;


        private void btnCalcular_Click(object sender, EventArgs e)
        {           
            if (cmbModelo.Text != "")
            {                
                switch (cmbModelo.SelectedIndex)
                {
                    case 0:
                        acumulador = 1000;
                        total += acumulador;
                        break;
                    case 1:
                        acumulador = 1500;
                        total += acumulador;
                        break;
                    default:
                        acumulador = 2000;
                        total += acumulador;
                        break;
                }

                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error, debe seleccionar un modelo para continuar";
            }

            if (rdbSi.Checked)
            {             
                 txtResultado.Text = (total + 500).ToString();
                total = Convert.ToInt32(txtResultado.Text);
            }

            personas = Convert.ToInt32(cmbPersonas.Text);
            txtResultado.Text = ((personas * 100) + total + extras).ToString();
            total = 0;
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int limite = 0;
            switch (cmbModelo.SelectedItem)
            {
                case "Modelo A":
                    cmbPersonas.Items.Clear();
                    cmbPersonas.Text = string.Empty;
                    limite = 4;
                    break;
                case "Modelo B":
                    cmbPersonas.Items.Clear();
                    cmbPersonas.Text = string.Empty;
                    limite = 6;
                    break;
                default:
                    cmbPersonas.Items.Clear();
                    cmbPersonas.Text = string.Empty;
                    limite = 9;
                    break;
            }
            for (int i = 1; i < limite; i++)
            {
                cmbPersonas.Items.Add(i);
            }            
        }
        public void Extras(bool valor)
        {
            if (valor)
            {
                extras += 50;
            } else
            {
                extras -= 50;
            }
        }
        private void chbEquipo_CheckedChanged(object sender, EventArgs e)
        {
            Extras(chbEquipo.Checked);
        }
        private void chbInternet_CheckedChanged(object sender, EventArgs e)
        {
            Extras(chbInternet.Checked);
        }
        private void chbTelevision_CheckedChanged(object sender, EventArgs e)
        {
            Extras(chbTelevision.Checked);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbSi.Checked = false;
            rdbNo.Checked = false;
            chbEquipo.Checked = false;
            chbInternet.Checked = false;
            chbTelevision.Checked = false;
            txtResultado.Text = "";
            cmbModelo.Text = "";
            cmbPersonas.Text = "";
            lblError.Text = "";
        }
    }
}
