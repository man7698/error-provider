namespace errorprovider
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
            this.components = new System.ComponentModel.Container();
            this.btnok = new System.Windows.Forms.Button();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(255, 33);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(85, 33);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(255, 83);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(85, 34);
            this.btnhabilitar.TabIndex = 1;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(78, 39);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(136, 29);
            this.txtnome.TabIndex = 2;
            this.txtnome.Validating += new System.ComponentModel.CancelEventHandler(this.txtnome_Validating);
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.Location = new System.Drawing.Point(78, 97);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(136, 29);
            this.txtidade.TabIndex = 3;
            this.txtidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtidade_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 159);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btnok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error provider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

