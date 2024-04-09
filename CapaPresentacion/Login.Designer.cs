namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botoningresar = new System.Windows.Forms.Button();
            this.botoncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 529);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(679, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 112);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory \r\nExpress";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Coral;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(38, 155);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(449, 39);
            this.txtusuario.TabIndex = 3;
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(38, 289);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(449, 39);
            this.txtclave.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // botoningresar
            // 
            this.botoningresar.BackColor = System.Drawing.Color.ForestGreen;
            this.botoningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoningresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botoningresar.Location = new System.Drawing.Point(38, 420);
            this.botoningresar.Name = "botoningresar";
            this.botoningresar.Size = new System.Drawing.Size(197, 56);
            this.botoningresar.TabIndex = 7;
            this.botoningresar.Text = "Ingresar";
            this.botoningresar.UseVisualStyleBackColor = false;
            this.botoningresar.Click += new System.EventHandler(this.botoningresar_Click);
            // 
            // botoncancelar
            // 
            this.botoncancelar.BackColor = System.Drawing.Color.DarkRed;
            this.botoncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botoncancelar.Location = new System.Drawing.Point(290, 420);
            this.botoncancelar.Name = "botoncancelar";
            this.botoncancelar.Size = new System.Drawing.Size(197, 56);
            this.botoncancelar.TabIndex = 8;
            this.botoncancelar.Text = "Cancelar";
            this.botoncancelar.UseVisualStyleBackColor = false;
            this.botoncancelar.Click += new System.EventHandler(this.botoncancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 529);
            this.Controls.Add(this.botoncancelar);
            this.Controls.Add(this.botoningresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botoningresar;
        private System.Windows.Forms.Button botoncancelar;
    }
}