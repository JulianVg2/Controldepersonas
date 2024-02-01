using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controldepersonas
{
    public partial class Form1 : Form
    {
        //Se declara arriba para que se pueda usar en otras instancias
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //Lo que declare aqui es la 1era persona, pero pueden ser mas
            //  Persona persona = new Persona();
            //Persona 2
            //Persona a = new Persona();
            persona.Dpi = Jtxt1.Text;
            persona.Nombre = Jtxt2.Text;
            persona.Apellido = Jtxt3.Text;
            persona.FechaNacimiento1 = dateTimePicker1.Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          



















        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido; ;
            labelFechaNacimiento.Text = persona.FechaNacimiento1.ToShortDateString();
            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelFechaNacimiento.Visible = true;
            labelEdad.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelEdad.Visible = true;
            persona.PrimerMayuscula();
            int edad = persona.calcularedad();
            labelEdad.Text = edad.ToString();
            persona.calcularedad();
            persona.normalizaNombre();

            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;

        }
    }
}
