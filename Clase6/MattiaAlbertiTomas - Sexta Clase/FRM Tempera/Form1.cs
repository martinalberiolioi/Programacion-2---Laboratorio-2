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

namespace FRM_Tempera
{
    public partial class Form1 : Form
    {
        private Tempera _tempera;

        public Form1()
        {
            _tempera = new Tempera();
            InitializeComponent();
        }


        public Tempera GetTempera()
        {


            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tempera = 10;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
