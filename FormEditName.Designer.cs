namespace Part_10_Adding_Forms
{
    partial class FormEditName
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
            this.lblPleaseEdit = new System.Windows.Forms.Label();
            this.lblSelectedName = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblChooseEdit = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPleaseEdit
            // 
            this.lblPleaseEdit.AutoSize = true;
            this.lblPleaseEdit.Location = new System.Drawing.Point(14, 11);
            this.lblPleaseEdit.Name = "lblPleaseEdit";
            this.lblPleaseEdit.Size = new System.Drawing.Size(155, 13);
            this.lblPleaseEdit.TabIndex = 0;
            this.lblPleaseEdit.Text = "Please Edit Your Chosen Name";
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedName.Location = new System.Drawing.Point(163, 72);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(68, 25);
            this.lblSelectedName.TabIndex = 1;
            this.lblSelectedName.Text = "Name";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(108, 134);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(182, 20);
            this.txtEditName.TabIndex = 2;
            // 
            // lblChooseEdit
            // 
            this.lblChooseEdit.AutoSize = true;
            this.lblChooseEdit.Location = new System.Drawing.Point(71, 157);
            this.lblChooseEdit.Name = "lblChooseEdit";
            this.lblChooseEdit.Size = new System.Drawing.Size(261, 13);
            this.lblChooseEdit.TabIndex = 3;
            this.lblChooseEdit.Text = "Please Type How You Would Like To Edit Your Word";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(14, 196);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(184, 50);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEditName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblChooseEdit);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblSelectedName);
            this.Controls.Add(this.lblPleaseEdit);
            this.Name = "FormEditName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEditName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseEdit;
        private System.Windows.Forms.Label lblSelectedName;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblChooseEdit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}