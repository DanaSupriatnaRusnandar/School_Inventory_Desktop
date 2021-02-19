namespace School_Inventory
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.progresBar = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progresBar
            // 
            this.progresBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progresBar.AnimationFunction")));
            this.progresBar.AnimationSpeed = 500;
            this.progresBar.BackColor = System.Drawing.Color.White;
            this.progresBar.Font = new System.Drawing.Font("Permanent Marker", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.progresBar.InnerColor = System.Drawing.Color.White;
            this.progresBar.InnerMargin = 2;
            this.progresBar.InnerWidth = -1;
            this.progresBar.Location = new System.Drawing.Point(52, 134);
            this.progresBar.MarqueeAnimationSpeed = 2000;
            this.progresBar.Name = "progresBar";
            this.progresBar.OuterColor = System.Drawing.Color.DarkGray;
            this.progresBar.OuterMargin = -25;
            this.progresBar.OuterWidth = 26;
            this.progresBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.progresBar.ProgressWidth = 6;
            this.progresBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progresBar.Size = new System.Drawing.Size(150, 150);
            this.progresBar.StartAngle = 270;
            this.progresBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progresBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progresBar.SubscriptText = "";
            this.progresBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progresBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progresBar.SuperscriptText = "";
            this.progresBar.TabIndex = 0;
            this.progresBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progresBar.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventaris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Permanent Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(75, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loading...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Permanent Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(52, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright © kelompok 3 ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progresBar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progresBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}