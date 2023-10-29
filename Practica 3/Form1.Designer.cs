namespace Practica_3
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
            label1 = new Label();
            label2 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 133);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 1;
            label2.Text = "Segundo Numero";
            // 
            // num1
            // 
            num1.Location = new Point(202, 40);
            num1.Name = "num1";
            num1.Size = new Size(171, 23);
            num1.TabIndex = 2;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // num2
            // 
            num2.Location = new Point(198, 132);
            num2.Name = "num2";
            num2.Size = new Size(176, 23);
            num2.TabIndex = 3;
            num2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(519, 279);
            button1.Name = "button1";
            button1.Size = new Size(177, 43);
            button1.TabIndex = 4;
            button1.Text = "SUMAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 227);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 5;
            label3.Text = "Sum=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sumar Numeros";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num1;
        private TextBox num2;
        private Button button1;
        private Label label3;
    }
}