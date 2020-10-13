namespace PresentationLayer
{
    partial class FormCadastroSirus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAwakenerLevel = new System.Windows.Forms.ComboBox();
            this.chkBoxCompletado = new System.Windows.Forms.CheckBox();
            this.dgvSirus = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirus)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 22);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Awakener";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Completado?";
            // 
            // cbAwakenerLevel
            // 
            this.cbAwakenerLevel.FormattingEnabled = true;
            this.cbAwakenerLevel.Location = new System.Drawing.Point(23, 90);
            this.cbAwakenerLevel.Name = "cbAwakenerLevel";
            this.cbAwakenerLevel.Size = new System.Drawing.Size(67, 24);
            this.cbAwakenerLevel.TabIndex = 7;
            // 
            // chkBoxCompletado
            // 
            this.chkBoxCompletado.AutoSize = true;
            this.chkBoxCompletado.Location = new System.Drawing.Point(117, 130);
            this.chkBoxCompletado.Name = "chkBoxCompletado";
            this.chkBoxCompletado.Size = new System.Drawing.Size(60, 21);
            this.chkBoxCompletado.TabIndex = 8;
            this.chkBoxCompletado.Text = "NÃO";
            this.chkBoxCompletado.UseVisualStyleBackColor = true;
            // 
            // dgvSirus
            // 
            this.dgvSirus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirus.Location = new System.Drawing.Point(4, 229);
            this.dgvSirus.Name = "dgvSirus";
            this.dgvSirus.RowHeadersWidth = 51;
            this.dgvSirus.RowTemplate.Height = 24;
            this.dgvSirus.Size = new System.Drawing.Size(1081, 499);
            this.dgvSirus.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(23, 172);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FormCadastroSirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 736);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvSirus);
            this.Controls.Add(this.chkBoxCompletado);
            this.Controls.Add(this.cbAwakenerLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "FormCadastroSirus";
            this.Text = "FormCadastroSirus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAwakenerLevel;
        private System.Windows.Forms.CheckBox chkBoxCompletado;
        private System.Windows.Forms.DataGridView dgvSirus;
        private System.Windows.Forms.Button btnInserir;
    }
}