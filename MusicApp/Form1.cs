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
            musicSheetsSystemFacade.InitializeMusicSheets();
            pictureBox1.Image = musicSheetsSystemFacade.Background;
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

        private void button1_Click(object sender, EventArgs e) //next
        {
            musicSheetsSystemFacade.SelectNextMusicSheet();
        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            musicSheetsSystemFacade.SelectPreviousMusicSheet();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //override for shortcut saving
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                MessageBox.Show("Saved");
                //TODO Save logic
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
