using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariosFormularios
{
    public partial class FormSegundo : Form
    {
        public FormSegundo(String v) // ve de variável
        {
            InitializeComponent();
            textBoxMultiTexto.Text = v;
        }

        private void FormSegundo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
