using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class latinTranslatorForm : Form
    {
        public latinTranslatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leftLatin.Show();

        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            centerLatin.Show();

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            rightLatin.Show();

        }

        private void latinTranslatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
