
namespace Calculo_do_peso_ideal
{
    partial class frmPesoIdeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesoIdeal));
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbnFeminino);
            this.gbxSexo.Controls.Add(this.rbnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(18, 13);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSexo.Size = new System.Drawing.Size(240, 53);
            this.gbxSexo.TabIndex = 0;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            this.gbxSexo.Enter += new System.EventHandler(this.gbxSexo_Enter);
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFeminino.Location = new System.Drawing.Point(129, 23);
            this.rbnFeminino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(108, 25);
            this.rbnFeminino.TabIndex = 1;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Checked = true;
            this.rbnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMasculino.Location = new System.Drawing.Point(8, 23);
            this.rbnMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(116, 25);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            this.rbnMasculino.CheckedChanged += new System.EventHandler(this.rbnMasculino_CheckedChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(274, 17);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 16);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(278, 38);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(81, 22);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.Location = new System.Drawing.Point(136, 85);
            this.lblPesoIdeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(73, 16);
            this.lblPesoIdeal.TabIndex = 3;
            this.lblPesoIdeal.Text = "Peso Ideal";
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesoIdeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.txtPesoIdeal.Location = new System.Drawing.Point(143, 114);
            this.txtPesoIdeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.ReadOnly = true;
            this.txtPesoIdeal.Size = new System.Drawing.Size(83, 22);
            this.txtPesoIdeal.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 163);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gbxSexo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPesoIdeal";
            this.Text = "Cálculo do peso ideal";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtPesoIdeal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

