namespace Email
{
    partial class GetGmail
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
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(667, 98);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(267, 178);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 2;
            label3.Text = "Mediatype :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(363, 178);
            label7.Name = "label7";
            label7.Size = new Size(19, 21);
            label7.TabIndex = 6;
            label7.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(625, 178);
            label14.Name = "label14";
            label14.Size = new Size(19, 21);
            label14.TabIndex = 14;
            label14.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(503, 178);
            label15.Name = "label15";
            label15.Size = new Size(103, 21);
            label15.TabIndex = 13;
            label15.Text = "Mediatype 0 :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1128, 178);
            label16.Name = "label16";
            label16.Size = new Size(19, 21);
            label16.TabIndex = 16;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(997, 178);
            label17.Name = "label17";
            label17.Size = new Size(125, 21);
            label17.TabIndex = 15;
            label17.Text = "Customer Local :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(601, 372);
            button1.Name = "button1";
            button1.Size = new Size(310, 43);
            button1.TabIndex = 17;
            button1.Text = "Add Mediatype 0 to Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(84, 43);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(846, 178);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 20;
            label2.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(713, 178);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 19;
            label4.Text = "CustomereEmail:";
            // 
            // GetGmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 450);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "GetGmail";
            Text = "GetGmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label7;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label4;
    }
}