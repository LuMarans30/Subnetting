﻿namespace Subnetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIP = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnInserisci = new MaterialSkin.Controls.MaterialButton();
            this.btnCalcola = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipRete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadcast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnhost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIP.Location = new System.Drawing.Point(12, 15);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 17);
            this.lblIP.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 113);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Num. host:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(6, 78);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Ip di partenza:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(266, 78);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(15, 20);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "/";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(100, 78);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 20);
            this.txtIP.TabIndex = 4;
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(287, 78);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(44, 20);
            this.txtMask.TabIndex = 5;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(100, 113);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(60, 20);
            this.txtHost.TabIndex = 6;
            // 
            // btnInserisci
            // 
            this.btnInserisci.AutoSize = false;
            this.btnInserisci.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserisci.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInserisci.Depth = 0;
            this.btnInserisci.HighEmphasis = true;
            this.btnInserisci.Icon = null;
            this.btnInserisci.Location = new System.Drawing.Point(173, 113);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserisci.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInserisci.Size = new System.Drawing.Size(158, 20);
            this.btnInserisci.TabIndex = 7;
            this.btnInserisci.Text = "nuova sottorete";
            this.btnInserisci.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInserisci.UseAccentColor = false;
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnCalcola
            // 
            this.btnCalcola.AutoSize = false;
            this.btnCalcola.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcola.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalcola.Depth = 0;
            this.btnCalcola.HighEmphasis = true;
            this.btnCalcola.Icon = null;
            this.btnCalcola.Location = new System.Drawing.Point(6, 447);
            this.btnCalcola.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcola.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalcola.Size = new System.Drawing.Size(1042, 46);
            this.btnCalcola.TabIndex = 9;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalcola.UseAccentColor = false;
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classe,
            this.ipRete,
            this.mask,
            this.broadcast,
            this.range,
            this.nhost,
            this.rnhost,
            this.spreco});
            this.dataGridView1.Location = new System.Drawing.Point(6, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 286);
            this.dataGridView1.TabIndex = 24;
            // 
            // classe
            // 
            this.classe.HeaderText = "Classe";
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            // 
            // ipRete
            // 
            this.ipRete.HeaderText = "Ip di rete";
            this.ipRete.Name = "ipRete";
            this.ipRete.ReadOnly = true;
            // 
            // mask
            // 
            this.mask.HeaderText = "Net mask";
            this.mask.Name = "mask";
            this.mask.ReadOnly = true;
            // 
            // broadcast
            // 
            this.broadcast.HeaderText = "Broadcast";
            this.broadcast.Name = "broadcast";
            this.broadcast.ReadOnly = true;
            // 
            // range
            // 
            this.range.HeaderText = "Range";
            this.range.Name = "range";
            this.range.ReadOnly = true;
            this.range.Width = 300;
            // 
            // nhost
            // 
            this.nhost.HeaderText = "Num. host";
            this.nhost.Name = "nhost";
            this.nhost.ReadOnly = true;
            // 
            // rnhost
            // 
            this.rnhost.HeaderText = "Num. host reale";
            this.rnhost.Name = "rnhost";
            this.rnhost.ReadOnly = true;
            // 
            // spreco
            // 
            this.spreco.HeaderText = "Spreco";
            this.spreco.Name = "spreco";
            this.spreco.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Subnetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.TextBox txtHost;
        private MaterialSkin.Controls.MaterialButton btnInserisci;
        private MaterialSkin.Controls.MaterialButton btnCalcola;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipRete;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadcast;
        private System.Windows.Forms.DataGridViewTextBoxColumn range;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhost;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnhost;
        private System.Windows.Forms.DataGridViewTextBoxColumn spreco;
    }
}

