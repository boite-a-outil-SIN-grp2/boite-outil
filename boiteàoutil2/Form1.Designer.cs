namespace boiteàoutil2
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
            this.Convertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecBox = new System.Windows.Forms.TextBox();
            this.BinBox = new System.Windows.Forms.TextBox();
            this.HexBox = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(704, 75);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(75, 23);
            this.Convertir.TabIndex = 0;
            this.Convertir.Text = "Valider";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Décimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Binaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hexadécimal";
            // 
            // DecBox
            // 
            this.DecBox.Location = new System.Drawing.Point(22, 48);
            this.DecBox.Name = "DecBox";
            this.DecBox.Size = new System.Drawing.Size(171, 22);
            this.DecBox.TabIndex = 4;
            // 
            // BinBox
            // 
            this.BinBox.Location = new System.Drawing.Point(199, 48);
            this.BinBox.Name = "BinBox";
            this.BinBox.Size = new System.Drawing.Size(226, 22);
            this.BinBox.TabIndex = 5;
            // 
            // HexBox
            // 
            this.HexBox.Location = new System.Drawing.Point(431, 48);
            this.HexBox.Name = "HexBox";
            this.HexBox.Size = new System.Drawing.Size(205, 22);
            this.HexBox.TabIndex = 6;
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(658, 124);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(121, 58);
            this.Res.TabIndex = 7;
            this.Res.Text = "Réinitialiser";
            this.Res.UseVisualStyleBackColor = true;
            this.Res.Click += new System.EventHandler(this.Res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.HexBox);
            this.Controls.Add(this.BinBox);
            this.Controls.Add(this.DecBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DecBox;
        private System.Windows.Forms.TextBox BinBox;
        private System.Windows.Forms.TextBox HexBox;
        private System.Windows.Forms.Button Res;
    }
}

