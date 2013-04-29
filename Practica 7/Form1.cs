using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int punto = 0;
                if(this.D.Checked) {
                    punto++;
                }
                    

                if (this.numericUpDown1.Text=="25"){
                     punto++;
                }

                if (this.checkBallena.Checked)
                {
                    punto++;
                }

                if (this.checkDelfin.Checked)
                {

                    punto++;
                }
               DateTime Fecha = this.calendario.SelectionStart;
               String fechaseleccionada = Fecha.ToShortDateString();
               if (fechaseleccionada == "12/08/1542")
               {
                   punto++;
               }
           
            if (punto == 4)
            {
                MessageBox.Show("Bien Hecho , Tienes : " + punto + " de 5");//Imprimir en pantalla
            }
            else
            {
                MessageBox.Show("Tienes : " + punto + " de 5 Sigue intentando...");//Imprimir en pantalla
            }




        }

        
    }
}
