namespace MatchingGame
{
    partial class telaInicial
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(231, 159);
            label1.Name = "label1";
            label1.Size = new Size(335, 28);
            label1.TabIndex = 0;
            label1.Text = "Selecione a dificuldade o seu jogo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(162, 9);
            label2.Name = "label2";
            label2.Size = new Size(473, 72);
            label2.TabIndex = 1;
            label2.Text = "Jogo da Memória";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(308, 209);
            button1.Name = "button1";
            button1.Size = new Size(166, 41);
            button1.TabIndex = 2;
            button1.Text = "Normal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(308, 256);
            button2.Name = "button2";
            button2.Size = new Size(166, 41);
            button2.TabIndex = 3;
            button2.Text = "Fácil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(308, 303);
            button3.Name = "button3";
            button3.Size = new Size(166, 41);
            button3.TabIndex = 4;
            button3.Text = "Médio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(308, 350);
            button4.Name = "button4";
            button4.Size = new Size(166, 41);
            button4.TabIndex = 5;
            button4.Text = "Difícil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // telaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pokemon;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(793, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "telaInicial";
            Text = "telaInicial";
            Load += telaInicial_Load;
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
    }
}