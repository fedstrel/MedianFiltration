using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1
{
    public partial class MainForm : Form
    {
        MedianFiltration mf = new MedianFiltration();
        Bitmap originalBmp;
        Bitmap filteredBmp;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            originalBmp = BitmapUtils.Resize(new Bitmap(openFileDialog1.FileName), originalImage.Width, originalImage.Height);
            filteredBmp = new Bitmap(originalBmp);
            originalImage.Image = originalBmp;
            filteredImage.Image = mf.filter(filteredBmp, (byte)windowSize.Value);
        }

        private void windowSize_ValueChanged(object sender, EventArgs e)
        {
            if (originalBmp == null)
                MessageBox.Show("Нет изображения для фильтрации.");
            filteredImage.Image = mf.filter(new Bitmap(originalBmp), (byte)windowSize.Value);
        }
    }
}
