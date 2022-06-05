
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
            this.settingGB = new System.Windows.Forms.GroupBox();
            this.cmboxDiffuculty = new System.Windows.Forms.ComboBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.customBtn = new System.Windows.Forms.Button();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelColumn = new System.Windows.Forms.Label();
            this.shapeLbl = new System.Windows.Forms.Label();
            this.squareBox = new System.Windows.Forms.CheckBox();
            this.triangleBox = new System.Windows.Forms.CheckBox();
            this.roundBox = new System.Windows.Forms.CheckBox();
            this.shapeGB = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.settingGB.SuspendLayout();
            this.shapeGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiffLbl
            // 
            this.DiffLbl.AutoSize = true;
            this.DiffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiffLbl.Location = new System.Drawing.Point(4, 23);
            this.DiffLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiffLbl.Name = "DiffLbl";
            this.DiffLbl.Size = new System.Drawing.Size(129, 31);
            this.DiffLbl.TabIndex = 0;
            this.DiffLbl.Text = "Difficulty";
            // 
            // settingGB
            // 
            this.settingGB.BackColor = System.Drawing.SystemColors.Info;
            this.settingGB.Controls.Add(this.cmboxDiffuculty);
            this.settingGB.Controls.Add(this.confirmBtn);
            this.settingGB.Controls.Add(this.customBtn);
            this.settingGB.Controls.Add(this.textBoxColumn);
            this.settingGB.Controls.Add(this.textBoxRow);
            this.settingGB.Controls.Add(this.labelRow);
            this.settingGB.Controls.Add(this.labelColumn);
            this.settingGB.Controls.Add(this.DiffLbl);
            this.settingGB.Location = new System.Drawing.Point(32, 58);
            this.settingGB.Margin = new System.Windows.Forms.Padding(2);
            this.settingGB.Name = "settingGB";
            this.settingGB.Padding = new System.Windows.Forms.Padding(2);
            this.settingGB.Size = new System.Drawing.Size(604, 137);
            this.settingGB.TabIndex = 4;
            this.settingGB.TabStop = false;
            // 
            // cmboxDiffuculty
            // 
            this.cmboxDiffuculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDiffuculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxDiffuculty.FormattingEnabled = true;
            this.cmboxDiffuculty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmboxDiffuculty.Location = new System.Drawing.Point(164, 26);
            this.cmboxDiffuculty.Name = "cmboxDiffuculty";
            this.cmboxDiffuculty.Size = new System.Drawing.Size(184, 28);
            this.cmboxDiffuculty.TabIndex = 10;
            this.cmboxDiffuculty.SelectedIndexChanged += new System.EventHandler(this.cmboxDiffuculty_SelectedIndexChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.confirmBtn.Location = new System.Drawing.Point(535, 93);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(58, 19);
            this.confirmBtn.TabIndex = 9;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // customBtn
            // 
            this.customBtn.Location = new System.Drawing.Point(455, 24);
            this.customBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(75, 41);
            this.customBtn.TabIndex = 4;
            this.customBtn.Text = "Custom";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(455, 109);
            this.textBoxColumn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(76, 20);
            this.textBoxColumn.TabIndex = 8;
            this.textBoxColumn.Visible = false;
            this.textBoxColumn.WordWrap = false;
            // 
            // textBoxRow
            // 
            this.textBoxRow.Location = new System.Drawing.Point(455, 78);
            this.textBoxRow.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(76, 20);
            this.textBoxRow.TabIndex = 7;
            this.textBoxRow.Visible = false;
            this.textBoxRow.WordWrap = false;
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Location = new System.Drawing.Point(413, 78);
            this.labelRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(29, 13);
            this.labelRow.TabIndex = 5;
            this.labelRow.Text = "Row";
            this.labelRow.Visible = false;
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(413, 109);
            this.labelColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(42, 13);
            this.labelColumn.TabIndex = 6;
            this.labelColumn.Text = "Column";
            this.labelColumn.Visible = false;
            // 
            // shapeLbl
            // 
            this.shapeLbl.AutoSize = true;
            this.shapeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shapeLbl.Location = new System.Drawing.Point(4, 21);
            this.shapeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeLbl.Name = "shapeLbl";
            this.shapeLbl.Size = new System.Drawing.Size(97, 31);
            this.shapeLbl.TabIndex = 5;
            this.shapeLbl.Text = "Shape";
            // 
            // squareBox
            // 
            this.squareBox.AutoSize = true;
            this.squareBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.squareBox.Location = new System.Drawing.Point(147, 27);
            this.squareBox.Margin = new System.Windows.Forms.Padding(2);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(80, 24);
            this.squareBox.TabIndex = 6;
            this.squareBox.Text = "Square";
            this.squareBox.UseVisualStyleBackColor = true;
            // 
            // triangleBox
            // 
            this.triangleBox.AutoSize = true;
            this.triangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.triangleBox.Location = new System.Drawing.Point(264, 28);
            this.triangleBox.Margin = new System.Windows.Forms.Padding(2);
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(84, 24);
            this.triangleBox.TabIndex = 7;
            this.triangleBox.Text = "Triangle";
            this.triangleBox.UseVisualStyleBackColor = true;
            // 
            // roundBox
            // 
            this.roundBox.AutoSize = true;
            this.roundBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roundBox.Location = new System.Drawing.Point(393, 28);
            this.roundBox.Margin = new System.Windows.Forms.Padding(2);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(76, 24);
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
            this.shapeGB.Location = new System.Drawing.Point(41, 198);
            this.shapeGB.Margin = new System.Windows.Forms.Padding(2);
            this.shapeGB.Name = "shapeGB";
            this.shapeGB.Padding = new System.Windows.Forms.Padding(2);
            this.shapeGB.Size = new System.Drawing.Size(604, 81);
            this.shapeGB.TabIndex = 9;
            this.shapeGB.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.Location = new System.Drawing.Point(546, 435);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 41);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.Location = new System.Drawing.Point(32, 11);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 31);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRed);
            this.groupBox1.Controls.Add(this.labelColor);
            this.groupBox1.Controls.Add(this.checkBoxGreen);
            this.groupBox1.Controls.Add(this.checkBoxBlue);
            this.groupBox1.Location = new System.Drawing.Point(41, 299);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(604, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRed.Location = new System.Drawing.Point(393, 28);
            this.checkBoxRed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(58, 24);
            this.checkBoxRed.TabIndex = 8;
            this.checkBoxRed.Text = "Red";
            this.checkBoxRed.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelColor.Location = new System.Drawing.Point(4, 21);
            this.labelColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(84, 31);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Color";
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGreen.Location = new System.Drawing.Point(264, 28);
            this.checkBoxGreen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(73, 24);
            this.checkBoxGreen.TabIndex = 7;
            this.checkBoxGreen.Text = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxBlue.Location = new System.Drawing.Point(147, 27);
            this.checkBoxBlue.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(60, 24);
            this.checkBoxBlue.TabIndex = 6;
            this.checkBoxBlue.Text = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(676, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.shapeGB);
            this.Controls.Add(this.settingGB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.settingGB.ResumeLayout(false);
            this.settingGB.PerformLayout();
            this.shapeGB.ResumeLayout(false);
            this.shapeGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DiffLbl;
        private System.Windows.Forms.GroupBox settingGB;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label shapeLbl;
        private System.Windows.Forms.GroupBox shapeGB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelColor;
        public System.Windows.Forms.ComboBox cmboxDiffuculty;
        public System.Windows.Forms.TextBox textBoxColumn;
        public System.Windows.Forms.TextBox textBoxRow;
        public System.Windows.Forms.Button customBtn;
        public System.Windows.Forms.Button confirmBtn;
        public System.Windows.Forms.CheckBox squareBox;
        public System.Windows.Forms.CheckBox triangleBox;
        public System.Windows.Forms.CheckBox roundBox;
        public System.Windows.Forms.CheckBox checkBoxRed;
        public System.Windows.Forms.CheckBox checkBoxGreen;
        public System.Windows.Forms.CheckBox checkBoxBlue;
    }
}