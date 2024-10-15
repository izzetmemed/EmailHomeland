namespace Email
{
    partial class MainPage
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
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(595, 109);
            label7.Name = "label7";
            label7.Size = new Size(110, 30);
            label7.TabIndex = 41;
            label7.Text = "Message :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(252, 170);
            button1.Name = "button1";
            button1.Size = new Size(221, 43);
            button1.TabIndex = 40;
            button1.Text = "Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(537, 170);
            button2.Name = "button2";
            button2.Size = new Size(263, 43);
            button2.TabIndex = 42;
            button2.Text = "All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(856, 170);
            button3.Name = "button3";
            button3.Size = new Size(285, 43);
            button3.TabIndex = 43;
            button3.Text = "Owner";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(856, 456);
            button4.Name = "button4";
            button4.Size = new Size(285, 43);
            button4.TabIndex = 47;
            button4.Text = "Owner";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(537, 456);
            button5.Name = "button5";
            button5.Size = new Size(263, 43);
            button5.TabIndex = 46;
            button5.Text = "All";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(595, 395);
            label1.Name = "label1";
            label1.Size = new Size(58, 30);
            label1.TabIndex = 45;
            label1.Text = "Get :";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(252, 456);
            button6.Name = "button6";
            button6.Size = new Size(221, 43);
            button6.TabIndex = 44;
            button6.Text = "Customer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 450);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button6;
    }
}