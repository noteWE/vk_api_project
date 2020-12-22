namespace VK_API
{
    partial class FunctionPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new VK_API.VK_button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F);
            this.button1.Location = new System.Drawing.Point(44, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F);
            this.button2.Location = new System.Drawing.Point(44, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Профиль";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F);
            this.button3.Location = new System.Drawing.Point(44, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Подарки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 12F);
            this.button4.Location = new System.Drawing.Point(44, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Друзья";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 12F);
            this.button5.Location = new System.Drawing.Point(44, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Группы";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(278, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 228);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(41, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Tomato;
            this.button.Location = new System.Drawing.Point(20, 45);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 30);
            this.button.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 12F);
            this.button6.Location = new System.Drawing.Point(44, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FunctionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FunctionPage";
            this.Text = "Функции";
            this.Load += new System.EventHandler(this.FunctionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private VK_button button;
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}