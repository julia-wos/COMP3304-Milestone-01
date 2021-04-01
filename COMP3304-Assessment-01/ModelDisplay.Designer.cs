
namespace COMP3304_Assessment_01
{
    partial class ModelDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.NextImage = new System.Windows.Forms.Button();
            this.PreviousImage = new System.Windows.Forms.Button();
            this.LoadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBox
            // 
            this.ImgBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ImgBox.Location = new System.Drawing.Point(12, 76);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(556, 513);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgBox.TabIndex = 0;
            this.ImgBox.TabStop = false;
            // 
            // NextImage
            // 
            this.NextImage.BackColor = System.Drawing.Color.Yellow;
            this.NextImage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.NextImage.FlatAppearance.BorderSize = 0;
            this.NextImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.NextImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.NextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextImage.Location = new System.Drawing.Point(405, 26);
            this.NextImage.Margin = new System.Windows.Forms.Padding(0);
            this.NextImage.Name = "NextImage";
            this.NextImage.Size = new System.Drawing.Size(163, 44);
            this.NextImage.TabIndex = 1;
            this.NextImage.Text = "Next";
            this.NextImage.UseVisualStyleBackColor = false;
            this.NextImage.Click += new System.EventHandler(this.NextImg);
            // 
            // PreviousImage
            // 
            this.PreviousImage.BackColor = System.Drawing.Color.Yellow;
            this.PreviousImage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PreviousImage.FlatAppearance.BorderSize = 0;
            this.PreviousImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.PreviousImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.PreviousImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousImage.Location = new System.Drawing.Point(12, 26);
            this.PreviousImage.Name = "PreviousImage";
            this.PreviousImage.Size = new System.Drawing.Size(163, 44);
            this.PreviousImage.TabIndex = 2;
            this.PreviousImage.Text = "Previous";
            this.PreviousImage.UseVisualStyleBackColor = false;
            this.PreviousImage.Click += new System.EventHandler(this.PreviousImg);
            // 
            // LoadImage
            // 
            this.LoadImage.BackColor = System.Drawing.Color.Yellow;
            this.LoadImage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.LoadImage.FlatAppearance.BorderSize = 0;
            this.LoadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.LoadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.LoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImage.Location = new System.Drawing.Point(181, 26);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(218, 44);
            this.LoadImage.TabIndex = 3;
            this.LoadImage.Text = "Load New Image";
            this.LoadImage.UseVisualStyleBackColor = false;
            this.LoadImage.Click += new System.EventHandler(this.LoadImg);
            // 
            // ModelDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(580, 601);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.PreviousImage);
            this.Controls.Add(this.NextImage);
            this.Controls.Add(this.ImgBox);
            this.Name = "ModelDisplay";
            this.Text = "ModelDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Button NextImage;
        private System.Windows.Forms.Button PreviousImage;
        private System.Windows.Forms.Button LoadImage;
    }
}