
namespace WindowsFormsApp1
{
    partial class mainGame
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
            this.settingb = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.logoutb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingb
            // 
            this.settingb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingb.Location = new System.Drawing.Point(260, 146);
            this.settingb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingb.Name = "settingb";
            this.settingb.Size = new System.Drawing.Size(147, 45);
            this.settingb.TabIndex = 0;
            this.settingb.Text = "Settings";
            this.settingb.UseVisualStyleBackColor = true;
            this.settingb.Click += new System.EventHandler(this.settingb_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitMain.Location = new System.Drawing.Point(260, 245);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(147, 45);
            this.btnExitMain.TabIndex = 7;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // logoutb
            // 
            this.logoutb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutb.Location = new System.Drawing.Point(260, 195);
            this.logoutb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(147, 45);
            this.logoutb.TabIndex = 8;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // mainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.logoutb);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.settingb);
            this.Name = "mainGame";
            this.Text = "mainGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGame_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingb;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.Button logoutb;
    }
}