﻿namespace DAHP.Prototype
{
    partial class frmNewDesignation
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
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.btnCancel);
            this.gbSave.Controls.Add(this.btnSave);
            this.gbSave.Controls.Add(this.txtDesignation);
            this.gbSave.Enabled = false;
            this.gbSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSave.Location = new System.Drawing.Point(100, 35);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(457, 219);
            this.gbSave.TabIndex = 1;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "Enter/Modify Designation";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDesignation
            // 
            this.txtDesignation.AllowDrop = true;
            this.txtDesignation.Location = new System.Drawing.Point(80, 74);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(296, 23);
            this.txtDesignation.TabIndex = 3;
            this.txtDesignation.Text = "Enter/ Modify Designation:";
            // 
            // frmNewDesignation
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(652, 314);
            this.Controls.Add(this.gbSave);
            this.Name = "frmNewDesignation";
            this.Text = "frmNewDesignation";
            this.Load += new System.EventHandler(this.frmNewDesignation_Load);
            this.gbSave.ResumeLayout(false);
            this.gbSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDesignation;

    }
}