
namespace Laba_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.filteredImage = new System.Windows.Forms.PictureBox();
            this.windowSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowSize)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(13, 56);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(640, 400);
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFolder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFolder
            // 
            this.fileFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile});
            this.fileFolder.Name = "fileFolder";
            this.fileFolder.Size = new System.Drawing.Size(48, 20);
            this.fileFolder.Text = "Файл";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(121, 22);
            this.openFile.Text = "Открыть";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // filteredImage
            // 
            this.filteredImage.Location = new System.Drawing.Point(13, 462);
            this.filteredImage.Name = "filteredImage";
            this.filteredImage.Size = new System.Drawing.Size(640, 400);
            this.filteredImage.TabIndex = 2;
            this.filteredImage.TabStop = false;
            // 
            // windowSize
            // 
            this.windowSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.windowSize.Location = new System.Drawing.Point(533, 30);
            this.windowSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.windowSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.windowSize.Name = "windowSize";
            this.windowSize.Size = new System.Drawing.Size(120, 20);
            this.windowSize.TabIndex = 3;
            this.windowSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.windowSize.ValueChanged += new System.EventHandler(this.windowSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер окна для сглаживания:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 871);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowSize);
            this.Controls.Add(this.filteredImage);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Медианная фильтрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFolder;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.PictureBox filteredImage;
        private System.Windows.Forms.NumericUpDown windowSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

