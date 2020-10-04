namespace MegaDesk_Gongora
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.ExitAddQuoteFormBtn = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DeskOptionsGroup = new System.Windows.Forms.GroupBox();
            this.NoOfDrawersInput = new System.Windows.Forms.ComboBox();
            this.MaterialSelectionInput = new System.Windows.Forms.ComboBox();
            this.DeskMaterialLabel = new System.Windows.Forms.Label();
            this.NoOfDrawersLabel = new System.Windows.Forms.Label();
            this.OrderOptionsGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductionDaysInput = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DisplayQuoteBtn = new System.Windows.Forms.Button();
            this.DeskOptionsGroup.SuspendLayout();
            this.OrderOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitAddQuoteFormBtn
            // 
            this.ExitAddQuoteFormBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitAddQuoteFormBtn.Location = new System.Drawing.Point(147, 353);
            this.ExitAddQuoteFormBtn.Name = "ExitAddQuoteFormBtn";
            this.ExitAddQuoteFormBtn.Size = new System.Drawing.Size(115, 42);
            this.ExitAddQuoteFormBtn.TabIndex = 7;
            this.ExitAddQuoteFormBtn.Text = "&Cancel";
            this.ExitAddQuoteFormBtn.UseVisualStyleBackColor = false;
            this.ExitAddQuoteFormBtn.Click += new System.EventHandler(this.ExitAddQuoteFormBtn_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(100, 6);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(147, 20);
            this.NameInput.TabIndex = 0;
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(92, 31);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(147, 20);
            this.WidthInput.TabIndex = 1;
            this.WidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.WidthInput_Validating);
            this.WidthInput.Validated += new System.EventHandler(this.WidthInput_Validated);
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Location = new System.Drawing.Point(6, 34);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(75, 13);
            this.DeskWidthLabel.TabIndex = 3;
            this.DeskWidthLabel.Text = "Width (inches)";
            // 
            // DepthInput
            // 
            this.DepthInput.Location = new System.Drawing.Point(92, 67);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(147, 20);
            this.DepthInput.TabIndex = 2;
            this.DepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthInput_KeyPress);
            this.DepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DepthInput_Validating);
            this.DepthInput.Validated += new System.EventHandler(this.DepthInput_Validated);
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Location = new System.Drawing.Point(5, 70);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(76, 13);
            this.DeskDepthLabel.TabIndex = 5;
            this.DeskDepthLabel.Text = "Depth (inches)";
            // 
            // DeskOptionsGroup
            // 
            this.DeskOptionsGroup.Controls.Add(this.NoOfDrawersInput);
            this.DeskOptionsGroup.Controls.Add(this.MaterialSelectionInput);
            this.DeskOptionsGroup.Controls.Add(this.DeskMaterialLabel);
            this.DeskOptionsGroup.Controls.Add(this.NoOfDrawersLabel);
            this.DeskOptionsGroup.Controls.Add(this.DepthInput);
            this.DeskOptionsGroup.Controls.Add(this.DeskDepthLabel);
            this.DeskOptionsGroup.Controls.Add(this.WidthInput);
            this.DeskOptionsGroup.Controls.Add(this.DeskWidthLabel);
            this.DeskOptionsGroup.Location = new System.Drawing.Point(8, 40);
            this.DeskOptionsGroup.Name = "DeskOptionsGroup";
            this.DeskOptionsGroup.Size = new System.Drawing.Size(254, 178);
            this.DeskOptionsGroup.TabIndex = 7;
            this.DeskOptionsGroup.TabStop = false;
            this.DeskOptionsGroup.Text = "Desktop Properties";
            // 
            // NoOfDrawersInput
            // 
            this.NoOfDrawersInput.FormattingEnabled = true;
            this.NoOfDrawersInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NoOfDrawersInput.Location = new System.Drawing.Point(92, 102);
            this.NoOfDrawersInput.Name = "NoOfDrawersInput";
            this.NoOfDrawersInput.Size = new System.Drawing.Size(147, 21);
            this.NoOfDrawersInput.TabIndex = 3;
            this.NoOfDrawersInput.Text = "Select number";
            // 
            // MaterialSelectionInput
            // 
            this.MaterialSelectionInput.FormattingEnabled = true;
            this.MaterialSelectionInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.MaterialSelectionInput.Location = new System.Drawing.Point(92, 138);
            this.MaterialSelectionInput.Name = "MaterialSelectionInput";
            this.MaterialSelectionInput.Size = new System.Drawing.Size(147, 21);
            this.MaterialSelectionInput.TabIndex = 4;
            this.MaterialSelectionInput.Text = "Select material";
            // 
            // DeskMaterialLabel
            // 
            this.DeskMaterialLabel.AutoSize = true;
            this.DeskMaterialLabel.Location = new System.Drawing.Point(6, 138);
            this.DeskMaterialLabel.Name = "DeskMaterialLabel";
            this.DeskMaterialLabel.Size = new System.Drawing.Size(44, 13);
            this.DeskMaterialLabel.TabIndex = 9;
            this.DeskMaterialLabel.Text = "Material";
            // 
            // NoOfDrawersLabel
            // 
            this.NoOfDrawersLabel.AutoSize = true;
            this.NoOfDrawersLabel.Location = new System.Drawing.Point(6, 105);
            this.NoOfDrawersLabel.Name = "NoOfDrawersLabel";
            this.NoOfDrawersLabel.Size = new System.Drawing.Size(76, 13);
            this.NoOfDrawersLabel.TabIndex = 7;
            this.NoOfDrawersLabel.Text = "No. of drawers";
            // 
            // OrderOptionsGroup
            // 
            this.OrderOptionsGroup.Controls.Add(this.label1);
            this.OrderOptionsGroup.Controls.Add(this.ProductionDaysInput);
            this.OrderOptionsGroup.Location = new System.Drawing.Point(8, 239);
            this.OrderOptionsGroup.Name = "OrderOptionsGroup";
            this.OrderOptionsGroup.Size = new System.Drawing.Size(254, 82);
            this.OrderOptionsGroup.TabIndex = 8;
            this.OrderOptionsGroup.TabStop = false;
            this.OrderOptionsGroup.Text = "Order Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Production time";
            // 
            // ProductionDaysInput
            // 
            this.ProductionDaysInput.FormattingEnabled = true;
            this.ProductionDaysInput.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.ProductionDaysInput.Location = new System.Drawing.Point(105, 32);
            this.ProductionDaysInput.Name = "ProductionDaysInput";
            this.ProductionDaysInput.Size = new System.Drawing.Size(134, 21);
            this.ProductionDaysInput.TabIndex = 5;
            this.ProductionDaysInput.Text = "Select production days";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // DisplayQuoteBtn
            // 
            this.DisplayQuoteBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DisplayQuoteBtn.Location = new System.Drawing.Point(8, 353);
            this.DisplayQuoteBtn.Name = "DisplayQuoteBtn";
            this.DisplayQuoteBtn.Size = new System.Drawing.Size(115, 42);
            this.DisplayQuoteBtn.TabIndex = 6;
            this.DisplayQuoteBtn.Text = "Display &Quote";
            this.DisplayQuoteBtn.UseVisualStyleBackColor = false;
            this.DisplayQuoteBtn.Click += new System.EventHandler(this.DisplayQuoteBtn_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 402);
            this.Controls.Add(this.DisplayQuoteBtn);
            this.Controls.Add(this.OrderOptionsGroup);
            this.Controls.Add(this.DeskOptionsGroup);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.ExitAddQuoteFormBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.DeskOptionsGroup.ResumeLayout(false);
            this.DeskOptionsGroup.PerformLayout();
            this.OrderOptionsGroup.ResumeLayout(false);
            this.OrderOptionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitAddQuoteFormBtn;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.GroupBox DeskOptionsGroup;
        private System.Windows.Forms.ComboBox MaterialSelectionInput;
        private System.Windows.Forms.Label DeskMaterialLabel;
        private System.Windows.Forms.Label NoOfDrawersLabel;
        private System.Windows.Forms.GroupBox OrderOptionsGroup;
        private System.Windows.Forms.ComboBox NoOfDrawersInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductionDaysInput;
        private System.Windows.Forms.Button DisplayQuoteBtn;
    }
}