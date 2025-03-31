namespace AdvancedProgrammingAssignment1
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            amountTextBox = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            accountComboBox = new ComboBox();
            userComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 219);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(amountTextBox);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(accountComboBox);
            groupBox1.Controls.Add(userComboBox);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(53, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1185, 279);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 146);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 10;
            label4.Text = "Transactions";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(325, 169);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(826, 84);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 153);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Amount";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(27, 177);
            amountTextBox.Margin = new Padding(3, 4, 3, 4);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(209, 27);
            amountTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(826, 84);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 5;
            label2.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 83);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Account";
            // 
            // accountComboBox
            // 
            accountComboBox.FormattingEnabled = true;
            accountComboBox.Location = new Point(27, 107);
            accountComboBox.Name = "accountComboBox";
            accountComboBox.Size = new Size(209, 28);
            accountComboBox.TabIndex = 3;
            accountComboBox.SelectedIndexChanged += accountComboBox_SelectedIndexChanged;
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(27, 51);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(209, 28);
            userComboBox.TabIndex = 2;
            userComboBox.SelectedIndexChanged += userComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 451);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox accountComboBox;
        private ComboBox userComboBox;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox amountTextBox;
        private Label label4;
        private ListBox listBox1;
    }
}
