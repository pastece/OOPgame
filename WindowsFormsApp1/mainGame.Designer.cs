
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingb
            // 
            this.settingb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingb.Location = new System.Drawing.Point(347, 180);
            this.settingb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingb.Name = "settingb";
            this.settingb.Size = new System.Drawing.Size(196, 55);
            this.settingb.TabIndex = 1;
            this.settingb.TabStop = false;
            this.settingb.Text = "Settings";
            this.settingb.UseVisualStyleBackColor = true;
            this.settingb.Click += new System.EventHandler(this.settingb_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitMain.Location = new System.Drawing.Point(347, 364);
            this.btnExitMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(196, 55);
            this.btnExitMain.TabIndex = 3;
            this.btnExitMain.TabStop = false;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // logoutb
            // 
            this.logoutb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutb.Location = new System.Drawing.Point(347, 240);
            this.logoutb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(196, 55);
            this.logoutb.TabIndex = 2;
            this.logoutb.TabStop = false;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUsers.Location = new System.Drawing.Point(347, 118);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(196, 55);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.TabStop = false;
            this.buttonUsers.Text = "User Control";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Visible = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAbout.Location = new System.Drawing.Point(347, 301);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(196, 55);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPlay.Location = new System.Drawing.Point(347, 57);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(196, 55);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // mainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(901, 562);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.logoutb);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.settingb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGame_FormClosing);
            this.Load += new System.EventHandler(this.mainGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingb;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonPlay;
    }
}