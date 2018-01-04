namespace Xml_Parse_Islemi
{
    partial class ParseIslemi
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
            this.btn_gozat = new System.Windows.Forms.Button();
            this.btn_menuyedon = new System.Windows.Forms.Button();
            this.lbl_dosyasec = new System.Windows.Forms.Label();
            this.txt_sayfaninyeri = new System.Windows.Forms.TextBox();
            this.dgv_parseedilenigetir = new System.Windows.Forms.DataGridView();
            this.btn_raporla = new System.Windows.Forms.Button();
            this.btn_parseet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parseedilenigetir)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gozat
            // 
            this.btn_gozat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gozat.Location = new System.Drawing.Point(439, 58);
            this.btn_gozat.Name = "btn_gozat";
            this.btn_gozat.Size = new System.Drawing.Size(137, 26);
            this.btn_gozat.TabIndex = 0;
            this.btn_gozat.Text = "Gözat";
            this.btn_gozat.UseVisualStyleBackColor = true;
            this.btn_gozat.Click += new System.EventHandler(this.btn_gozat_Click);
            // 
            // btn_menuyedon
            // 
            this.btn_menuyedon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuyedon.Location = new System.Drawing.Point(382, 384);
            this.btn_menuyedon.Name = "btn_menuyedon";
            this.btn_menuyedon.Size = new System.Drawing.Size(179, 36);
            this.btn_menuyedon.TabIndex = 1;
            this.btn_menuyedon.Text = "Menüye Dön";
            this.btn_menuyedon.UseVisualStyleBackColor = true;
            this.btn_menuyedon.Click += new System.EventHandler(this.btn_menuyedon_Click);
            // 
            // lbl_dosyasec
            // 
            this.lbl_dosyasec.AutoSize = true;
            this.lbl_dosyasec.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dosyasec.Location = new System.Drawing.Point(25, 66);
            this.lbl_dosyasec.Name = "lbl_dosyasec";
            this.lbl_dosyasec.Size = new System.Drawing.Size(84, 18);
            this.lbl_dosyasec.TabIndex = 2;
            this.lbl_dosyasec.Text = "Dosyayı Seç:";
            // 
            // txt_sayfaninyeri
            // 
            this.txt_sayfaninyeri.Location = new System.Drawing.Point(115, 58);
            this.txt_sayfaninyeri.Multiline = true;
            this.txt_sayfaninyeri.Name = "txt_sayfaninyeri";
            this.txt_sayfaninyeri.Size = new System.Drawing.Size(306, 26);
            this.txt_sayfaninyeri.TabIndex = 3;
            // 
            // dgv_parseedilenigetir
            // 
            this.dgv_parseedilenigetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parseedilenigetir.Location = new System.Drawing.Point(12, 103);
            this.dgv_parseedilenigetir.Name = "dgv_parseedilenigetir";
            this.dgv_parseedilenigetir.Size = new System.Drawing.Size(564, 264);
            this.dgv_parseedilenigetir.TabIndex = 4;
           
            this.dgv_parseedilenigetir.SelectionChanged += new System.EventHandler(this.dgv_parseedilenigetir_SelectionChanged);
            // 
            // btn_raporla
            // 
            this.btn_raporla.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporla.Location = new System.Drawing.Point(197, 384);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(179, 36);
            this.btn_raporla.TabIndex = 5;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.UseVisualStyleBackColor = true;
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // btn_parseet
            // 
            this.btn_parseet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_parseet.Location = new System.Drawing.Point(12, 384);
            this.btn_parseet.Name = "btn_parseet";
            this.btn_parseet.Size = new System.Drawing.Size(179, 36);
            this.btn_parseet.TabIndex = 6;
            this.btn_parseet.Text = "Parse Et";
            this.btn_parseet.UseVisualStyleBackColor = true;
            this.btn_parseet.Click += new System.EventHandler(this.btn_parseet_Click);
            // 
            // ParseIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 432);
            this.Controls.Add(this.btn_parseet);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.dgv_parseedilenigetir);
            this.Controls.Add(this.txt_sayfaninyeri);
            this.Controls.Add(this.lbl_dosyasec);
            this.Controls.Add(this.btn_menuyedon);
            this.Controls.Add(this.btn_gozat);
            this.Name = "ParseIslemi";
            this.Text = "ParseIslemi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parseedilenigetir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gozat;
        private System.Windows.Forms.Button btn_menuyedon;
        private System.Windows.Forms.Label lbl_dosyasec;
        private System.Windows.Forms.TextBox txt_sayfaninyeri;
        private System.Windows.Forms.DataGridView dgv_parseedilenigetir;
        private System.Windows.Forms.Button btn_raporla;
        private System.Windows.Forms.Button btn_parseet;
    }
}