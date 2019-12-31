namespace spellcheckerBIndo
{
    partial class Kamus
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
            this.textKamus = new System.Windows.Forms.RichTextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textKamus
            // 
            this.textKamus.Location = new System.Drawing.Point(12, 12);
            this.textKamus.Name = "textKamus";
            this.textKamus.Size = new System.Drawing.Size(252, 311);
            this.textKamus.TabIndex = 0;
            this.textKamus.Text = "";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(285, 12);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(285, 50);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 2;
            this.buttonDefault.Text = "Set Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(285, 300);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(75, 23);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // Kamus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 336);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textKamus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kamus";
            this.Text = "Kamus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textKamus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonKembali;
    }
}