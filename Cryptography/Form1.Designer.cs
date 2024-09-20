namespace Cryptography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CiphertextTextBox = new System.Windows.Forms.TextBox();
            this.PlaintextTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // CiphertextTextBox
            // 
            this.CiphertextTextBox.Location = new System.Drawing.Point(12, 154);
            this.CiphertextTextBox.Multiline = true;
            this.CiphertextTextBox.Name = "CiphertextTextBox";
            this.CiphertextTextBox.Size = new System.Drawing.Size(257, 55);
            this.CiphertextTextBox.TabIndex = 0;
            this.CiphertextTextBox.Text = "Результат";
            this.CiphertextTextBox.TextChanged += new System.EventHandler(this.CiphertextTextBox_TextChanged);
            // 
            // PlaintextTextBox
            // 
            this.PlaintextTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PlaintextTextBox.Location = new System.Drawing.Point(12, 57);
            this.PlaintextTextBox.Multiline = true;
            this.PlaintextTextBox.Name = "PlaintextTextBox";
            this.PlaintextTextBox.Size = new System.Drawing.Size(257, 54);
            this.PlaintextTextBox.TabIndex = 1;
            this.PlaintextTextBox.Text = "Введите текст";
            this.PlaintextTextBox.TextChanged += new System.EventHandler(this.PlaintextTextBox_TextChanged);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(32, 117);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(109, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Шифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click_1);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(147, 117);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(109, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Дешифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный текст/шифр";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 238);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(291, 238);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.PlaintextTextBox);
            this.Controls.Add(this.CiphertextTextBox);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Шифратор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CiphertextTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox PlaintextTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

