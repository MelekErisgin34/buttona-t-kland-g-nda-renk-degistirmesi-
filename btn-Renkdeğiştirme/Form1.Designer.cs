namespace btn_Renkdeğiştirme
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirmizi.Location = new System.Drawing.Point(153, 88);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(114, 57);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "Kırmızı";
            this.btnKirmizi.UseVisualStyleBackColor = true;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMavi.Location = new System.Drawing.Point(274, 87);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(114, 57);
            this.btnMavi.TabIndex = 1;
            this.btnMavi.Text = "Mavi";
            this.btnMavi.UseVisualStyleBackColor = true;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 403);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnKirmizi);
            this.Name = "Form1";
            this.Text = "Button Renk Degiştirme Programı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnMavi;
    }
}

