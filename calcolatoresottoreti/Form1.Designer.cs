namespace calcolatoresottoreti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeroHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroSottoreti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtClasseIndirizzo = new System.Windows.Forms.TextBox();
            this.txtIndirizzoBase = new System.Windows.Forms.TextBox();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.txtCDIR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeroHost
            // 
            this.numeroHost.Location = new System.Drawing.Point(38, 51);
            this.numeroHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroHost.Name = "numeroHost";
            this.numeroHost.Size = new System.Drawing.Size(207, 22);
            this.numeroHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserire numero di host";
            // 
            // numeroSottoreti
            // 
            this.numeroSottoreti.Location = new System.Drawing.Point(38, 135);
            this.numeroSottoreti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroSottoreti.Name = "numeroSottoreti";
            this.numeroSottoreti.Size = new System.Drawing.Size(207, 22);
            this.numeroSottoreti.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserire numero di sottoreti";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(317, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 128);
            this.button1.TabIndex = 4;
            this.button1.Text = "calcola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(584, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(470, 452);
            this.listBox1.TabIndex = 5;
            // 
            // txtClasseIndirizzo
            // 
            this.txtClasseIndirizzo.Location = new System.Drawing.Point(38, 219);
            this.txtClasseIndirizzo.Name = "txtClasseIndirizzo";
            this.txtClasseIndirizzo.Size = new System.Drawing.Size(207, 22);
            this.txtClasseIndirizzo.TabIndex = 6;
            // 
            // txtIndirizzoBase
            // 
            this.txtIndirizzoBase.Location = new System.Drawing.Point(38, 306);
            this.txtIndirizzoBase.Name = "txtIndirizzoBase";
            this.txtIndirizzoBase.Size = new System.Drawing.Size(207, 22);
            this.txtIndirizzoBase.TabIndex = 7;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(38, 390);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(207, 22);
            this.txtSubnetMask.TabIndex = 8;
            // 
            // txtCDIR
            // 
            this.txtCDIR.Location = new System.Drawing.Point(38, 493);
            this.txtCDIR.Name = "txtCDIR";
            this.txtCDIR.Size = new System.Drawing.Size(207, 22);
            this.txtCDIR.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(81, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "classe indirizzo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(81, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indirizzo base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(87, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subnet Mask:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(114, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "CIDR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCDIR);
            this.Controls.Add(this.txtSubnetMask);
            this.Controls.Add(this.txtIndirizzoBase);
            this.Controls.Add(this.txtClasseIndirizzo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroSottoreti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroHost);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeroHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroSottoreti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtClasseIndirizzo;
        private System.Windows.Forms.TextBox txtIndirizzoBase;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.TextBox txtCDIR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

