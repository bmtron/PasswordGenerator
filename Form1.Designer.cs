namespace PasswordGenerator
{
    partial class Form1
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
            this.accountNameInput = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordDisplay = new System.Windows.Forms.TextBox();
            this.passwordDisplayLabel = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.sizeScale = new System.Windows.Forms.TrackBar();
            this.sizeScaleLabel = new System.Windows.Forms.Label();
            this.sizeScaleMin = new System.Windows.Forms.Label();
            this.slideScaleMax = new System.Windows.Forms.Label();
            this.slideScaleValue = new System.Windows.Forms.Label();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbols = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.openFolderDialogBtn = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeScale)).BeginInit();
            this.SuspendLayout();
            // 
            // accountNameInput
            // 
            this.accountNameInput.Location = new System.Drawing.Point(12, 47);
            this.accountNameInput.Name = "accountNameInput";
            this.accountNameInput.Size = new System.Drawing.Size(198, 20);
            this.accountNameInput.TabIndex = 0;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(13, 28);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(58, 13);
            this.accountLabel.TabIndex = 1;
            this.accountLabel.Text = "Account:";
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(12, 161);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(198, 20);
            this.loginInput.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(12, 142);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(42, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login:";
            // 
            // passwordDisplay
            // 
            this.passwordDisplay.Location = new System.Drawing.Point(249, 302);
            this.passwordDisplay.Name = "passwordDisplay";
            this.passwordDisplay.Size = new System.Drawing.Size(282, 20);
            this.passwordDisplay.TabIndex = 4;
            // 
            // passwordDisplayLabel
            // 
            this.passwordDisplayLabel.AutoSize = true;
            this.passwordDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordDisplayLabel.Location = new System.Drawing.Point(249, 283);
            this.passwordDisplayLabel.Name = "passwordDisplayLabel";
            this.passwordDisplayLabel.Size = new System.Drawing.Size(65, 13);
            this.passwordDisplayLabel.TabIndex = 5;
            this.passwordDisplayLabel.Text = "Password:";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.Location = new System.Drawing.Point(309, 364);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(148, 23);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // sizeScale
            // 
            this.sizeScale.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sizeScale.Location = new System.Drawing.Point(252, 199);
            this.sizeScale.Maximum = 72;
            this.sizeScale.Minimum = 8;
            this.sizeScale.Name = "sizeScale";
            this.sizeScale.Size = new System.Drawing.Size(253, 45);
            this.sizeScale.TabIndex = 7;
            this.sizeScale.Value = 8;
            this.sizeScale.Scroll += new System.EventHandler(this.sizeScale_Scroll);
            // 
            // sizeScaleLabel
            // 
            this.sizeScaleLabel.AutoSize = true;
            this.sizeScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeScaleLabel.Location = new System.Drawing.Point(264, 168);
            this.sizeScaleLabel.Name = "sizeScaleLabel";
            this.sizeScaleLabel.Size = new System.Drawing.Size(115, 13);
            this.sizeScaleLabel.TabIndex = 8;
            this.sizeScaleLabel.Text = "Requested Length:";
            this.sizeScaleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sizeScaleMin
            // 
            this.sizeScaleMin.AutoSize = true;
            this.sizeScaleMin.Location = new System.Drawing.Point(252, 230);
            this.sizeScaleMin.Name = "sizeScaleMin";
            this.sizeScaleMin.Size = new System.Drawing.Size(0, 13);
            this.sizeScaleMin.TabIndex = 9;
            // 
            // slideScaleMax
            // 
            this.slideScaleMax.AutoSize = true;
            this.slideScaleMax.Location = new System.Drawing.Point(490, 230);
            this.slideScaleMax.Name = "slideScaleMax";
            this.slideScaleMax.Size = new System.Drawing.Size(0, 13);
            this.slideScaleMax.TabIndex = 10;
            // 
            // slideScaleValue
            // 
            this.slideScaleValue.AutoSize = true;
            this.slideScaleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideScaleValue.Location = new System.Drawing.Point(385, 168);
            this.slideScaleValue.Name = "slideScaleValue";
            this.slideScaleValue.Size = new System.Drawing.Size(0, 13);
            this.slideScaleValue.TabIndex = 11;
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Location = new System.Drawing.Point(550, 200);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(114, 17);
            this.checkBoxNumbers.TabIndex = 12;
            this.checkBoxNumbers.Text = "Numbers Required";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxSymbols
            // 
            this.checkBoxSymbols.AutoSize = true;
            this.checkBoxSymbols.Location = new System.Drawing.Point(550, 223);
            this.checkBoxSymbols.Name = "checkBoxSymbols";
            this.checkBoxSymbols.Size = new System.Drawing.Size(159, 17);
            this.checkBoxSymbols.TabIndex = 13;
            this.checkBoxSymbols.Text = "Symbols/Special Characters";
            this.checkBoxSymbols.UseVisualStyleBackColor = true;
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile.Location = new System.Drawing.Point(339, 412);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(73, 26);
            this.saveFile.TabIndex = 15;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // openFolderDialogBtn
            // 
            this.openFolderDialogBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openFolderDialogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderDialogBtn.Location = new System.Drawing.Point(685, 382);
            this.openFolderDialogBtn.Name = "openFolderDialogBtn";
            this.openFolderDialogBtn.Size = new System.Drawing.Size(77, 43);
            this.openFolderDialogBtn.TabIndex = 16;
            this.openFolderDialogBtn.Text = "Choose Location";
            this.openFolderDialogBtn.UseVisualStyleBackColor = false;
            this.openFolderDialogBtn.Click += new System.EventHandler(this.openFolderDialog_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(533, 382);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(93, 13);
            this.pathLabel.TabIndex = 17;
            this.pathLabel.Text = "Save Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.openFolderDialogBtn);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.checkBoxSymbols);
            this.Controls.Add(this.checkBoxNumbers);
            this.Controls.Add(this.slideScaleValue);
            this.Controls.Add(this.slideScaleMax);
            this.Controls.Add(this.sizeScaleMin);
            this.Controls.Add(this.sizeScaleLabel);
            this.Controls.Add(this.sizeScale);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.passwordDisplayLabel);
            this.Controls.Add(this.passwordDisplay);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.accountNameInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountNameInput;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordDisplay;
        private System.Windows.Forms.Label passwordDisplayLabel;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TrackBar sizeScale;
        private System.Windows.Forms.Label sizeScaleLabel;
        private System.Windows.Forms.Label sizeScaleMin;
        private System.Windows.Forms.Label slideScaleMax;
        private System.Windows.Forms.Label slideScaleValue;
        private System.Windows.Forms.CheckBox checkBoxNumbers;
        private System.Windows.Forms.CheckBox checkBoxSymbols;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button openFolderDialogBtn;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label1;
    }
}

