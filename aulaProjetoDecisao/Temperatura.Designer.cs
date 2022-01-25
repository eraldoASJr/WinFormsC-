namespace aulaProjetoDecisao
{
    partial class Temperatura
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
            this.lblTempCelsius = new System.Windows.Forms.Label();
            this.lblTempFar = new System.Windows.Forms.Label();
            this.txtTempCelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTempCelsius
            // 
            this.lblTempCelsius.AutoSize = true;
            this.lblTempCelsius.Location = new System.Drawing.Point(113, 115);
            this.lblTempCelsius.Name = "lblTempCelsius";
            this.lblTempCelsius.Size = new System.Drawing.Size(289, 33);
            this.lblTempCelsius.TabIndex = 0;
            this.lblTempCelsius.Text = "Temperatura em °C";
            // 
            // lblTempFar
            // 
            this.lblTempFar.AutoSize = true;
            this.lblTempFar.Location = new System.Drawing.Point(408, 179);
            this.lblTempFar.Name = "lblTempFar";
            this.lblTempFar.Size = new System.Drawing.Size(26, 33);
            this.lblTempFar.TabIndex = 1;
            this.lblTempFar.Text = "-";
            // 
            // txtTempCelsius
            // 
            this.txtTempCelsius.Location = new System.Drawing.Point(414, 112);
            this.txtTempCelsius.Name = "txtTempCelsius";
            this.txtTempCelsius.Size = new System.Drawing.Size(155, 40);
            this.txtTempCelsius.TabIndex = 2;
            this.txtTempCelsius.TextChanged += new System.EventHandler(this.txtTempCelsius_TextChanged);
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTempCelsius);
            this.Controls.Add(this.lblTempFar);
            this.Controls.Add(this.lblTempCelsius);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempCelsius;
        private System.Windows.Forms.Label lblTempFar;
        private System.Windows.Forms.TextBox txtTempCelsius;
    }
}