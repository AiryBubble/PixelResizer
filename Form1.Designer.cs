using System.Windows.Forms;
using System.Drawing;

namespace PixelResizer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonLoad;
        private Button buttonSave;
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            this.SuspendLayout();

            this.buttonLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(152, 29);
            this.buttonLoad.Text = "画像を読み込む";

            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(339, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 29);
            this.buttonSave.Text = "画像を保存する";

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Text = "倍率:";

            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(11, 47);
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);

            this.numericUpDown1.Location = new System.Drawing.Point(222, 11);
            this.numericUpDown1.Size = new System.Drawing.Size(111, 30);
            this.numericUpDown1.Value = 1;

            this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 23f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 569);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Font = new System.Drawing.Font("メイリオ", 9f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = true;
            this.Text = "PixelResizer";

            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
