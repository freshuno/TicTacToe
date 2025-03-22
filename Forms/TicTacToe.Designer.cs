namespace TicTacToe
{
    partial class TicTacToe
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Player X wins: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 24);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Player O wins: 0";
            // 
            // button1
            // 
            button1.Location = new Point(72, 52);
            button1.Name = "button1";
            button1.Size = new Size(91, 89);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClick;
            // 
            // button2
            // 
            button2.Location = new Point(207, 52);
            button2.Name = "button2";
            button2.Size = new Size(91, 89);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClick;
            // 
            // button3
            // 
            button3.Location = new Point(342, 52);
            button3.Name = "button3";
            button3.Size = new Size(91, 89);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonClick;
            // 
            // button4
            // 
            button4.Location = new Point(72, 147);
            button4.Name = "button4";
            button4.Size = new Size(91, 89);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.Location = new Point(207, 147);
            button5.Name = "button5";
            button5.Size = new Size(91, 89);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.Location = new Point(342, 147);
            button6.Name = "button6";
            button6.Size = new Size(91, 89);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.Location = new Point(72, 242);
            button7.Name = "button7";
            button7.Size = new Size(91, 89);
            button7.TabIndex = 10;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.Location = new Point(207, 242);
            button8.Name = "button8";
            button8.Size = new Size(91, 89);
            button8.TabIndex = 9;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.Location = new Point(342, 242);
            button9.Name = "button9";
            button9.Size = new Size(91, 89);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 24);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 11;
            label3.Text = "Current player:";
            label3.Visible = false;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 364);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TicTacToe";
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label3;
    }
}
