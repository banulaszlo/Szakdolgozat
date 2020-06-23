namespace test1
{
    partial class belep_form
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
            this.diak_btn = new System.Windows.Forms.Button();
            this.tanar_btn = new System.Windows.Forms.Button();
            this.valassz_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diak_btn
            // 
            this.diak_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diak_btn.Location = new System.Drawing.Point(276, 123);
            this.diak_btn.Name = "diak_btn";
            this.diak_btn.Size = new System.Drawing.Size(185, 65);
            this.diak_btn.TabIndex = 0;
            this.diak_btn.Text = "Diák vagyok";
            this.diak_btn.UseVisualStyleBackColor = true;
            this.diak_btn.Click += new System.EventHandler(this.diak_btn_Click);
            // 
            // tanar_btn
            // 
            this.tanar_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tanar_btn.Location = new System.Drawing.Point(276, 236);
            this.tanar_btn.Name = "tanar_btn";
            this.tanar_btn.Size = new System.Drawing.Size(185, 65);
            this.tanar_btn.TabIndex = 1;
            this.tanar_btn.Text = "Tanár vagyok";
            this.tanar_btn.UseVisualStyleBackColor = true;
            this.tanar_btn.Click += new System.EventHandler(this.tanar_btn_Click);
            // 
            // valassz_label
            // 
            this.valassz_label.AutoSize = true;
            this.valassz_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valassz_label.Location = new System.Drawing.Point(292, 50);
            this.valassz_label.Name = "valassz_label";
            this.valassz_label.Size = new System.Drawing.Size(151, 24);
            this.valassz_label.TabIndex = 2;
            this.valassz_label.Text = "Kérlek válassz!";
            // 
            // belep_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.valassz_label);
            this.Controls.Add(this.tanar_btn);
            this.Controls.Add(this.diak_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "belep_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oktatóprogram teszt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button diak_btn;
        private System.Windows.Forms.Button tanar_btn;
        private System.Windows.Forms.Label valassz_label;
    }
}

