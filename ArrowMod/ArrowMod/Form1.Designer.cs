namespace ArrowMod
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputNumberBox = new System.Windows.Forms.TextBox();
            this.outputNumberBox = new System.Windows.Forms.TextBox();
            this.decimalToBinary = new System.Windows.Forms.RadioButton();
            this.binaryToDecimal = new System.Windows.Forms.RadioButton();
            this.binaryInputBox = new System.Windows.Forms.TextBox();
            this.moduloInputBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputBox4 = new System.Windows.Forms.TextBox();
            this.outputBox3 = new System.Windows.Forms.TextBox();
            this.outputBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // inputNumberBox
            // 
            this.inputNumberBox.Location = new System.Drawing.Point(31, 63);
            this.inputNumberBox.Name = "inputNumberBox";
            this.inputNumberBox.Size = new System.Drawing.Size(176, 20);
            this.inputNumberBox.TabIndex = 1;
            this.inputNumberBox.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            // 
            // outputNumberBox
            // 
            this.outputNumberBox.Location = new System.Drawing.Point(31, 163);
            this.outputNumberBox.Multiline = true;
            this.outputNumberBox.Name = "outputNumberBox";
            this.outputNumberBox.Size = new System.Drawing.Size(176, 55);
            this.outputNumberBox.TabIndex = 4;
            this.outputNumberBox.TextChanged += new System.EventHandler(this.outputNumber_TextChanged);
            // 
            // decimalToBinary
            // 
            this.decimalToBinary.AutoSize = true;
            this.decimalToBinary.Checked = true;
            this.decimalToBinary.Location = new System.Drawing.Point(31, 89);
            this.decimalToBinary.Name = "decimalToBinary";
            this.decimalToBinary.Size = new System.Drawing.Size(107, 17);
            this.decimalToBinary.TabIndex = 5;
            this.decimalToBinary.TabStop = true;
            this.decimalToBinary.Text = "Decimal to Binary";
            this.decimalToBinary.UseVisualStyleBackColor = true;
            this.decimalToBinary.CheckedChanged += new System.EventHandler(this.decimalToBinary_CheckedChanged);
            // 
            // binaryToDecimal
            // 
            this.binaryToDecimal.AutoSize = true;
            this.binaryToDecimal.Location = new System.Drawing.Point(31, 113);
            this.binaryToDecimal.Name = "binaryToDecimal";
            this.binaryToDecimal.Size = new System.Drawing.Size(107, 17);
            this.binaryToDecimal.TabIndex = 6;
            this.binaryToDecimal.Text = "Binary to Decimal";
            this.binaryToDecimal.UseVisualStyleBackColor = true;
            this.binaryToDecimal.CheckedChanged += new System.EventHandler(this.binaryToDecimal_CheckedChanged);
            // 
            // binaryInputBox
            // 
            this.binaryInputBox.Location = new System.Drawing.Point(330, 63);
            this.binaryInputBox.Name = "binaryInputBox";
            this.binaryInputBox.Size = new System.Drawing.Size(158, 20);
            this.binaryInputBox.TabIndex = 7;
            this.binaryInputBox.TextChanged += new System.EventHandler(this.binaryInputBox_TextChanged);
            // 
            // moduloInputBox
            // 
            this.moduloInputBox.Location = new System.Drawing.Point(494, 63);
            this.moduloInputBox.Name = "moduloInputBox";
            this.moduloInputBox.Size = new System.Drawing.Size(158, 20);
            this.moduloInputBox.TabIndex = 8;
            this.moduloInputBox.TextChanged += new System.EventHandler(this.moduloInputBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.calculateModuloButton_Click);
            // 
            // outputBox1
            // 
            this.outputBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.outputBox1.Location = new System.Drawing.Point(330, 192);
            this.outputBox1.Multiline = true;
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.Size = new System.Drawing.Size(39, 406);
            this.outputBox1.TabIndex = 10;
            this.outputBox1.TextChanged += new System.EventHandler(this.outputBox1_TextChanged);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(330, 113);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(158, 20);
            this.messageBox.TabIndex = 11;
            this.messageBox.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Decimal/Binary to convert:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Binary number (e/d):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Modular number (n):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Message in number (m/c):";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 286);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.outputBox4);
            this.groupBox2.Controls.Add(this.outputBox3);
            this.groupBox2.Controls.Add(this.outputBox2);
            this.groupBox2.Location = new System.Drawing.Point(298, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 598);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[mᵉ mod n] or  [cᵈ mod n]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(420, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Commulative factors after 1\'s (*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(192, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "m²ⁱ mod n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(89, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "2ⁱ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(44, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "i";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // outputBox4
            // 
            this.outputBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.outputBox4.Location = new System.Drawing.Point(424, 166);
            this.outputBox4.Multiline = true;
            this.outputBox4.Name = "outputBox4";
            this.outputBox4.Size = new System.Drawing.Size(246, 406);
            this.outputBox4.TabIndex = 2;
            // 
            // outputBox3
            // 
            this.outputBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.outputBox3.Location = new System.Drawing.Point(124, 166);
            this.outputBox3.Multiline = true;
            this.outputBox3.Name = "outputBox3";
            this.outputBox3.Size = new System.Drawing.Size(294, 406);
            this.outputBox3.TabIndex = 1;
            // 
            // outputBox2
            // 
            this.outputBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.outputBox2.Location = new System.Drawing.Point(77, 166);
            this.outputBox2.Multiline = true;
            this.outputBox2.Name = "outputBox2";
            this.outputBox2.Size = new System.Drawing.Size(41, 406);
            this.outputBox2.TabIndex = 0;
            this.outputBox2.TextChanged += new System.EventHandler(this.outputBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 643);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.outputBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.moduloInputBox);
            this.Controls.Add(this.binaryInputBox);
            this.Controls.Add(this.binaryToDecimal);
            this.Controls.Add(this.decimalToBinary);
            this.Controls.Add(this.outputNumberBox);
            this.Controls.Add(this.inputNumberBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "RSA Calculation-Helper";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputNumberBox;
        private System.Windows.Forms.TextBox outputNumberBox;
        private System.Windows.Forms.RadioButton decimalToBinary;
        private System.Windows.Forms.RadioButton binaryToDecimal;
        private System.Windows.Forms.TextBox binaryInputBox;
        private System.Windows.Forms.TextBox moduloInputBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox outputBox1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputBox2;
        private System.Windows.Forms.TextBox outputBox4;
        private System.Windows.Forms.TextBox outputBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

