﻿
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
            this.preview2 = new System.Windows.Forms.PictureBox();
            this.setImage2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview2)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.Window;
            this.preview.Image = ((System.Drawing.Image)(resources.GetObject("preview.Image")));
            this.preview.Location = new System.Drawing.Point(12, 33);
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
            this.setImage.Location = new System.Drawing.Point(12, 295);
            this.setImage.Name = "setImage";
            this.setImage.Size = new System.Drawing.Size(256, 30);
            this.setImage.TabIndex = 1;
            this.setImage.Text = "Set Image";
            this.setImage.UseVisualStyleBackColor = true;
            this.setImage.Click += new System.EventHandler(this.setImage_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 355);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(527, 128);
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
            // preview2
            // 
            this.preview2.BackColor = System.Drawing.SystemColors.Window;
            this.preview2.Image = ((System.Drawing.Image)(resources.GetObject("preview2.Image")));
            this.preview2.Location = new System.Drawing.Point(283, 33);
            this.preview2.Name = "preview2";
            this.preview2.Size = new System.Drawing.Size(256, 256);
            this.preview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview2.TabIndex = 3;
            this.preview2.TabStop = false;
            this.preview2.Click += new System.EventHandler(this.pictureBox1_Click);
            this.preview2.DragDrop += new System.Windows.Forms.DragEventHandler(this.preview2_DragDrop);
            this.preview2.DragEnter += new System.Windows.Forms.DragEventHandler(this.preview2_DragEnter);
            // 
            // setImage2
            // 
            this.setImage2.Location = new System.Drawing.Point(283, 295);
            this.setImage2.Name = "setImage2";
            this.setImage2.Size = new System.Drawing.Size(256, 30);
            this.setImage2.TabIndex = 4;
            this.setImage2.Text = "Set Image";
            this.setImage2.UseVisualStyleBackColor = true;
            this.setImage2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "icon_background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(391, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "icon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "TIP: If only one image is set it will set them both to the same image";
            // 
            // RWIC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(552, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setImage2);
            this.Controls.Add(this.preview2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.setImage);
            this.Controls.Add(this.preview);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RWIC";
            this.Text = "RWIC";
            this.Load += new System.EventHandler(this.RWIC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button setImage;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox preview2;
        private System.Windows.Forms.Button setImage2;
    }
}

