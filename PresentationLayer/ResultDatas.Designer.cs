namespace PresentationLayer
{
    partial class ResultDatas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listItem1 = new PresentationLayer.ListItem();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listItem1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 751);
            this.panel2.TabIndex = 3;
            // 
            // listItem1
            // 
            this.listItem1.AwakenerLevel = null;
            this.listItem1.BackColor = System.Drawing.Color.Azure;
            this.listItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listItem1.DataFeito = new System.DateTime(((long)(0)));
            this.listItem1.Drop1 = null;
            this.listItem1.Drop2 = null;
            this.listItem1.Location = new System.Drawing.Point(56, 103);
            this.listItem1.Name = "listItem1";
            this.listItem1.NomeSirus = null;
            this.listItem1.Size = new System.Drawing.Size(1067, 212);
            this.listItem1.TabIndex = 0;
            // 
            // ResultDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 751);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultDatas";
            this.Text = "ResultDatas";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private ListItem listItem1;
    }
}