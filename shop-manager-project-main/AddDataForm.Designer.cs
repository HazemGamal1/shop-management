namespace shopManager
{
    partial class AddDataForm
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
            nameTxt = new TextBox();
            costTxt = new TextBox();
            profitTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            categoryComboBox = new ComboBox();
            addBtn = new Button();
            button1 = new Button();
            quantityNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)quantityNum).BeginInit();
            SuspendLayout();
            // 
            // nameTxt
            // 
            nameTxt.Anchor = AnchorStyles.None;
            nameTxt.BackColor = Color.FromArgb(23, 37, 47);
            nameTxt.BorderStyle = BorderStyle.FixedSingle;
            nameTxt.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nameTxt.ForeColor = Color.White;
            nameTxt.Location = new Point(485, 92);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(219, 35);
            nameTxt.TabIndex = 0;
            // 
            // costTxt
            // 
            costTxt.Anchor = AnchorStyles.None;
            costTxt.BackColor = Color.FromArgb(23, 37, 47);
            costTxt.BorderStyle = BorderStyle.FixedSingle;
            costTxt.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            costTxt.ForeColor = Color.White;
            costTxt.Location = new Point(485, 283);
            costTxt.Multiline = true;
            costTxt.Name = "costTxt";
            costTxt.Size = new Size(219, 32);
            costTxt.TabIndex = 3;
            // 
            // profitTxt
            // 
            profitTxt.Anchor = AnchorStyles.None;
            profitTxt.BackColor = Color.FromArgb(23, 37, 47);
            profitTxt.BorderStyle = BorderStyle.FixedSingle;
            profitTxt.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            profitTxt.ForeColor = Color.White;
            profitTxt.Location = new Point(485, 351);
            profitTxt.Multiline = true;
            profitTxt.Name = "profitTxt";
            profitTxt.Size = new Size(219, 32);
            profitTxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(382, 92);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(382, 222);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 6;
            label2.Text = "Category ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(382, 153);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(382, 290);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 8;
            label4.Text = "Cost";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(382, 351);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 9;
            label5.Text = "Profit";
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.None;
            categoryComboBox.BackColor = Color.FromArgb(23, 37, 47);
            categoryComboBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.White;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Cameras ", "Phones", "Accessories" });
            categoryComboBox.Location = new Point(485, 215);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(219, 32);
            categoryComboBox.TabIndex = 11;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.BackColor = Color.FromArgb(114, 0, 0);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(544, 438);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(70, 37);
            addBtn.TabIndex = 12;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(931, 30);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(228, 37);
            button1.TabIndex = 13;
            button1.Text = "Back To List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // quantityNum
            // 
            quantityNum.Anchor = AnchorStyles.None;
            quantityNum.BackColor = Color.FromArgb(23, 37, 47);
            quantityNum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityNum.ForeColor = Color.White;
            quantityNum.Location = new Point(485, 149);
            quantityNum.Name = "quantityNum";
            quantityNum.Size = new Size(55, 29);
            quantityNum.TabIndex = 14;
            // 
            // AddDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 24, 33);
            ClientSize = new Size(1187, 589);
            Controls.Add(quantityNum);
            Controls.Add(button1);
            Controls.Add(addBtn);
            Controls.Add(categoryComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(profitTxt);
            Controls.Add(costTxt);
            Controls.Add(nameTxt);
            Name = "AddDataForm";
            Text = "AddDataForm";
            Load += AddDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTxt;
        private TextBox quantTxt;
        private TextBox costTxt;
        private TextBox profitTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox categoryComboBox;
        private Button addBtn;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown quantityNum;
    }
}