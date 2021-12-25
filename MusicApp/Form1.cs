using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        private MusicSheet musicSheet = null;

        public Form1()
        {
            InitializeComponent();
            musicSheet = new MusicSheet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            musicSheet.SetText(textBox1.Text);
        }
    }
}
