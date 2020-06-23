namespace test1
{
    partial class tanar_belep
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
            this.tanar_felhasznev_lbl = new System.Windows.Forms.Label();
            this.tanar_jelszo_lbl = new System.Windows.Forms.Label();
            this.tanar_felhasznev_txtbox = new System.Windows.Forms.TextBox();
            this.tanar_jelszo_txtbox = new System.Windows.Forms.TextBox();
            this.tanar_belep_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tanar_felhasznev_lbl
            // 
            this.tanar_felhasznev_lbl.AutoSize = true;
            this.tanar_felhasznev_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tanar_felhasznev_lbl.Location = new System.Drawing.Point(13, 13);
            this.tanar_felhasznev_lbl.Name = "tanar_felhasznev_lbl";
            this.tanar_felhasznev_lbl.Size = new System.Drawing.Size(101, 16);
            this.tanar_felhasznev_lbl.TabIndex = 0;
            this.tanar_felhasznev_lbl.Text = "Felhasználónév:";
            // 
            // tanar_jelszo_lbl
            // 
            this.tanar_jelszo_lbl.AutoSize = true;
            this.tanar_jelszo_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tanar_jelszo_lbl.Location = new System.Drawing.Point(13, 55);
            this.tanar_jelszo_lbl.Name = "tanar_jelszo_lbl";
            this.tanar_jelszo_lbl.Size = new System.Drawing.Size(49, 16);
            this.tanar_jelszo_lbl.TabIndex = 1;
            this.tanar_jelszo_lbl.Text = "Jelszó:";
            // 
            // tanar_felhasznev_txtbox
            // 
            this.tanar_felhasznev_txtbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tanar_felhasznev_txtbox.Location = new System.Drawing.Point(154, 10);
            this.tanar_felhasznev_txtbox.Name = "tanar_felhasznev_txtbox";
            this.tanar_felhasznev_txtbox.Size = new System.Drawing.Size(168, 22);
            this.tanar_felhasznev_txtbox.TabIndex = 2;
            // 
            // tanar_jelszo_txtbox
            // 
            this.tanar_jelszo_txtbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tanar_jelszo_txtbox.Location = new System.Drawing.Point(154, 55);
            this.tanar_jelszo_txtbox.Name = "tanar_jelszo_txtbox";
            this.tanar_jelszo_txtbox.Size = new System.Drawing.Size(168, 22);
            this.tanar_jelszo_txtbox.TabIndex = 3;
            // 
            // tanar_belep_btn
            // 
            this.tanar_belep_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tanar_belep_btn.Location = new System.Drawing.Point(124, 102);
            this.tanar_belep_btn.Name = "tanar_belep_btn";
            this.tanar_belep_btn.Size = new System.Drawing.Size(104, 32);
            this.tanar_belep_btn.TabIndex = 4;
            this.tanar_belep_btn.Text = "Bejelentkezés";
            this.tanar_belep_btn.UseVisualStyleBackColor = true;
            this.tanar_belep_btn.Click += new System.EventHandler(this.tanar_belep_btn_Click);
            // 
            // tanar_belep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.tanar_belep_btn);
            this.Controls.Add(this.tanar_jelszo_txtbox);
            this.Controls.Add(this.tanar_felhasznev_txtbox);
            this.Controls.Add(this.tanar_jelszo_lbl);
            this.Controls.Add(this.tanar_felhasznev_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "tanar_belep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tanar_felhasznev_lbl;
        private System.Windows.Forms.Label tanar_jelszo_lbl;
        private System.Windows.Forms.TextBox tanar_felhasznev_txtbox;
        private System.Windows.Forms.TextBox tanar_jelszo_txtbox;
        private System.Windows.Forms.Button tanar_belep_btn;
    }
}