
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelBest = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBest
            // 
            this.labelBest.AutoSize = true;
            this.labelBest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBest.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelBest.Location = new System.Drawing.Point(960, 0);
            this.labelBest.Name = "labelBest";
            this.labelBest.Size = new System.Drawing.Size(79, 19);
            this.labelBest.TabIndex = 3;
            this.labelBest.Text = "Best Score";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrent.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCurrent.Location = new System.Drawing.Point(846, 0);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(114, 19);
            this.labelCurrent.TabIndex = 4;
            this.labelCurrent.Text = "Current Score: 0";
            // 
            // PlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1039, 473);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelBest);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlayGround";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayGround_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelBest;
        public System.Windows.Forms.Label labelCurrent;
    }
}