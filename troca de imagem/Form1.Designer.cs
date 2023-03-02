namespace troca_de_imagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxMostrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCafe = new System.Windows.Forms.PictureBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(133, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clique para mostrar a Imagem!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(133, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clique para apagar a Imagem!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxMostrar
            // 
            this.pictureBoxMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMostrar.Image")));
            this.pictureBoxMostrar.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxMostrar.Name = "pictureBoxMostrar";
            this.pictureBoxMostrar.Size = new System.Drawing.Size(637, 363);
            this.pictureBoxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostrar.TabIndex = 1;
            this.pictureBoxMostrar.TabStop = false;
            this.pictureBoxMostrar.Visible = false;
            // 
            // pictureBoxCafe
            // 
            this.pictureBoxCafe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCafe.Image")));
            this.pictureBoxCafe.Location = new System.Drawing.Point(643, 1);
            this.pictureBoxCafe.Name = "pictureBoxCafe";
            this.pictureBoxCafe.Size = new System.Drawing.Size(571, 363);
            this.pictureBoxCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCafe.TabIndex = 2;
            this.pictureBoxCafe.TabStop = false;
            this.pictureBoxCafe.Visible = false;
            this.pictureBoxCafe.Click += new System.EventHandler(this.pictureBoxCafe_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(803, 394);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(317, 42);
            this.buttonMostrar.TabIndex = 3;
            this.buttonMostrar.Text = "Clique para mostrar a imagem!";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(803, 443);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(317, 41);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Clique para apagar a imagem!";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1217, 537);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.pictureBoxCafe);
            this.Controls.Add(this.pictureBoxMostrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCafe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxMostrar;
        private System.Windows.Forms.PictureBox pictureBoxCafe;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonApagar;
    }
}

