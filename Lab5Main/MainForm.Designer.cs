namespace Lab5Main
{
    partial class MainForm
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
            messageTextBox = new TextBox();
            binaryTextBox = new TextBox();
            encodeButton = new Button();
            checkButton = new Button();
            checkStatusLabel = new Label();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 12);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(310, 210);
            messageTextBox.TabIndex = 0;
            // 
            // binaryTextBox
            // 
            binaryTextBox.Location = new Point(482, 12);
            binaryTextBox.Multiline = true;
            binaryTextBox.Name = "binaryTextBox";
            binaryTextBox.Size = new Size(310, 210);
            binaryTextBox.TabIndex = 1;
            // 
            // encodeButton
            // 
            encodeButton.Location = new Point(342, 76);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(119, 32);
            encodeButton.TabIndex = 3;
            encodeButton.Text = "В двоичный код";
            encodeButton.UseVisualStyleBackColor = true;
            encodeButton.Click += EncodeButton_Click;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(342, 114);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(119, 34);
            checkButton.TabIndex = 4;
            checkButton.Text = "Проверить";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += CheckButton_Click;
            // 
            // checkStatusLabel
            // 
            checkStatusLabel.AutoSize = true;
            checkStatusLabel.Location = new Point(342, 168);
            checkStatusLabel.Name = "checkStatusLabel";
            checkStatusLabel.Size = new Size(0, 15);
            checkStatusLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 231);
            Controls.Add(checkStatusLabel);
            Controls.Add(checkButton);
            Controls.Add(encodeButton);
            Controls.Add(binaryTextBox);
            Controls.Add(messageTextBox);
            Name = "MainForm";
            Text = "Проверка с одиночным битом четности";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private TextBox binaryTextBox;
        private Button encodeButton;
        private Button checkButton;
        private Label checkStatusLabel;
    }
}
