namespace CAR_RENTAL_SYSTEM1
{
    partial class startpage
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
            this.Mycar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).BeginInit();
            this.Myprogress.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mycar
            // 
            this.Mycar.FillColor = System.Drawing.Color.Red;
            this.Mycar.Image = global::CAR_RENTAL_SYSTEM1.Properties.Resources.look;
            this.Mycar.ImageRotate = 0F;
            this.Mycar.Location = new System.Drawing.Point(58, 69);
            this.Mycar.Name = "Mycar";
            this.Mycar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Mycar.Size = new System.Drawing.Size(160, 123);
            this.Mycar.TabIndex = 0;
            this.Mycar.TabStop = false;
            // 
            // Myprogress
            // 
            this.Myprogress.Controls.Add(this.Percentage);
            this.Myprogress.Controls.Add(this.Mycar);
            this.Myprogress.FillColor = System.Drawing.Color.OrangeRed;
            this.Myprogress.FillThickness = 9;
            this.Myprogress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Myprogress.ForeColor = System.Drawing.Color.White;
            this.Myprogress.Location = new System.Drawing.Point(202, 83);
            this.Myprogress.Minimum = 0;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressColor = System.Drawing.Color.White;
            this.Myprogress.ProgressColor2 = System.Drawing.Color.White;
            this.Myprogress.ProgressThickness = 9;
            this.Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Myprogress.Size = new System.Drawing.Size(265, 265);
            this.Myprogress.TabIndex = 1;
            this.Myprogress.Text = "guna2CircleProgressBar1";
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Percentage.ForeColor = System.Drawing.Color.White;
            this.Percentage.Location = new System.Drawing.Point(108, 212);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(34, 31);
            this.Percentage.TabIndex = 4;
            this.Percentage.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Myprogress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startpage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.startpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).EndInit();
            this.Myprogress.ResumeLayout(false);
            this.Myprogress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Mycar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
    }
}