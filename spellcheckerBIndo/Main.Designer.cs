namespace spellcheckerBIndo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textInput = new System.Windows.Forms.RichTextBox();
            this.textHasil = new System.Windows.Forms.RichTextBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonSunting = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(32, 50);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(417, 171);
            this.textInput.TabIndex = 2;
            this.textInput.Text = "";
            // 
            // textHasil
            // 
            this.textHasil.Location = new System.Drawing.Point(32, 260);
            this.textHasil.Name = "textHasil";
            this.textHasil.Size = new System.Drawing.Size(417, 171);
            this.textHasil.TabIndex = 3;
            this.textHasil.Text = "";
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(480, 42);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(75, 23);
            this.buttonCek.TabIndex = 4;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonSunting
            // 
            this.buttonSunting.Location = new System.Drawing.Point(471, 408);
            this.buttonSunting.Name = "buttonSunting";
            this.buttonSunting.Size = new System.Drawing.Size(96, 23);
            this.buttonSunting.TabIndex = 5;
            this.buttonSunting.Text = "Sunting Kamus";
            this.buttonSunting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonSunting.UseVisualStyleBackColor = true;
            this.buttonSunting.Click += new System.EventHandler(this.buttonSunting_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(480, 84);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Masukkan Teks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kesalahan : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSunting);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.textHasil);
            this.Controls.Add(this.textInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "DETEKTAF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox textInput;
        private System.Windows.Forms.RichTextBox textHasil;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonSunting;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

