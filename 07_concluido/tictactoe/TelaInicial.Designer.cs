namespace tictactoe
{
    partial class TelaInicial
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
            single = new Button();
            multi = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // single
            // 
            single.Location = new Point(155, 188);
            single.Name = "single";
            single.Size = new Size(186, 66);
            single.TabIndex = 0;
            single.Text = "Singleplayer";
            single.UseVisualStyleBackColor = true;
            single.Click += button1_Click;
            // 
            // multi
            // 
            multi.Location = new Point(429, 188);
            multi.Name = "multi";
            multi.Size = new Size(186, 66);
            multi.TabIndex = 1;
            multi.Text = "Multiplayer";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 76);
            label1.Name = "label1";
            label1.Size = new Size(678, 71);
            label1.TabIndex = 2;
            label1.Text = "Selecione o modo de jogo";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(multi);
            Controls.Add(single);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button single;
        private Button multi;
        private Label label1;
    }
}