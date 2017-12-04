namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.additionButton = new System.Windows.Forms.Button();
            this.valueOneTextBox = new System.Windows.Forms.TextBox();
            this.valueTwoTextBox = new System.Windows.Forms.TextBox();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(12, 76);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(45, 37);
            this.additionButton.TabIndex = 0;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // valueOneTextBox
            // 
            this.valueOneTextBox.Location = new System.Drawing.Point(12, 11);
            this.valueOneTextBox.Name = "valueOneTextBox";
            this.valueOneTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueOneTextBox.TabIndex = 1;
            // 
            // valueTwoTextBox
            // 
            this.valueTwoTextBox.Location = new System.Drawing.Point(143, 11);
            this.valueTwoTextBox.Name = "valueTwoTextBox";
            this.valueTwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTwoTextBox.TabIndex = 2;
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(85, 76);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(45, 37);
            this.subtractionButton.TabIndex = 3;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(160, 76);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(45, 37);
            this.multiplicationButton.TabIndex = 4;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(268, 14);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 145);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.valueTwoTextBox);
            this.Controls.Add(this.valueOneTextBox);
            this.Controls.Add(this.additionButton);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.TextBox valueOneTextBox;
        private System.Windows.Forms.TextBox valueTwoTextBox;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
    }
}

