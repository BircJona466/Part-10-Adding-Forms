namespace Part_10_Adding_Forms
{
    partial class AddingForms
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 12);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(135, 40);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(12, 104);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(135, 40);
            this.btnRemoveName.TabIndex = 1;
            this.btnRemoveName.Text = "Remove Name";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Location = new System.Drawing.Point(12, 58);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(135, 40);
            this.btnEditName.TabIndex = 2;
            this.btnEditName.Text = "Edit Name";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 214);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 40);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(163, 16);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(189, 238);
            this.lstNames.TabIndex = 4;
            // 
            // AddingForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 269);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnAddName);
            this.Name = "AddingForms";
            this.Text = "Adding Forms";
            this.Load += new System.EventHandler(this.AddingForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lstNames;
    }
}

