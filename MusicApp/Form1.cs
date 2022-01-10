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
        static IBitmapGenerator bitmapFactory = new BitmapGenerator();
        IMusicSheetsSystemFacade musicSheetsSystemFacade = new MusicSheetsSystemFacade(bitmapFactory);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = musicSheetsSystemFacade.InitializeMusicSheet();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = musicSheetsSystemFacade.UpdateMusicSheet(textBox1.Text);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            PDFConverter converter = new PDFConverter();
            await converter.ConvertToPDFAsync((Bitmap)pictureBox1.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //next page
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //previous page
        }
    }
}
