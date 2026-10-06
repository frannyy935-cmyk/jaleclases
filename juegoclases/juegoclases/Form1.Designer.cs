namespace juegoclases
{
    partial class txtNombre1
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
            lblTitulo = new Label();
            grpPersonaje1 = new GroupBox();
            grpPeronsaje2 = new GroupBox();
            lblNombre1 = new Label();
            lblNombre2 = new Label();
            textBox1 = new TextBox();
            txtNombre2 = new TextBox();
            btnAtacar1 = new Button();
            btnAtacar2 = new Button();
            lblvida1 = new Label();
            lblVida2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(22, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Combate de personaje";
            // 
            // grpPersonaje1
            // 
            grpPersonaje1.Location = new Point(19, 57);
            grpPersonaje1.Name = "grpPersonaje1";
            grpPersonaje1.Size = new Size(200, 100);
            grpPersonaje1.TabIndex = 1;
            grpPersonaje1.TabStop = false;
            grpPersonaje1.Text = "Player 1";
            // 
            // grpPeronsaje2
            // 
            grpPeronsaje2.Location = new Point(352, 57);
            grpPeronsaje2.Name = "grpPeronsaje2";
            grpPeronsaje2.Size = new Size(200, 100);
            grpPeronsaje2.TabIndex = 2;
            grpPeronsaje2.TabStop = false;
            grpPeronsaje2.Text = "Player 2";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Location = new Point(32, 181);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(54, 15);
            lblNombre1.TabIndex = 3;
            lblNombre1.Text = "Nombre:";
            // 
            // lblNombre2
            // 
            lblNombre2.AutoSize = true;
            lblNombre2.Location = new Point(357, 181);
            lblNombre2.Name = "lblNombre2";
            lblNombre2.Size = new Size(57, 15);
            lblNombre2.TabIndex = 4;
            lblNombre2.Text = "Nombre: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(420, 178);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(100, 23);
            txtNombre2.TabIndex = 6;
            // 
            // btnAtacar1
            // 
            btnAtacar1.Location = new Point(32, 249);
            btnAtacar1.Name = "btnAtacar1";
            btnAtacar1.Size = new Size(75, 23);
            btnAtacar1.TabIndex = 7;
            btnAtacar1.Text = "Atacar";
            btnAtacar1.UseVisualStyleBackColor = true;
            // 
            // btnAtacar2
            // 
            btnAtacar2.Location = new Point(352, 249);
            btnAtacar2.Name = "btnAtacar2";
            btnAtacar2.Size = new Size(75, 23);
            btnAtacar2.TabIndex = 8;
            btnAtacar2.Text = "Atacar";
            btnAtacar2.UseVisualStyleBackColor = true;
            // 
            // lblvida1
            // 
            lblvida1.AutoSize = true;
            lblvida1.Location = new Point(32, 218);
            lblvida1.Name = "lblvida1";
            lblvida1.Size = new Size(53, 15);
            lblvida1.TabIndex = 9;
            lblvida1.Text = "vida: 100";
            // 
            // lblVida2
            // 
            lblVida2.AutoSize = true;
            lblVida2.Location = new Point(355, 216);
            lblVida2.Name = "lblVida2";
            lblVida2.Size = new Size(53, 15);
            lblVida2.TabIndex = 10;
            lblVida2.Text = "vida: 100";
            // 
            // txtNombre1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 336);
            Controls.Add(lblVida2);
            Controls.Add(lblvida1);
            Controls.Add(btnAtacar2);
            Controls.Add(btnAtacar1);
            Controls.Add(txtNombre2);
            Controls.Add(textBox1);
            Controls.Add(lblNombre2);
            Controls.Add(lblNombre1);
            Controls.Add(grpPeronsaje2);
            Controls.Add(grpPersonaje1);
            Controls.Add(lblTitulo);
            Name = "txtNombre1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpPersonaje1;
        private GroupBox grpPeronsaje2;
        private Label lblNombre1;
        private Label lblNombre2;
        private TextBox textBox1;
        private TextBox txtNombre2;
        private Button btnAtacar1;
        private Button btnAtacar2;
        private Label lblvida1;
        private Label lblVida2;
    }
}
