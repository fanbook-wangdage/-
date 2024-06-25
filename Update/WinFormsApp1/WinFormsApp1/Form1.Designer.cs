namespace WinFormsApp1
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
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 0;
            label1.Text = "机器人控制器下载工具";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 1;
            label2.Text = "更新简介：";
            // 
            // button1
            // 
            button1.Location = new Point(352, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "下载最新";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 3;
            label3.Text = "下载器版本：1.01";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 40);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 4;
            label4.Text = "机器人控制器最新版本：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 40);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 5;
            label5.Text = "0.00";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 71);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 6;
            label6.Text = "简介";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(271, 205);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "存储库";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 140);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 8;
            label7.Text = "提示";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 249);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "fanbook机器人控制器下载";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label7;
    }
}
