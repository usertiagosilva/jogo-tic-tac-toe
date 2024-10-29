namespace JogoDaVelha
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
            btn00 = new Button();
            btn01 = new Button();
            btn02 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn20 = new Button();
            btn21 = new Button();
            btn22 = new Button();
            lblStatus = new Label();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // btn00
            // 
            btn00.Location = new Point(41, 82);
            btn00.Name = "btn00";
            btn00.Size = new Size(100, 100);
            btn00.TabIndex = 0;
            btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            btn01.Location = new Point(193, 82);
            btn01.Name = "btn01";
            btn01.Size = new Size(100, 100);
            btn01.TabIndex = 1;
            btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            btn02.Location = new Point(339, 82);
            btn02.Name = "btn02";
            btn02.Size = new Size(100, 100);
            btn02.TabIndex = 2;
            btn02.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Location = new Point(41, 197);
            btn10.Name = "btn10";
            btn10.Size = new Size(100, 100);
            btn10.TabIndex = 3;
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.Location = new Point(193, 197);
            btn11.Name = "btn11";
            btn11.Size = new Size(100, 100);
            btn11.TabIndex = 4;
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.Location = new Point(339, 197);
            btn12.Name = "btn12";
            btn12.Size = new Size(100, 100);
            btn12.TabIndex = 5;
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.Location = new Point(41, 332);
            btn20.Name = "btn20";
            btn20.Size = new Size(100, 100);
            btn20.TabIndex = 6;
            btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            btn21.Location = new Point(193, 332);
            btn21.Name = "btn21";
            btn21.Size = new Size(100, 100);
            btn21.TabIndex = 7;
            btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            btn22.Location = new Point(339, 332);
            btn22.Name = "btn22";
            btn22.Size = new Size(100, 100);
            btn22.TabIndex = 8;
            btn22.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(184, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(13, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = " ";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(199, 472);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(94, 29);
            btnReiniciar.TabIndex = 10;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 541);
            Controls.Add(btnReiniciar);
            Controls.Add(lblStatus);
            Controls.Add(btn22);
            Controls.Add(btn21);
            Controls.Add(btn20);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn02);
            Controls.Add(btn01);
            Controls.Add(btn00);
            Name = "Form1";
            Text = "Jogo da velha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn00;
        private Button btn01;
        private Button btn02;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn20;
        private Button btn21;
        private Button btn22;
        private Label lblStatus;
        private Button btnReiniciar;
    }
}
