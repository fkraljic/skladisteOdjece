﻿namespace skladisteOdjece
{
    partial class DostupneVelicineOdjece
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
            this.dataGridViewOdjeca = new System.Windows.Forms.DataGridView();
            this.dataGridViewVelicine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.dataGridViewVelicineOdjece = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdjeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicineOdjece)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOdjeca
            // 
            this.dataGridViewOdjeca.AllowUserToAddRows = false;
            this.dataGridViewOdjeca.AllowUserToDeleteRows = false;
            this.dataGridViewOdjeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdjeca.Location = new System.Drawing.Point(591, 43);
            this.dataGridViewOdjeca.MultiSelect = false;
            this.dataGridViewOdjeca.Name = "dataGridViewOdjeca";
            this.dataGridViewOdjeca.ReadOnly = true;
            this.dataGridViewOdjeca.RowTemplate.Height = 24;
            this.dataGridViewOdjeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdjeca.Size = new System.Drawing.Size(786, 501);
            this.dataGridViewOdjeca.TabIndex = 0;
            this.dataGridViewOdjeca.SelectionChanged += new System.EventHandler(this.dataGridViewOdjeca_SelectionChanged);
            // 
            // dataGridViewVelicine
            // 
            this.dataGridViewVelicine.AllowUserToAddRows = false;
            this.dataGridViewVelicine.AllowUserToDeleteRows = false;
            this.dataGridViewVelicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelicine.Location = new System.Drawing.Point(126, 43);
            this.dataGridViewVelicine.MultiSelect = false;
            this.dataGridViewVelicine.Name = "dataGridViewVelicine";
            this.dataGridViewVelicine.ReadOnly = true;
            this.dataGridViewVelicine.RowTemplate.Height = 24;
            this.dataGridViewVelicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVelicine.Size = new System.Drawing.Size(459, 501);
            this.dataGridViewVelicine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veličine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asortiman";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 43);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(108, 501);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // dataGridViewVelicineOdjece
            // 
            this.dataGridViewVelicineOdjece.AllowUserToAddRows = false;
            this.dataGridViewVelicineOdjece.AllowUserToDeleteRows = false;
            this.dataGridViewVelicineOdjece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVelicineOdjece.Location = new System.Drawing.Point(591, 550);
            this.dataGridViewVelicineOdjece.MultiSelect = false;
            this.dataGridViewVelicineOdjece.Name = "dataGridViewVelicineOdjece";
            this.dataGridViewVelicineOdjece.ReadOnly = true;
            this.dataGridViewVelicineOdjece.RowTemplate.Height = 24;
            this.dataGridViewVelicineOdjece.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVelicineOdjece.Size = new System.Drawing.Size(786, 213);
            this.dataGridViewVelicineOdjece.TabIndex = 5;
            // 
            // DostupneVelicineOdjece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 775);
            this.Controls.Add(this.dataGridViewVelicineOdjece);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVelicine);
            this.Controls.Add(this.dataGridViewOdjeca);
            this.Name = "DostupneVelicineOdjece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DostupneVelicineOdjece";
            this.Load += new System.EventHandler(this.DostupneVelicineOdjece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdjeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVelicineOdjece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOdjeca;
        private System.Windows.Forms.DataGridView dataGridViewVelicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridView dataGridViewVelicineOdjece;
    }
}