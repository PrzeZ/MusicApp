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
            pictureBox1.Image = BitmapFactory.CreateBitmap(musicSheet.Notes);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var notes = musicSheet.ConvertTextToNote(textBox1.Text);
            musicSheet.Notes = notes;
            pictureBox1.Image = BitmapFactory.CreateBitmap(musicSheet.Notes);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            PDFConverter converter = new PDFConverter();
            await converter.ConvertToPDF((Bitmap)pictureBox1.Image);
        }
    }
}
