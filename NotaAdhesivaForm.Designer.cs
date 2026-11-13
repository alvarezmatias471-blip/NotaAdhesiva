namespace NotaAdhesiva
{
    partial class NotaAdhesivaForm
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
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.tituloNota = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.editorNota = new System.Windows.Forms.RichTextBox();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(150)))));
            this.barraTitulo.Controls.Add(this.tituloNota);
            this.barraTitulo.Controls.Add(this.botonCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(280, 38);
            this.barraTitulo.TabIndex = 0;
            // 
            // tituloNota
            // 
            this.tituloNota.AutoSize = true;
            this.tituloNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tituloNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(35)))));
            this.tituloNota.Location = new System.Drawing.Point(10, 11);
            this.tituloNota.Name = "tituloNota";
            this.tituloNota.Size = new System.Drawing.Size(78, 15);
            this.tituloNota.TabIndex = 0;
            this.tituloNota.Text = "Recordatorio";
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(150)))));
            this.botonCerrar.FlatAppearance.BorderSize = 0;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.botonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(35)))));
            this.botonCerrar.Location = new System.Drawing.Point(244, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(32, 30);
            this.botonCerrar.TabIndex = 2;
            this.botonCerrar.Text = "×";
            this.botonCerrar.UseVisualStyleBackColor = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // editorNota
            // 
            this.editorNota.AcceptsTab = true;
            this.editorNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.editorNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorNota.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.editorNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.editorNota.Location = new System.Drawing.Point(0, 38);
            this.editorNota.Name = "editorNota";
            this.editorNota.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.editorNota.Size = new System.Drawing.Size(280, 262);
            this.editorNota.TabIndex = 1;
            this.editorNota.Text = "";
            this.editorNota.WordWrap = true;
            // 
            // NotaAdhesivaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(280, 300);
            this.Controls.Add(this.editorNota);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(220, 180);
            this.Name = "NotaAdhesivaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nota adhesiva";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label tituloNota;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.RichTextBox editorNota;
    }
}