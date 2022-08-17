
namespace ImageLoader
{
    partial class ImageLoader
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
            this.Header = new System.Windows.Forms.Label();
            this.GetImage = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(59, 47);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(697, 24);
            this.Header.TabIndex = 0;
            this.Header.Text = "Click button to get absolutely random image from the interntet in high quality";
            // 
            // GetImage
            // 
            this.GetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GetImage.Location = new System.Drawing.Point(245, 509);
            this.GetImage.Name = "GetImage";
            this.GetImage.Size = new System.Drawing.Size(286, 42);
            this.GetImage.TabIndex = 1;
            this.GetImage.Text = "Get Image";
            this.GetImage.UseVisualStyleBackColor = true;
            this.GetImage.Click += new System.EventHandler(this.GetImage_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Save.Location = new System.Drawing.Point(245, 557);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(286, 42);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save Current Image";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(127, 74);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(516, 429);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 2;
            this.Image.TabStop = false;
            // 
            // ImageLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 621);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.GetImage);
            this.Controls.Add(this.Header);
            this.Name = "ImageLoader";
            this.Text = "Image Loader";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button GetImage;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button Save;
    }
}

