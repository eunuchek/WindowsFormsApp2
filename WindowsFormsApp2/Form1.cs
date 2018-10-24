using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            
            Clipboard.SetText(textBox1.Text);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
        }
    }
}
