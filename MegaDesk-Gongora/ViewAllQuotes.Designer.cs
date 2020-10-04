namespace MegaDesk_Gongora
{
    partial class ViewAllQuotes
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
            this.ExitViewAllQuotesFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitViewAllQuotesFormBtn
            // 
            this.ExitViewAllQuotesFormBtn.Location = new System.Drawing.Point(487, 284);
            this.ExitViewAllQuotesFormBtn.Name = "ExitViewAllQuotesFormBtn";
            this.ExitViewAllQuotesFormBtn.Size = new System.Drawing.Size(84, 57);
            this.ExitViewAllQuotesFormBtn.TabIndex = 0;
            this.ExitViewAllQuotesFormBtn.Text = "E&xit";
            this.ExitViewAllQuotesFormBtn.UseVisualStyleBackColor = true;
            this.ExitViewAllQuotesFormBtn.Click += new System.EventHandler(this.ExitViewAllQuotesFormBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitViewAllQuotesFormBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitViewAllQuotesFormBtn;
    }
}