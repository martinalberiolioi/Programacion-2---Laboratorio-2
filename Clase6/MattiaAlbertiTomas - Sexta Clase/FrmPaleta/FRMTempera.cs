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
    public partial class FRMTempera : Form
    {
        private Tempera _tempera;

        public FRMTempera()
        {
            InitializeComponent();
            
        }

        public Tempera getTempera()
        {
            _tempera = new Tempera();
            return _tempera;
        }

        private void FRMTempera_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
