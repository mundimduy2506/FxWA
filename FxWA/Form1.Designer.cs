namespace FxWA
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarketExecutionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEntryPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTakeProfit = new System.Windows.Forms.Label();
            this.lbStopLoss = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbEntryPrice1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTPPips = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSLPips = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Execution:";
            // 
            // cbMarketExecutionType
            // 
            this.cbMarketExecutionType.FormattingEnabled = true;
            this.cbMarketExecutionType.Location = new System.Drawing.Point(112, 65);
            this.cbMarketExecutionType.Name = "cbMarketExecutionType";
            this.cbMarketExecutionType.Size = new System.Drawing.Size(121, 21);
            this.cbMarketExecutionType.TabIndex = 1;
            this.cbMarketExecutionType.Text = "Select....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pair:";
            // 
            // tbEntryPrice
            // 
            this.tbEntryPrice.Location = new System.Drawing.Point(112, 98);
            this.tbEntryPrice.Name = "tbEntryPrice";
            this.tbEntryPrice.Size = new System.Drawing.Size(227, 20);
            this.tbEntryPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTakeProfit
            // 
            this.lbTakeProfit.AutoSize = true;
            this.lbTakeProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeProfit.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbTakeProfit.Location = new System.Drawing.Point(109, 164);
            this.lbTakeProfit.Name = "lbTakeProfit";
            this.lbTakeProfit.Size = new System.Drawing.Size(41, 13);
            this.lbTakeProfit.TabIndex = 7;
            this.lbTakeProfit.Text = "label5";
            // 
            // lbStopLoss
            // 
            this.lbStopLoss.AutoSize = true;
            this.lbStopLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStopLoss.ForeColor = System.Drawing.Color.Red;
            this.lbStopLoss.Location = new System.Drawing.Point(108, 198);
            this.lbStopLoss.Name = "lbStopLoss";
            this.lbStopLoss.Size = new System.Drawing.Size(41, 13);
            this.lbStopLoss.TabIndex = 8;
            this.lbStopLoss.Text = "label6";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(365, 101);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Chiching";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbEntryPrice1
            // 
            this.tbEntryPrice1.Location = new System.Drawing.Point(112, 131);
            this.tbEntryPrice1.Name = "tbEntryPrice1";
            this.tbEntryPrice1.Size = new System.Drawing.Size(227, 20);
            this.tbEntryPrice1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Entry:";
            // 
            // tbTPPips
            // 
            this.tbTPPips.Location = new System.Drawing.Point(66, 3);
            this.tbTPPips.Name = "tbTPPips";
            this.tbTPPips.Size = new System.Drawing.Size(53, 20);
            this.tbTPPips.TabIndex = 13;
            this.tbTPPips.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TP pips";
            // 
            // tbSLPips
            // 
            this.tbSLPips.Location = new System.Drawing.Point(66, 29);
            this.tbSLPips.Name = "tbSLPips";
            this.tbSLPips.Size = new System.Drawing.Size(53, 20);
            this.tbSLPips.TabIndex = 15;
            this.tbSLPips.Text = "15";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SL pips";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 234);
            this.Controls.Add(this.tbSLPips);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTPPips);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEntryPrice1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbStopLoss);
            this.Controls.Add(this.lbTakeProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEntryPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMarketExecutionType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FxWA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarketExecutionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEntryPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTakeProfit;
        private System.Windows.Forms.Label lbStopLoss;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbEntryPrice1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTPPips;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSLPips;
        private System.Windows.Forms.Label label7;
    }
}

