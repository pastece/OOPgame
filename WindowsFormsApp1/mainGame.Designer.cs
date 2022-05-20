
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
            this.btnBack = new System.Windows.Forms.Button();
            this.HelpScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingb
            // 
            this.settingb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingb.Location = new System.Drawing.Point(260, 146);
            this.settingb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingb.Name = "settingb";
            this.settingb.Size = new System.Drawing.Size(147, 45);
            this.settingb.TabIndex = 1;
            this.settingb.TabStop = false;
            this.settingb.Text = "Settings";
            this.settingb.UseVisualStyleBackColor = true;
            this.settingb.Click += new System.EventHandler(this.settingb_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitMain.Location = new System.Drawing.Point(260, 296);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(147, 45);
            this.btnExitMain.TabIndex = 3;
            this.btnExitMain.TabStop = false;
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
            this.logoutb.TabIndex = 2;
            this.logoutb.TabStop = false;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUsers.Location = new System.Drawing.Point(260, 96);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(147, 45);
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
            this.buttonAbout.Location = new System.Drawing.Point(260, 245);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(147, 45);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPlay.Location = new System.Drawing.Point(260, 46);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(147, 45);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HelpScreenBtn
            // 
            this.HelpScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpScreenBtn.Location = new System.Drawing.Point(260, 347);
            this.HelpScreenBtn.Name = "HelpScreenBtn";
            this.HelpScreenBtn.Size = new System.Drawing.Size(147, 43);
            this.HelpScreenBtn.TabIndex = 7;
            this.HelpScreenBtn.Text = "Help Screen";
            this.HelpScreenBtn.UseVisualStyleBackColor = true;
            this.HelpScreenBtn.Click += new System.EventHandler(this.HelpScreenBtn_Click);
            // 
            // mainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.HelpScreenBtn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.logoutb);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.settingb);
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button HelpScreenBtn;
    }
}