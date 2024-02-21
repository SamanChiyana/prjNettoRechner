namespace pjNettoRechner
{
    partial class frmHaupt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrutto = new System.Windows.Forms.Label();
            this.lblSteuer = new System.Windows.Forms.Label();
            this.lblNetto = new System.Windows.Forms.Label();
            this.txtBrutto = new System.Windows.Forms.TextBox();
            this.txtSteuer = new System.Windows.Forms.TextBox();
            this.txtNetto = new System.Windows.Forms.TextBox();
            this.btoBerechnen = new System.Windows.Forms.Button();
            this.btoNeueBerechnung = new System.Windows.Forms.Button();
            this.btoProgrammEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrutto.Location = new System.Drawing.Point(34, 25);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(53, 20);
            this.lblBrutto.TabIndex = 0;
            this.lblBrutto.Text = "Brutto";
            // 
            // lblSteuer
            // 
            this.lblSteuer.AutoSize = true;
            this.lblSteuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteuer.Location = new System.Drawing.Point(34, 56);
            this.lblSteuer.Name = "lblSteuer";
            this.lblSteuer.Size = new System.Drawing.Size(57, 20);
            this.lblSteuer.TabIndex = 0;
            this.lblSteuer.Text = "Steuer";
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetto.Location = new System.Drawing.Point(34, 89);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(48, 20);
            this.lblNetto.TabIndex = 0;
            this.lblNetto.Text = "Netto";
            // 
            // txtBrutto
            // 
            this.txtBrutto.Location = new System.Drawing.Point(120, 24);
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.Size = new System.Drawing.Size(100, 20);
            this.txtBrutto.TabIndex = 0;
            // 
            // txtSteuer
            // 
            this.txtSteuer.Location = new System.Drawing.Point(120, 58);
            this.txtSteuer.Name = "txtSteuer";
            this.txtSteuer.Size = new System.Drawing.Size(100, 20);
            this.txtSteuer.TabIndex = 1;
            // 
            // txtNetto
            // 
            this.txtNetto.Enabled = false;
            this.txtNetto.Location = new System.Drawing.Point(120, 89);
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.Size = new System.Drawing.Size(100, 20);
            this.txtNetto.TabIndex = 2;
            // 
            // btoBerechnen
            // 
            this.btoBerechnen.Location = new System.Drawing.Point(28, 156);
            this.btoBerechnen.Name = "btoBerechnen";
            this.btoBerechnen.Size = new System.Drawing.Size(192, 55);
            this.btoBerechnen.TabIndex = 3;
            this.btoBerechnen.Text = "Berechnen";
            this.btoBerechnen.UseVisualStyleBackColor = true;
            this.btoBerechnen.Click += new System.EventHandler(this.btoBerechnen_Click);
            // 
            // btoNeueBerechnung
            // 
            this.btoNeueBerechnung.Location = new System.Drawing.Point(240, 156);
            this.btoNeueBerechnung.Name = "btoNeueBerechnung";
            this.btoNeueBerechnung.Size = new System.Drawing.Size(192, 55);
            this.btoNeueBerechnung.TabIndex = 4;
            this.btoNeueBerechnung.Text = "Neue Berechnung";
            this.btoNeueBerechnung.UseVisualStyleBackColor = true;
            this.btoNeueBerechnung.Click += new System.EventHandler(this.btoNeueBerechnung_Click);
            // 
            // btoProgrammEnde
            // 
            this.btoProgrammEnde.Location = new System.Drawing.Point(451, 156);
            this.btoProgrammEnde.Name = "btoProgrammEnde";
            this.btoProgrammEnde.Size = new System.Drawing.Size(192, 55);
            this.btoProgrammEnde.TabIndex = 5;
            this.btoProgrammEnde.Text = "Programm Ende";
            this.btoProgrammEnde.UseVisualStyleBackColor = true;
            this.btoProgrammEnde.Click += new System.EventHandler(this.btoProgrammEnde_Click);
            // 
            // frmHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btoProgrammEnde);
            this.Controls.Add(this.btoNeueBerechnung);
            this.Controls.Add(this.btoBerechnen);
            this.Controls.Add(this.txtNetto);
            this.Controls.Add(this.txtSteuer);
            this.Controls.Add(this.txtBrutto);
            this.Controls.Add(this.lblNetto);
            this.Controls.Add(this.lblSteuer);
            this.Controls.Add(this.lblBrutto);
            this.Name = "frmHaupt";
            this.Text = "Netto Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrutto;
        private System.Windows.Forms.Label lblSteuer;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.TextBox txtBrutto;
        private System.Windows.Forms.TextBox txtSteuer;
        private System.Windows.Forms.TextBox txtNetto;
        private System.Windows.Forms.Button btoBerechnen;
        private System.Windows.Forms.Button btoNeueBerechnung;
        private System.Windows.Forms.Button btoProgrammEnde;
    }
}

