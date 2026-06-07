using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELTIGRE
{
    public partial class Form1 : Form
    {
        Formularios.mainQuesillo MDTIENDA = new Formularios.mainQuesillo();

        public Form1()
        {
            InitializeComponent();
            MDTIENDA.ShowDialog();
        }
    }
}
