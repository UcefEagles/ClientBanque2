namespace ClientBanque2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConversion = new System.Windows.Forms.Button();
            this.BtnCpt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1MT = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.Label();
            this.textBox1Res = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConversion
            // 
            this.BtnConversion.Location = new System.Drawing.Point(309, 70);
            this.BtnConversion.Name = "BtnConversion";
            this.BtnConversion.Size = new System.Drawing.Size(75, 23);
            this.BtnConversion.TabIndex = 0;
            this.BtnConversion.Text = "Conversion";
            this.BtnConversion.UseVisualStyleBackColor = true;
            this.BtnConversion.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCpt
            // 
            this.BtnCpt.Location = new System.Drawing.Point(416, 70);
            this.BtnCpt.Name = "BtnCpt";
            this.BtnCpt.Size = new System.Drawing.Size(75, 23);
            this.BtnCpt.TabIndex = 1;
            this.BtnCpt.Text = "Comptes";
            this.BtnCpt.UseVisualStyleBackColor = true;
            this.BtnCpt.Click += new System.EventHandler(this.BtnCpt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montant:";
            // 
            // textBox1MT
            // 
            this.textBox1MT.Location = new System.Drawing.Point(128, 72);
            this.textBox1MT.Name = "textBox1MT";
            this.textBox1MT.Size = new System.Drawing.Size(163, 20);
            this.textBox1MT.TabIndex = 3;
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Location = new System.Drawing.Point(71, 133);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(49, 13);
            this.Res.TabIndex = 4;
            this.Res.Text = "Resultat:";
            // 
            // textBox1Res
            // 
            this.textBox1Res.Location = new System.Drawing.Point(128, 130);
            this.textBox1Res.Name = "textBox1Res";
            this.textBox1Res.Size = new System.Drawing.Size(163, 20);
            this.textBox1Res.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(271, 119);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1Res);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.textBox1MT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCpt);
            this.Controls.Add(this.BtnConversion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConversion;
        private System.Windows.Forms.Button BtnCpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1MT;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.TextBox textBox1Res;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

