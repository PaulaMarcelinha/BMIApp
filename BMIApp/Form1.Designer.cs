namespace BMIApp
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
            this.heightCM = new System.Windows.Forms.RadioButton();
            this.heightFT = new System.Windows.Forms.RadioButton();
            this.cmBox = new System.Windows.Forms.TextBox();
            this.feetBox = new System.Windows.Forms.TextBox();
            this.inchesBox = new System.Windows.Forms.TextBox();
            this.kgBox = new System.Windows.Forms.TextBox();
            this.stoneBox = new System.Windows.Forms.TextBox();
            this.poundBox = new System.Windows.Forms.TextBox();
            this.weightKG = new System.Windows.Forms.RadioButton();
            this.weightST = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // heightCM
            // 
            this.heightCM.AutoSize = true;
            this.heightCM.Checked = true;
            this.heightCM.Location = new System.Drawing.Point(131, 24);
            this.heightCM.Name = "heightCM";
            this.heightCM.Size = new System.Drawing.Size(80, 17);
            this.heightCM.TabIndex = 0;
            this.heightCM.TabStop = true;
            this.heightCM.Text = "Centimeters";
            this.heightCM.UseVisualStyleBackColor = true;
            this.heightCM.CheckedChanged += new System.EventHandler(this.heightCM_CheckedChanged);
            // 
            // heightFT
            // 
            this.heightFT.AutoSize = true;
            this.heightFT.Location = new System.Drawing.Point(217, 24);
            this.heightFT.Name = "heightFT";
            this.heightFT.Size = new System.Drawing.Size(90, 17);
            this.heightFT.TabIndex = 1;
            this.heightFT.Text = "Feet + Inches";
            this.heightFT.UseVisualStyleBackColor = true;
            this.heightFT.CheckedChanged += new System.EventHandler(this.heightFT_CheckedChanged_1);
            // 
            // cmBox
            // 
            this.cmBox.ForeColor = System.Drawing.Color.LightGray;
            this.cmBox.Location = new System.Drawing.Point(2, 57);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(236, 20);
            this.cmBox.TabIndex = 2;
            this.cmBox.Text = "Centimeters";
            this.cmBox.Enter += new System.EventHandler(this.cmBox_Enter);
            this.cmBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmBox_KeyPress);
            this.cmBox.Leave += new System.EventHandler(this.cmBox_Leave);
            // 
            // feetBox
            // 
            this.feetBox.AccessibleDescription = "";
            this.feetBox.ForeColor = System.Drawing.Color.LightGray;
            this.feetBox.Location = new System.Drawing.Point(2, 56);
            this.feetBox.Name = "feetBox";
            this.feetBox.Size = new System.Drawing.Size(100, 20);
            this.feetBox.TabIndex = 3;
            this.feetBox.Text = "Feet";
            this.feetBox.Visible = false;
            this.feetBox.Enter += new System.EventHandler(this.feetBox_Enter);
            this.feetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feetBox_KeyPress);
            this.feetBox.Leave += new System.EventHandler(this.feetBox_Leave);
            // 
            // inchesBox
            // 
            this.inchesBox.AccessibleDescription = "";
            this.inchesBox.ForeColor = System.Drawing.Color.LightGray;
            this.inchesBox.Location = new System.Drawing.Point(138, 56);
            this.inchesBox.Name = "inchesBox";
            this.inchesBox.Size = new System.Drawing.Size(100, 20);
            this.inchesBox.TabIndex = 4;
            this.inchesBox.Text = "Inches";
            this.inchesBox.Visible = false;
            this.inchesBox.Enter += new System.EventHandler(this.inchesBox_Enter);
            this.inchesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inchesBox_KeyPress);
            this.inchesBox.Leave += new System.EventHandler(this.inchesBox_Leave);
            // 
            // kgBox
            // 
            this.kgBox.ForeColor = System.Drawing.Color.LightGray;
            this.kgBox.Location = new System.Drawing.Point(4, 55);
            this.kgBox.Name = "kgBox";
            this.kgBox.Size = new System.Drawing.Size(236, 20);
            this.kgBox.TabIndex = 7;
            this.kgBox.Text = "Kilograms";
            this.kgBox.Enter += new System.EventHandler(this.kgBox_Enter);
            this.kgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kgBox_KeyPress);
            this.kgBox.Leave += new System.EventHandler(this.kgBox_Leave);
            // 
            // stoneBox
            // 
            this.stoneBox.AccessibleDescription = "";
            this.stoneBox.ForeColor = System.Drawing.Color.LightGray;
            this.stoneBox.Location = new System.Drawing.Point(4, 55);
            this.stoneBox.Name = "stoneBox";
            this.stoneBox.Size = new System.Drawing.Size(100, 20);
            this.stoneBox.TabIndex = 8;
            this.stoneBox.Text = "Stones";
            this.stoneBox.Visible = false;
            this.stoneBox.Enter += new System.EventHandler(this.stoneBox_Enter);
            this.stoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stoneBox_KeyPress);
            this.stoneBox.Leave += new System.EventHandler(this.stoneBox_Leave);
            // 
            // poundBox
            // 
            this.poundBox.AccessibleDescription = "";
            this.poundBox.ForeColor = System.Drawing.Color.LightGray;
            this.poundBox.Location = new System.Drawing.Point(140, 54);
            this.poundBox.Name = "poundBox";
            this.poundBox.Size = new System.Drawing.Size(100, 20);
            this.poundBox.TabIndex = 9;
            this.poundBox.Text = "Pounds";
            this.poundBox.Visible = false;
            this.poundBox.Enter += new System.EventHandler(this.poundBox_Enter);
            this.poundBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.poundBox_KeyPress);
            this.poundBox.Leave += new System.EventHandler(this.poundBox_Leave);
            // 
            // weightKG
            // 
            this.weightKG.AutoSize = true;
            this.weightKG.Checked = true;
            this.weightKG.Location = new System.Drawing.Point(133, 31);
            this.weightKG.Name = "weightKG";
            this.weightKG.Size = new System.Drawing.Size(70, 17);
            this.weightKG.TabIndex = 10;
            this.weightKG.TabStop = true;
            this.weightKG.Text = "Kilograms";
            this.weightKG.UseVisualStyleBackColor = true;
            this.weightKG.CheckedChanged += new System.EventHandler(this.weightKG_CheckedChanged);
            // 
            // weightST
            // 
            this.weightST.AutoSize = true;
            this.weightST.Location = new System.Drawing.Point(219, 31);
            this.weightST.Name = "weightST";
            this.weightST.Size = new System.Drawing.Size(104, 17);
            this.weightST.TabIndex = 11;
            this.weightST.Text = "Stone + Pounds ";
            this.weightST.UseVisualStyleBackColor = true;
            this.weightST.CheckedChanged += new System.EventHandler(this.weightST_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inchesBox);
            this.groupBox1.Controls.Add(this.heightCM);
            this.groupBox1.Controls.Add(this.heightFT);
            this.groupBox1.Controls.Add(this.feetBox);
            this.groupBox1.Controls.Add(this.cmBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Height";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weightST);
            this.groupBox2.Controls.Add(this.weightKG);
            this.groupBox2.Controls.Add(this.poundBox);
            this.groupBox2.Controls.Add(this.stoneBox);
            this.groupBox2.Controls.Add(this.kgBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weight";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(125, 237);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 13;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Result:";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(59, 287);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(187, 56);
            this.resultBox.TabIndex = 15;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(125, 355);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(346, 390);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton heightCM;
        private System.Windows.Forms.RadioButton heightFT;
        private System.Windows.Forms.TextBox cmBox;
        private System.Windows.Forms.TextBox feetBox;
        private System.Windows.Forms.TextBox inchesBox;
        private System.Windows.Forms.TextBox kgBox;
        private System.Windows.Forms.TextBox stoneBox;
        private System.Windows.Forms.TextBox poundBox;
        private System.Windows.Forms.RadioButton weightKG;
        private System.Windows.Forms.RadioButton weightST;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button resetBtn;
    }
}

