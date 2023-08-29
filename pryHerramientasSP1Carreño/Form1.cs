using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryHerramientasSP1Carreño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            StreamWriter SwCrearArchivo = new StreamWriter("MiArchivo", false);
            if (SwCrearArchivo != null)
            {
                MessageBox.Show("Archivo creado");

            }
                

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader SrManejoArchivo = new StreamReader ("MiArchivo");
            while(SrManejoArchivo.EndOfStream==false)
            {
                txtDatos.Text += SrManejoArchivo.ReadLine() + Environment.NewLine;           
            }
            SrManejoArchivo.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("miArchivo", true);

                swCrearArchivo.WriteLine(txtDatos.Text);

                swCrearArchivo.Close();

                MessageBox.Show("Almacenado");
                txtDatos.Text = "";
                txtDatos.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Fatal" + ex.Message);

            }
        }
    }
}
