namespace tictactoe
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
            components = new System.ComponentModel.Container();
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
            button10 = new Button();
            AImoves = new System.Windows.Forms.Timer(components);
            button11 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Player Wins - 0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(456, 12);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "AI Wins - 0";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 56);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(155, 150);
            button1.TabIndex = 2;
            button1.Tag = "play";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(218, 56);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(155, 150);
            button2.TabIndex = 2;
            button2.Tag = "play";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(380, 56);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(155, 150);
            button3.TabIndex = 2;
            button3.Tag = "play";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(56, 214);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(155, 150);
            button4.TabIndex = 2;
            button4.Tag = "play";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(218, 214);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(155, 150);
            button5.TabIndex = 2;
            button5.Tag = "play";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(380, 214);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(155, 150);
            button6.TabIndex = 2;
            button6.Tag = "play";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(56, 371);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(155, 150);
            button7.TabIndex = 2;
            button7.Tag = "play";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(218, 371);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(155, 150);
            button8.TabIndex = 2;
            button8.Tag = "play";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(380, 371);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(155, 150);
            button9.TabIndex = 2;
            button9.Tag = "play";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(235, 556);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(129, 44);
            button10.TabIndex = 5;
            button10.Tag = "restart";
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += restartGame;
            // 
            // AImoves
            // 
            AImoves.Interval = 1000;
            AImoves.Tick += AImove;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(406, 556);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.Size = new Size(129, 44);
            button11.TabIndex = 6;
            button11.Tag = "restart";
            button11.Text = "Tela Inicial";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 629);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe - MOO ICT";
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer AImoves;
        private Button button11;
    }
}
