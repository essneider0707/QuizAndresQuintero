using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAndresQuintero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = " cotizacion de auto para " + txtNombre.Text+"\r\n";

            // obtener costo inicial
            costo = Convert.ToDouble(txtCosto.Text);

            // Verificar seguros
            if (rbnBasico.Checked == true)
            {
                costo = costo + 50000;
                cotizacion += "Lleva seguro basico de  500000 \r\n ";
                   
            }
            if (rbnTerceros.Checked == true)
            {
                costo = costo + 100000;
                cotizacion += "Lleva seguro de terceros de  100000 \r\n ";

            }

            if(rbnTotal.Checked == true)
            {
                costo = costo + 150000;
                cotizacion += "Lleva seguro basico de  150000 \r\n ";
            }


            // verificar equipo 
            if (chkAire.Checked== true)
            {
                costo += 25000;
                cotizacion = "Con aire acondicionado de 25000 \r\n";
            }

            if (chkAudio.Checked == true)
            {
                costo += 75000;
                cotizacion = "Con aire de 75000 \r\n";
            }
            // Mostramos total
            cotizacion += "El total a pagar es de " + costo.ToString();

            txtCotizacion.Text = cotizacion;


        }
    }
}
