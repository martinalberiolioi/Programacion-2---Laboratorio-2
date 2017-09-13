using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase06;

namespace FrmPaleta
{
    public partial class Form1 : Form
    {
        private Paleta _paleta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _paleta = 10;
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            FRMTempera frmtemp = new FRMTempera();
            frmtemp.Show();
            Tempera unaTempera = new Tempera(ConsoleColor.Black, "Maped", 10);
            Colores.Items.Clear();
            this._paleta += unaTempera;
            Colores.Items.Add((string)_paleta);
        }
        
        private void Quitar_Click(object sender, EventArgs e)
        {
            Tempera unaTempera = new Tempera(ConsoleColor.Black, "Maped", 10);
            Colores.Items.Clear();
            this._paleta -= unaTempera;
            Colores.Items.Add((string)_paleta);
        }

        private void Colores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
