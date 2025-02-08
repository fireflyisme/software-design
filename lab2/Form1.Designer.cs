namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            button1 = new Button();
            lblResult = new Label();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            lblFibonacciResult = new Label();
            btnCalculateFibonacci = new Button();
            txtFibonacciInput = new TextBox();
            lblPowerResult = new Label();
            btnCalculatePower = new Button();
            txtBaseInput = new TextBox();
            txtExponentInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            txtInput.Location = new Point(209, 117);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            button1.Location = new Point(390, 118);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            lblResult.Location = new Point(514, 125);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 19);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            lblSumResult.Location = new Point(514, 178);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(57, 19);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Result";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnCalculateSum.Location = new Point(390, 171);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(94, 29);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "Enter";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            txtArrayInput.Location = new Point(209, 171);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(125, 27);
            txtArrayInput.TabIndex = 3;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            lblFibonacciResult.Location = new Point(514, 233);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(57, 19);
            lblFibonacciResult.TabIndex = 8;
            lblFibonacciResult.Text = "Result";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnCalculateFibonacci.Location = new Point(390, 226);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(94, 29);
            btnCalculateFibonacci.TabIndex = 7;
            btnCalculateFibonacci.Text = "Enter";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            txtFibonacciInput.Location = new Point(209, 228);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(125, 27);
            txtFibonacciInput.TabIndex = 6;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            lblPowerResult.Location = new Point(514, 323);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(57, 19);
            lblPowerResult.TabIndex = 11;
            lblPowerResult.Text = "Result";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnCalculatePower.Location = new Point(390, 314);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(94, 29);
            btnCalculatePower.TabIndex = 10;
            btnCalculatePower.Text = "Enter";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            txtBaseInput.Location = new Point(209, 277);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(125, 27);
            txtBaseInput.TabIndex = 9;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            txtExponentInput.Location = new Point(209, 339);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(125, 27);
            txtExponentInput.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 98);
            label1.Name = "label1";
            label1.Size = new Size(142, 16);
            label1.TabIndex = 13;
            label1.Text = "Recussive Factorial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(167, 152);
            label2.Name = "label2";
            label2.Size = new Size(239, 16);
            label2.TabIndex = 14;
            label2.Text = "Recussive Sum of Array Elements";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(167, 209);
            label3.Name = "label3";
            label3.Size = new Size(219, 16);
            label3.TabIndex = 15;
            label3.Text = " Recursive Fibonacci Sequence";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(178, 258);
            label5.Name = "label5";
            label5.Size = new Size(208, 16);
            label5.TabIndex = 17;
            label5.Text = " Recursive Power Calculation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 307);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 18;
            label4.Text = "BASE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 369);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 19;
            label6.Text = "EXPONENT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(292, 43);
            label7.Name = "label7";
            label7.Size = new Size(232, 32);
            label7.TabIndex = 20;
            label7.Text = "LABORATORY 2";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExponentInput);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtBaseInput);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacciInput);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button button1;
        private Label lblResult;
        private Label lblSumResult;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
        private Label lblFibonacciResult;
        private Button btnCalculateFibonacci;
        private TextBox txtFibonacciInput;
        private Label lblPowerResult;
        private Button btnCalculatePower;
        private TextBox txtBaseInput;
        private TextBox txtExponentInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}
