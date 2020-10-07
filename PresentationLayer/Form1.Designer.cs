namespace PresentationLayer
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtAwakener = new System.Windows.Forms.TextBox();
            this.lbAwakener = new System.Windows.Forms.Label();
            this.cbCompleto = new System.Windows.Forms.CheckBox();
            this.txtDrop = new System.Windows.Forms.TextBox();
            this.lbDrop = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(16, 51);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // txtAwakener
            // 
            this.txtAwakener.Location = new System.Drawing.Point(92, 96);
            this.txtAwakener.Name = "txtAwakener";
            this.txtAwakener.Size = new System.Drawing.Size(100, 22);
            this.txtAwakener.TabIndex = 2;
            // 
            // lbAwakener
            // 
            this.lbAwakener.AutoSize = true;
            this.lbAwakener.Location = new System.Drawing.Point(16, 99);
            this.lbAwakener.Name = "lbAwakener";
            this.lbAwakener.Size = new System.Drawing.Size(70, 17);
            this.lbAwakener.TabIndex = 3;
            this.lbAwakener.Text = "Awakener";
            // 
            // cbCompleto
            // 
            this.cbCompleto.AutoSize = true;
            this.cbCompleto.Location = new System.Drawing.Point(19, 141);
            this.cbCompleto.Name = "cbCompleto";
            this.cbCompleto.Size = new System.Drawing.Size(107, 21);
            this.cbCompleto.TabIndex = 4;
            this.cbCompleto.Text = "COMPLETO";
            this.cbCompleto.UseVisualStyleBackColor = true;
            // 
            // txtDrop
            // 
            this.txtDrop.Location = new System.Drawing.Point(61, 182);
            this.txtDrop.Name = "txtDrop";
            this.txtDrop.Size = new System.Drawing.Size(100, 22);
            this.txtDrop.TabIndex = 5;
            // 
            // lbDrop
            // 
            this.lbDrop.AutoSize = true;
            this.lbDrop.Location = new System.Drawing.Point(16, 182);
            this.lbDrop.Name = "lbDrop";
            this.lbDrop.Size = new System.Drawing.Size(39, 17);
            this.lbDrop.TabIndex = 6;
            this.lbDrop.Text = "Drop";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(40, 238);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 318);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.lbDrop);
            this.Controls.Add(this.txtDrop);
            this.Controls.Add(this.cbCompleto);
            this.Controls.Add(this.lbAwakener);
            this.Controls.Add(this.txtAwakener);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtAwakener;
        private System.Windows.Forms.Label lbAwakener;
        private System.Windows.Forms.CheckBox cbCompleto;
        private System.Windows.Forms.TextBox txtDrop;
        private System.Windows.Forms.Label lbDrop;
        private System.Windows.Forms.Button btn_Salvar;
    }
}

