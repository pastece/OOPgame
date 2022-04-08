
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
            this.labelVerify.Location = new System.Drawing.Point(97, 27);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(166, 20);
            this.labelVerify.TabIndex = 0;
            this.labelVerify.Text = "Verify your password";
            // 
            // textBoxVerify
            // 
            this.textBoxVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVerify.Location = new System.Drawing.Point(101, 71);
            this.textBoxVerify.Name = "textBoxVerify";
            this.textBoxVerify.PasswordChar = '*';
            this.textBoxVerify.Size = new System.Drawing.Size(162, 27);
            this.textBoxVerify.TabIndex = 1;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVerify.Location = new System.Drawing.Point(141, 113);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(75, 33);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // checkPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(354, 177);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.textBoxVerify);
            this.Controls.Add(this.labelVerify);
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