namespace Xml_Parse_Islemi
{
    partial class Menu
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
            this.btn_parseet = new System.Windows.Forms.Button();
            this.btn_parseraporla = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_parseet
            // 
            this.btn_parseet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_parseet.Location = new System.Drawing.Point(66, 113);
            this.btn_parseet.Name = "btn_parseet";
            this.btn_parseet.Size = new System.Drawing.Size(202, 44);
            this.btn_parseet.TabIndex = 0;
            this.btn_parseet.Text = "XML Dosyayı Parse Et";
            this.btn_parseet.UseVisualStyleBackColor = true;
            this.btn_parseet.Click += new System.EventHandler(this.btn_parseet_Click);
            // 
            // btn_parseraporla
            // 
            this.btn_parseraporla.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parseraporla.Location = new System.Drawing.Point(66, 180);
            this.btn_parseraporla.Name = "btn_parseraporla";
            this.btn_parseraporla.Size = new System.Drawing.Size(202, 44);
            this.btn_parseraporla.TabIndex = 1;
            this.btn_parseraporla.Text = "Parse Edilen Dosyayı Raporla";
            this.btn_parseraporla.UseVisualStyleBackColor = true;
            this.btn_parseraporla.Click += new System.EventHandler(this.btn_parseraporla_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(66, 250);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(202, 43);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btn_cikis;
            this.ClientSize = new System.Drawing.Size(327, 475);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_parseraporla);
            this.Controls.Add(this.btn_parseet);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_parseet;
        private System.Windows.Forms.Button btn_parseraporla;
        private System.Windows.Forms.Button btn_cikis;
    }
}