namespace WindowsFormsApp1
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
            this.textName = new System.Windows.Forms.TextBox();
            this.btnGreeting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.greetingOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textName.Location = new System.Drawing.Point(22, 43);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(211, 22);
            this.textName.TabIndex = 0;
            // 
            // btnGreeting
            // 
            this.btnGreeting.Location = new System.Drawing.Point(263, 43);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(176, 32);
            this.btnGreeting.TabIndex = 1;
            this.btnGreeting.Text = "Greetings message";
            this.btnGreeting.UseVisualStyleBackColor = true;
            this.btnGreeting.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // greetingOutput
            // 
            this.greetingOutput.FormattingEnabled = true;
            this.greetingOutput.ItemHeight = 16;
            this.greetingOutput.Location = new System.Drawing.Point(22, 94);
            this.greetingOutput.Name = "greetingOutput";
            this.greetingOutput.Size = new System.Drawing.Size(211, 84);
            this.greetingOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 312);
            this.Controls.Add(this.greetingOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGreeting);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Greetings Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnGreeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox greetingOutput;
    }
}

