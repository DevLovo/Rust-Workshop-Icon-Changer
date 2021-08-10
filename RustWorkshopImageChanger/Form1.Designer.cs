
namespace RustWorkshopImageChanger
{
    partial class RWIC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RWIC));
            this.preview = new System.Windows.Forms.PictureBox();
            this.setImage = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.Window;
            this.preview.Image = ((System.Drawing.Image)(resources.GetObject("preview.Image")));
            this.preview.Location = new System.Drawing.Point(12, 12);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(256, 256);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            this.preview.DragDrop += new System.Windows.Forms.DragEventHandler(this.preview_DragDrop);
            this.preview.DragEnter += new System.Windows.Forms.DragEventHandler(this.preview_DragEnter);
            // 
            // setImage
            // 
            this.setImage.Location = new System.Drawing.Point(12, 274);
            this.setImage.Name = "setImage";
            this.setImage.Size = new System.Drawing.Size(256, 30);
            this.setImage.TabIndex = 1;
            this.setImage.Text = "Set Image";
            this.setImage.UseVisualStyleBackColor = true;
            this.setImage.Click += new System.EventHandler(this.setImage_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 310);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(256, 128);
            this.log.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RWIC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.setImage);
            this.Controls.Add(this.preview);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RWIC";
            this.Text = "RWIC";
            this.Load += new System.EventHandler(this.RWIC_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.RWIC_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.RWIC_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button setImage;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

