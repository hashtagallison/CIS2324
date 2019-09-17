using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator2
{
    public partial class FormLatinTranslator : Form
    {
        public FormLatinTranslator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelLatinCenter.Show();
        }

        private void FormLatinTranslator_Load(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            labelLeftLatin.Show();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            labelLatinRight.Show();
        }
    }
}
