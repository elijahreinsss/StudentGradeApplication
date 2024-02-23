namespace StudentGradeApplication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextboxEnglish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextboxMath = new System.Windows.Forms.TextBox();
            this.TextboxScience = new System.Windows.Forms.TextBox();
            this.TextboxFilipino = new System.Windows.Forms.TextBox();
            this.TextboxHistory = new System.Windows.Forms.TextBox();
            this.GenerateAveButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(142, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(164, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TextboxEnglish
            // 
            this.TextboxEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextboxEnglish.Location = new System.Drawing.Point(124, 140);
            this.TextboxEnglish.Name = "TextboxEnglish";
            this.TextboxEnglish.Size = new System.Drawing.Size(96, 23);
            this.TextboxEnglish.TabIndex = 4;
            this.TextboxEnglish.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "English";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(34, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(34, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Science";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.Location = new System.Drawing.Point(34, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Filipino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label7.Location = new System.Drawing.Point(34, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Math";
            // 
            // TextboxMath
            // 
            this.TextboxMath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextboxMath.Location = new System.Drawing.Point(124, 183);
            this.TextboxMath.Name = "TextboxMath";
            this.TextboxMath.Size = new System.Drawing.Size(96, 23);
            this.TextboxMath.TabIndex = 10;
            this.TextboxMath.TextChanged += new System.EventHandler(this.TextboxMath_TextChanged);
            // 
            // TextboxScience
            // 
            this.TextboxScience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextboxScience.Location = new System.Drawing.Point(124, 222);
            this.TextboxScience.Name = "TextboxScience";
            this.TextboxScience.Size = new System.Drawing.Size(96, 23);
            this.TextboxScience.TabIndex = 11;
            // 
            // TextboxFilipino
            // 
            this.TextboxFilipino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxFilipino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextboxFilipino.Location = new System.Drawing.Point(124, 272);
            this.TextboxFilipino.Name = "TextboxFilipino";
            this.TextboxFilipino.Size = new System.Drawing.Size(96, 23);
            this.TextboxFilipino.TabIndex = 12;
            // 
            // TextboxHistory
            // 
            this.TextboxHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextboxHistory.Location = new System.Drawing.Point(124, 329);
            this.TextboxHistory.Name = "TextboxHistory";
            this.TextboxHistory.Size = new System.Drawing.Size(96, 23);
            this.TextboxHistory.TabIndex = 13;
            // 
            // GenerateAveButton
            // 
            this.GenerateAveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GenerateAveButton.Location = new System.Drawing.Point(67, 395);
            this.GenerateAveButton.Name = "GenerateAveButton";
            this.GenerateAveButton.Size = new System.Drawing.Size(138, 43);
            this.GenerateAveButton.TabIndex = 14;
            this.GenerateAveButton.Text = "Generate Average";
            this.GenerateAveButton.UseVisualStyleBackColor = false;
            this.GenerateAveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Result.Location = new System.Drawing.Point(353, 185);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 17);
            this.Result.TabIndex = 15;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.GenerateAveButton);
            this.Controls.Add(this.TextboxHistory);
            this.Controls.Add(this.TextboxFilipino);
            this.Controls.Add(this.TextboxScience);
            this.Controls.Add(this.TextboxMath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxEnglish);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextboxEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextboxMath;
        private System.Windows.Forms.TextBox TextboxScience;
        private System.Windows.Forms.TextBox TextboxFilipino;
        private System.Windows.Forms.TextBox TextboxHistory;
        private System.Windows.Forms.Button GenerateAveButton;
        private System.Windows.Forms.Label Result;
    }
}

