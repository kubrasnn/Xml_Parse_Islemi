namespace Xml_Parse_Islemi
{
    partial class Xml_Detay
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
            this.dgv_XmlDetay = new System.Windows.Forms.DataGridView();
            this.btn_raporla2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XmlDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_XmlDetay
            // 
            this.dgv_XmlDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XmlDetay.Location = new System.Drawing.Point(23, 25);
            this.dgv_XmlDetay.Name = "dgv_XmlDetay";
            this.dgv_XmlDetay.Size = new System.Drawing.Size(501, 200);
            this.dgv_XmlDetay.TabIndex = 0;
            // 
            // btn_raporla2
            // 
            this.btn_raporla2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporla2.Location = new System.Drawing.Point(183, 233);
            this.btn_raporla2.Name = "btn_raporla2";
            this.btn_raporla2.Size = new System.Drawing.Size(179, 36);
            this.btn_raporla2.TabIndex = 7;
            this.btn_raporla2.Text = "Raporla";
            this.btn_raporla2.UseVisualStyleBackColor = true;
            this.btn_raporla2.Click += new System.EventHandler(this.btn_raporla2_Click);
            // 
            // Xml_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 281);
            this.Controls.Add(this.btn_raporla2);
            this.Controls.Add(this.dgv_XmlDetay);
            this.Name = "Xml_Detay";
            this.Text = "Xml_Detay";
            this.Load += new System.EventHandler(this.Xml_Detay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XmlDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_XmlDetay;
        private System.Windows.Forms.Button btn_raporla2;
    }
}