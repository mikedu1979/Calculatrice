namespace Calculator
{
    partial class FrmMain
    {
        /// <summary>
        /// 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRig = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCe = new System.Windows.Forms.Button();
            this.BtnDivi = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnSubt = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(765, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(386, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLeft.Location = new System.Drawing.Point(765, 89);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(95, 53);
            this.BtnLeft.TabIndex = 1;
            this.BtnLeft.Text = "（";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRig
            // 
            this.BtnRig.AutoSize = true;
            this.BtnRig.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRig.Location = new System.Drawing.Point(863, 89);
            this.BtnRig.Name = "BtnRig";
            this.BtnRig.Size = new System.Drawing.Size(93, 53);
            this.BtnRig.TabIndex = 2;
            this.BtnRig.Text = "）";
            this.BtnRig.UseVisualStyleBackColor = true;
            this.BtnRig.Click += new System.EventHandler(this.BtnRig_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnC.Location = new System.Drawing.Point(962, 89);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(95, 53);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "Del";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCe
            // 
            this.BtnCe.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnCe.Location = new System.Drawing.Point(1061, 89);
            this.BtnCe.Name = "BtnCe";
            this.BtnCe.Size = new System.Drawing.Size(95, 53);
            this.BtnCe.TabIndex = 4;
            this.BtnCe.Text = "C";
            this.BtnCe.UseVisualStyleBackColor = true;
            this.BtnCe.Click += new System.EventHandler(this.BtnCe_Click);
            // 
            // BtnDivi
            // 
            this.BtnDivi.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnDivi.Location = new System.Drawing.Point(1061, 146);
            this.BtnDivi.Name = "BtnDivi";
            this.BtnDivi.Size = new System.Drawing.Size(95, 53);
            this.BtnDivi.TabIndex = 8;
            this.BtnDivi.Text = "/";
            this.BtnDivi.UseVisualStyleBackColor = true;
            this.BtnDivi.Click += new System.EventHandler(this.BtnDivi_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn9.Location = new System.Drawing.Point(962, 146);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(95, 53);
            this.Btn9.TabIndex = 7;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn8.Location = new System.Drawing.Point(863, 146);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(95, 53);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn7.Location = new System.Drawing.Point(765, 145);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(95, 53);
            this.Btn7.TabIndex = 5;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnMul.Location = new System.Drawing.Point(1061, 204);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(95, 53);
            this.BtnMul.TabIndex = 12;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn6.Location = new System.Drawing.Point(962, 204);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(95, 53);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn5.Location = new System.Drawing.Point(863, 204);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(95, 53);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn4.Location = new System.Drawing.Point(764, 204);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(95, 53);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnSubt
            // 
            this.BtnSubt.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnSubt.Location = new System.Drawing.Point(1061, 263);
            this.BtnSubt.Name = "BtnSubt";
            this.BtnSubt.Size = new System.Drawing.Size(95, 53);
            this.BtnSubt.TabIndex = 16;
            this.BtnSubt.Text = "-";
            this.BtnSubt.UseVisualStyleBackColor = true;
            this.BtnSubt.Click += new System.EventHandler(this.BtnSubt_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn3.Location = new System.Drawing.Point(962, 263);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(95, 53);
            this.Btn3.TabIndex = 15;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn2.Location = new System.Drawing.Point(863, 263);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(95, 53);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn1.Location = new System.Drawing.Point(764, 263);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(95, 53);
            this.Btn1.TabIndex = 13;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnAdd.Location = new System.Drawing.Point(1061, 322);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 53);
            this.BtnAdd.TabIndex = 20;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnEqual.Location = new System.Drawing.Point(962, 322);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(95, 53);
            this.BtnEqual.TabIndex = 19;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.BtnDot.Location = new System.Drawing.Point(863, 322);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(95, 53);
            this.BtnDot.TabIndex = 18;
            this.BtnDot.Text = ".";
            this.BtnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.Btn0.Location = new System.Drawing.Point(765, 322);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(95, 53);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(765, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(386, 36);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 388);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSubt);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnDivi);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnCe);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnRig);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRig;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCe;
        private System.Windows.Forms.Button BtnDivi;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnSubt;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.TextBox textBox2;
    }
}

