
namespace WindowsFormsApp1
{
    partial class PlayGround
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
            this.button1 = new System.Windows.Forms.Button();
            this.PbTimer = new System.Windows.Forms.Timer(this.components);
            this.bilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PbTimer
            // 
            this.PbTimer.Interval = 1000;
            this.PbTimer.Tick += new System.EventHandler(this.PbTimer_Tick);
            // 
            // bilgi
            // 
            this.bilgi.AutoSize = true;
            this.bilgi.Location = new System.Drawing.Point(541, 60);
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(35, 13);
            this.bilgi.TabIndex = 1;
            this.bilgi.Text = "label1";
            // 
            // PlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(600, 384);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayGround";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayGround_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer PbTimer;
        public System.Windows.Forms.Label bilgi;
    }
}