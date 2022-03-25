
namespace WindowsFormsApp1
{
    partial class Settings
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
            this.DiffLbl = new System.Windows.Forms.Label();
            this.easyBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.settingGB = new System.Windows.Forms.GroupBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.customBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeLbl = new System.Windows.Forms.Label();
            this.squareBox = new System.Windows.Forms.CheckBox();
            this.triangleBox = new System.Windows.Forms.CheckBox();
            this.roundBox = new System.Windows.Forms.CheckBox();
            this.shapeGB = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.settingGB.SuspendLayout();
            this.shapeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiffLbl
            // 
            this.DiffLbl.AutoSize = true;
            this.DiffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiffLbl.Location = new System.Drawing.Point(6, 21);
            this.DiffLbl.Name = "DiffLbl";
            this.DiffLbl.Size = new System.Drawing.Size(156, 39);
            this.DiffLbl.TabIndex = 0;
            this.DiffLbl.Text = "Difficulty";
            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(193, 21);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(100, 50);
            this.easyBtn.TabIndex = 1;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            // 
            // mediumBtn
            // 
            this.mediumBtn.Location = new System.Drawing.Point(336, 21);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(100, 50);
            this.mediumBtn.TabIndex = 2;
            this.mediumBtn.Text = "Medium";
            this.mediumBtn.UseVisualStyleBackColor = true;
            // 
            // hardBtn
            // 
            this.hardBtn.Location = new System.Drawing.Point(478, 21);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(100, 50);
            this.hardBtn.TabIndex = 3;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            // 
            // settingGB
            // 
            this.settingGB.BackColor = System.Drawing.SystemColors.Info;
            this.settingGB.Controls.Add(this.confirmBtn);
            this.settingGB.Controls.Add(this.customBtn);
            this.settingGB.Controls.Add(this.textBox2);
            this.settingGB.Controls.Add(this.hardBtn);
            this.settingGB.Controls.Add(this.textBox1);
            this.settingGB.Controls.Add(this.label1);
            this.settingGB.Controls.Add(this.label2);
            this.settingGB.Controls.Add(this.DiffLbl);
            this.settingGB.Controls.Add(this.mediumBtn);
            this.settingGB.Controls.Add(this.easyBtn);
            this.settingGB.Location = new System.Drawing.Point(42, 72);
            this.settingGB.Name = "settingGB";
            this.settingGB.Size = new System.Drawing.Size(805, 169);
            this.settingGB.TabIndex = 4;
            this.settingGB.TabStop = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.confirmBtn.Location = new System.Drawing.Point(726, 114);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(65, 23);
            this.confirmBtn.TabIndex = 9;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Visible = false;
            // 
            // customBtn
            // 
            this.customBtn.Location = new System.Drawing.Point(613, 21);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(100, 50);
            this.customBtn.TabIndex = 4;
            this.customBtn.Text = "Custom";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(620, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            this.textBox2.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(620, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value2";
            this.label2.Visible = false;
            // 
            // shapeLbl
            // 
            this.shapeLbl.AutoSize = true;
            this.shapeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shapeLbl.Location = new System.Drawing.Point(6, 26);
            this.shapeLbl.Name = "shapeLbl";
            this.shapeLbl.Size = new System.Drawing.Size(121, 39);
            this.shapeLbl.TabIndex = 5;
            this.shapeLbl.Text = "Shape";
            // 
            // squareBox
            // 
            this.squareBox.AutoSize = true;
            this.squareBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.squareBox.Location = new System.Drawing.Point(196, 33);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(113, 33);
            this.squareBox.TabIndex = 6;
            this.squareBox.Text = "Square";
            this.squareBox.UseVisualStyleBackColor = true;
            // 
            // triangleBox
            // 
            this.triangleBox.AutoSize = true;
            this.triangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.triangleBox.Location = new System.Drawing.Point(352, 34);
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(125, 33);
            this.triangleBox.TabIndex = 7;
            this.triangleBox.Text = "Triangle";
            this.triangleBox.UseVisualStyleBackColor = true;
            // 
            // roundBox
            // 
            this.roundBox.AutoSize = true;
            this.roundBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roundBox.Location = new System.Drawing.Point(524, 34);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(106, 33);
            this.roundBox.TabIndex = 8;
            this.roundBox.Text = "Round";
            this.roundBox.UseVisualStyleBackColor = true;
            // 
            // shapeGB
            // 
            this.shapeGB.Controls.Add(this.roundBox);
            this.shapeGB.Controls.Add(this.shapeLbl);
            this.shapeGB.Controls.Add(this.triangleBox);
            this.shapeGB.Controls.Add(this.squareBox);
            this.shapeGB.Location = new System.Drawing.Point(42, 294);
            this.shapeGB.Name = "shapeGB";
            this.shapeGB.Size = new System.Drawing.Size(805, 100);
            this.shapeGB.TabIndex = 9;
            this.shapeGB.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.Location = new System.Drawing.Point(727, 455);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 51);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.Location = new System.Drawing.Point(42, 15);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 38);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(901, 550);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.shapeGB);
            this.Controls.Add(this.settingGB);
            this.Name = "Settings";
            this.Text = "Settings";
            this.settingGB.ResumeLayout(false);
            this.settingGB.PerformLayout();
            this.shapeGB.ResumeLayout(false);
            this.shapeGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DiffLbl;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.GroupBox settingGB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label shapeLbl;
        private System.Windows.Forms.CheckBox squareBox;
        private System.Windows.Forms.CheckBox triangleBox;
        private System.Windows.Forms.CheckBox roundBox;
        private System.Windows.Forms.GroupBox shapeGB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
    }
}