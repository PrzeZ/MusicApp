using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        IBitmapGenerator bitmapGenerator;
        IMusicSheetsSystemFacade musicSheetsSystemFacade;
        PDFConverter pdfConverter;
        Caretaker caretaker;


        public Form1()
        {
            InitializeComponent();

            bitmapGenerator = new BitmapGenerator();
            musicSheetsSystemFacade = new MusicSheetsSystemFacade(bitmapGenerator);
            pdfConverter = new PDFConverter();
            caretaker = new Caretaker(textBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicSheetsSystemFacade.InitializeMusicSheets();
            pictureBox1.Image = musicSheetsSystemFacade.Background;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = musicSheetsSystemFacade.UpdateMusicSheet(textBox1.Text);
            caretaker.Backup();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SaveCommand(pdfConverter, (Bitmap)pictureBox1.Image));
            invoker.DoCommands();
        }

        private void button1_Click(object sender, EventArgs e) //next (TODO)
        {
            musicSheetsSystemFacade.SelectNextMusicSheet();
        }

        private void button2_Click(object sender, EventArgs e) //back (TODO)
        {
            musicSheetsSystemFacade.SelectPreviousMusicSheet();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //override for shortcuts
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                Invoker invoker = new Invoker();
                invoker.SetOnStart(new SaveCommand(pdfConverter, (Bitmap)pictureBox1.Image));
                invoker.DoCommands();

                return true;
            }
            else if (keyData == (Keys.Control | Keys.Z))
            {
                caretaker.Undo();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
