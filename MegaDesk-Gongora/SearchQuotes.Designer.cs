namespace MegaDesk_Gongora
{
    partial class SearchQuotes
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
            this.ExitSearchQuotesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitSearchQuotesBtn
            // 
            this.ExitSearchQuotesBtn.Location = new System.Drawing.Point(480, 268);
            this.ExitSearchQuotesBtn.Name = "ExitSearchQuotesBtn";
            this.ExitSearchQuotesBtn.Size = new System.Drawing.Size(73, 52);
            this.ExitSearchQuotesBtn.TabIndex = 0;
            this.ExitSearchQuotesBtn.Text = "E&xit";
            this.ExitSearchQuotesBtn.UseVisualStyleBackColor = true;
            this.ExitSearchQuotesBtn.Click += new System.EventHandler(this.ExitSearchQuotesBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitSearchQuotesBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitSearchQuotesBtn;
    }
}