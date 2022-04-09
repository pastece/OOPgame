
namespace WindowsFormsApp1
{
    partial class checkPassword
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
            this.labelVerify = new System.Windows.Forms.Label();
            this.textBoxVerify = new System.Windows.Forms.TextBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVerify
            // 
            this.labelVerify.AutoSize = true;
            this.labelVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVerify.Location = new System.Drawing.Point(73, 22);
            this.labelVerify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(140, 17);
            this.labelVerify.TabIndex = 0;
            this.labelVerify.Text = "Verify your password";
            // 
            // textBoxVerify
            // 
            this.textBoxVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVerify.Location = new System.Drawing.Point(76, 58);
            this.textBoxVerify.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVerify.Name = "textBoxVerify";
            this.textBoxVerify.PasswordChar = '*';
            this.textBoxVerify.Size = new System.Drawing.Size(122, 23);
            this.textBoxVerify.TabIndex = 1;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVerify.Location = new System.Drawing.Point(106, 92);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(56, 27);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // checkPassword
            // 
            this.AcceptButton = this.buttonVerify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(266, 144);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.textBoxVerify);
            this.Controls.Add(this.labelVerify);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "checkPassword";
            this.Text = "checkPassword";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVerify;
        private System.Windows.Forms.TextBox textBoxVerify;
        public System.Windows.Forms.Button buttonVerify;
    }
}