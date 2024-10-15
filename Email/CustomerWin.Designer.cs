namespace Email
{
    partial class CustomerWin
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
            label2 = new Label();
            label1 = new Label();
            message = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(603, 108);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 9;
            label2.Text = "Messaj";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(556, 34);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 8;
            label1.Text = "Müştəri gmail";
            // 
            // message
            // 
            message.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            message.Location = new Point(540, 150);
            message.Name = "message";
            message.Size = new Size(198, 43);
            message.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(589, 211);
            button1.Name = "button1";
            button1.Size = new Size(102, 39);
            button1.TabIndex = 6;
            button1.Text = "Göndər";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(422, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(447, 234);
            dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(84, 43);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CustomerWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(message);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CustomerWin";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox message;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}