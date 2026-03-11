namespace TaskGUI
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;
                
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
            textBox1 = new TextBox();
            label1 = new Label();
            Results = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(25, 41);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 0;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 15);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите предложение";
            // 
            // Results
            // 
            Results.AutoSize = true;
            Results.Location = new Point(25, 100);
            Results.Name = "Results";
            Results.Size = new Size(69, 15);
            Results.TabIndex = 3;
            Results.Text = "Результаты";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 425);
            Controls.Add(Results);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label Results;
    }
}
