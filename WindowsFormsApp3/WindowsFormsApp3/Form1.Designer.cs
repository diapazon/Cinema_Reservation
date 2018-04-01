namespace WindowsFormsApp3
{
    partial class bas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bas));
            this.firstPicture = new System.Windows.Forms.PictureBox();
            this.forthPicture = new System.Windows.Forms.PictureBox();
            this.thirdPicture = new System.Windows.Forms.PictureBox();
            this.secondPicture = new System.Windows.Forms.PictureBox();
            this.chooseSeance = new System.Windows.Forms.ComboBox();
            this.chooseHall = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forthPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // firstPicture
            // 
            this.firstPicture.Image = ((System.Drawing.Image)(resources.GetObject("firstPicture.Image")));
            this.firstPicture.Location = new System.Drawing.Point(28, 51);
            this.firstPicture.Name = "firstPicture";
            this.firstPicture.Size = new System.Drawing.Size(153, 229);
            this.firstPicture.TabIndex = 0;
            this.firstPicture.TabStop = false;
            // 
            // forthPicture
            // 
            this.forthPicture.Image = ((System.Drawing.Image)(resources.GetObject("forthPicture.Image")));
            this.forthPicture.Location = new System.Drawing.Point(587, 51);
            this.forthPicture.Name = "forthPicture";
            this.forthPicture.Size = new System.Drawing.Size(153, 229);
            this.forthPicture.TabIndex = 1;
            this.forthPicture.TabStop = false;
            // 
            // thirdPicture
            // 
            this.thirdPicture.Image = ((System.Drawing.Image)(resources.GetObject("thirdPicture.Image")));
            this.thirdPicture.Location = new System.Drawing.Point(399, 51);
            this.thirdPicture.Name = "thirdPicture";
            this.thirdPicture.Size = new System.Drawing.Size(153, 229);
            this.thirdPicture.TabIndex = 2;
            this.thirdPicture.TabStop = false;
            // 
            // secondPicture
            // 
            this.secondPicture.Image = ((System.Drawing.Image)(resources.GetObject("secondPicture.Image")));
            this.secondPicture.Location = new System.Drawing.Point(214, 51);
            this.secondPicture.Name = "secondPicture";
            this.secondPicture.Size = new System.Drawing.Size(153, 229);
            this.secondPicture.TabIndex = 3;
            this.secondPicture.TabStop = false;
            // 
            // chooseSeance
            // 
            this.chooseSeance.FormattingEnabled = true;
            this.chooseSeance.Location = new System.Drawing.Point(28, 398);
            this.chooseSeance.Name = "chooseSeance";
            this.chooseSeance.Size = new System.Drawing.Size(115, 21);
            this.chooseSeance.TabIndex = 8;
            // 
            // chooseHall
            // 
            this.chooseHall.FormattingEnabled = true;
            this.chooseHall.Location = new System.Drawing.Point(28, 355);
            this.chooseHall.Name = "chooseHall";
            this.chooseHall.Size = new System.Drawing.Size(100, 21);
            this.chooseHall.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseHall);
            this.Controls.Add(this.chooseSeance);
            this.Controls.Add(this.secondPicture);
            this.Controls.Add(this.thirdPicture);
            this.Controls.Add(this.forthPicture);
            this.Controls.Add(this.firstPicture);
            this.Name = "bas";
            this.Text = "Posters";
            ((System.ComponentModel.ISupportInitialize)(this.firstPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forthPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox firstPicture;
        private System.Windows.Forms.PictureBox forthPicture;
        private System.Windows.Forms.PictureBox thirdPicture;
        private System.Windows.Forms.PictureBox secondPicture;
        private System.Windows.Forms.ComboBox chooseSeance;
        private System.Windows.Forms.ComboBox chooseHall;
        private System.Windows.Forms.Button button1;
    }
}

