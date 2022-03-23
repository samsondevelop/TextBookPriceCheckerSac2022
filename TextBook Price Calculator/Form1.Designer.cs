namespace TextBook_Price_Calculator
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
            this.lblAge = new System.Windows.Forms.Label();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEndQuote = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 13);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(175, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "How many year old is the textbook?";
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(12, 29);
            this.numericAge.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericAge.Minimum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            -2147483648});
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(176, 20);
            this.numericAge.TabIndex = 1;
            this.numericAge.ValueChanged += new System.EventHandler(this.numericAge_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How much did you pay for it?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(12, 68);
            this.numericPrice.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numericPrice.Minimum = new decimal(new int[] {
            -824286653,
            1517416591,
            17522459,
            -2147483648});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(176, 20);
            this.numericPrice.TabIndex = 3;
            this.numericPrice.ValueChanged += new System.EventHandler(this.numericPrice_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 26);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEndQuote
            // 
            this.btnEndQuote.Location = new System.Drawing.Point(194, 95);
            this.btnEndQuote.Name = "btnEndQuote";
            this.btnEndQuote.Size = new System.Drawing.Size(176, 26);
            this.btnEndQuote.TabIndex = 5;
            this.btnEndQuote.Text = "End Quote";
            this.btnEndQuote.UseVisualStyleBackColor = true;
            this.btnEndQuote.Click += new System.EventHandler(this.btnEndQuote_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(194, 29);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(97, 13);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "No Total Price Yet!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 128);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btnEndQuote);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.lblAge);
            this.Name = "Form1";
            this.Text = "TextBook Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEndQuote;
        private System.Windows.Forms.Label labelOutput;
    }
}

