namespace _1
{
    partial class Form1
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovclock = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lnHour = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnMinute = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnSec = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lnSec,
            this.lnMinute,
            this.lnHour,
            this.ovclock});
            this.shapeContainer1.Size = new System.Drawing.Size(499, 442);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovclock
            // 
            this.ovclock.Location = new System.Drawing.Point(8, 10);
            this.ovclock.Name = "ovclock";
            this.ovclock.Size = new System.Drawing.Size(353, 339);
            this.ovclock.Click += new System.EventHandler(this.ovclock_Click);
            // 
            // lnHour
            // 
            this.lnHour.Name = "lnHour";
            this.lnHour.X1 = 186;
            this.lnHour.X2 = 182;
            this.lnHour.Y1 = 53;
            this.lnHour.Y2 = 180;
            this.lnHour.Click += new System.EventHandler(this.lnHour_Click);
            // 
            // lnMinute
            // 
            this.lnMinute.Name = "lnMinute";
            this.lnMinute.X1 = 147;
            this.lnMinute.X2 = 181;
            this.lnMinute.Y1 = 85;
            this.lnMinute.Y2 = 181;
            // 
            // lnSec
            // 
            this.lnSec.Name = "lnSec";
            this.lnSec.X1 = 166;
            this.lnSec.X2 = 179;
            this.lnSec.Y1 = 102;
            this.lnSec.Y2 = 180;
            this.lnSec.Click += new System.EventHandler(this.lnSec_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_1.Properties.Resources._1س;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 442);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnSec;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnMinute;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnHour;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovclock;
        private System.Windows.Forms.Timer timer1;
    }
}

