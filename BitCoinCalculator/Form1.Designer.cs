
namespace BitCoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrencyMenu = new System.Windows.Forms.ComboBox();
            this.GetRatesBtn = new System.Windows.Forms.Button();
            this.AmountOfBts = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrencyMenu
            // 
            this.CurrencyMenu.FormattingEnabled = true;
            this.CurrencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.CurrencyMenu.Location = new System.Drawing.Point(34, 44);
            this.CurrencyMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyMenu.Name = "CurrencyMenu";
            this.CurrencyMenu.Size = new System.Drawing.Size(128, 23);
            this.CurrencyMenu.TabIndex = 0;
            this.CurrencyMenu.Text = "Select Currency";
            // 
            // GetRatesBtn
            // 
            this.GetRatesBtn.Location = new System.Drawing.Point(189, 106);
            this.GetRatesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetRatesBtn.Name = "GetRatesBtn";
            this.GetRatesBtn.Size = new System.Drawing.Size(111, 20);
            this.GetRatesBtn.TabIndex = 1;
            this.GetRatesBtn.Text = "Get Rates";
            this.GetRatesBtn.UseVisualStyleBackColor = true;
            this.GetRatesBtn.Click += new System.EventHandler(this.GetRatesBtn_Click);
            // 
            // AmountOfBts
            // 
            this.AmountOfBts.Location = new System.Drawing.Point(34, 106);
            this.AmountOfBts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountOfBts.Name = "AmountOfBts";
            this.AmountOfBts.PlaceholderText = "Amount Of Bitcoins";
            this.AmountOfBts.Size = new System.Drawing.Size(128, 23);
            this.AmountOfBts.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.CausesValidation = false;
            this.Result.Location = new System.Drawing.Point(34, 161);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(128, 23);
            this.Result.TabIndex = 3;
            this.Result.Visible = false;
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(34, 136);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(44, 15);
            this.ResultLbl.TabIndex = 4;
            this.ResultLbl.Text = "Results";
            this.ResultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 268);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AmountOfBts);
            this.Controls.Add(this.GetRatesBtn);
            this.Controls.Add(this.CurrencyMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyMenu;
        private System.Windows.Forms.Button GetRatesBtn;
        private System.Windows.Forms.TextBox AmountOfBts;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label ResultLbl;
    }
}

