namespace Caesar_cipher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBSource = new System.Windows.Forms.GroupBox();
            this.rBFile = new System.Windows.Forms.RadioButton();
            this.rBText = new System.Windows.Forms.RadioButton();
            this.gBOperation = new System.Windows.Forms.GroupBox();
            this.rBD = new System.Windows.Forms.RadioButton();
            this.rBE = new System.Windows.Forms.RadioButton();
            this.btngo = new System.Windows.Forms.Button();
            this.gBKey = new System.Windows.Forms.GroupBox();
            this.btndraw = new System.Windows.Forms.Button();
            this.tBKey = new System.Windows.Forms.TextBox();
            this.tBText = new System.Windows.Forms.TextBox();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.gBSource.SuspendLayout();
            this.gBOperation.SuspendLayout();
            this.gBKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSource
            // 
            this.gBSource.Controls.Add(this.rBFile);
            this.gBSource.Controls.Add(this.rBText);
            this.gBSource.Location = new System.Drawing.Point(14, 12);
            this.gBSource.Name = "gBSource";
            this.gBSource.Size = new System.Drawing.Size(63, 77);
            this.gBSource.TabIndex = 0;
            this.gBSource.TabStop = false;
            this.gBSource.Text = "Source";
            // 
            // rBFile
            // 
            this.rBFile.AutoSize = true;
            this.rBFile.Location = new System.Drawing.Point(7, 44);
            this.rBFile.Name = "rBFile";
            this.rBFile.Size = new System.Drawing.Size(41, 17);
            this.rBFile.TabIndex = 1;
            this.rBFile.Text = "File";
            this.rBFile.UseVisualStyleBackColor = true;
            this.rBFile.CheckedChanged += new System.EventHandler(this.SelectSource);
            // 
            // rBText
            // 
            this.rBText.AutoSize = true;
            this.rBText.Checked = true;
            this.rBText.Location = new System.Drawing.Point(7, 20);
            this.rBText.Name = "rBText";
            this.rBText.Size = new System.Drawing.Size(46, 17);
            this.rBText.TabIndex = 0;
            this.rBText.TabStop = true;
            this.rBText.Text = "Text";
            this.rBText.UseVisualStyleBackColor = true;
            this.rBText.CheckedChanged += new System.EventHandler(this.SelectSource);
            // 
            // gBOperation
            // 
            this.gBOperation.Controls.Add(this.rBD);
            this.gBOperation.Controls.Add(this.rBE);
            this.gBOperation.Location = new System.Drawing.Point(83, 12);
            this.gBOperation.Name = "gBOperation";
            this.gBOperation.Size = new System.Drawing.Size(90, 77);
            this.gBOperation.TabIndex = 1;
            this.gBOperation.TabStop = false;
            this.gBOperation.Text = "Operations";
            // 
            // rBD
            // 
            this.rBD.AutoSize = true;
            this.rBD.Location = new System.Drawing.Point(6, 44);
            this.rBD.Name = "rBD";
            this.rBD.Size = new System.Drawing.Size(62, 17);
            this.rBD.TabIndex = 3;
            this.rBD.Text = "Decrypt";
            this.rBD.UseVisualStyleBackColor = true;
            this.rBD.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // rBE
            // 
            this.rBE.AutoSize = true;
            this.rBE.Checked = true;
            this.rBE.Location = new System.Drawing.Point(6, 20);
            this.rBE.Name = "rBE";
            this.rBE.Size = new System.Drawing.Size(61, 17);
            this.rBE.TabIndex = 2;
            this.rBE.TabStop = true;
            this.rBE.Text = "Encrypt";
            this.rBE.UseVisualStyleBackColor = true;
            this.rBE.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(88, 43);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 23);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "Encrypt";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.Btngo_Click);
            // 
            // gBKey
            // 
            this.gBKey.Controls.Add(this.btndraw);
            this.gBKey.Controls.Add(this.btngo);
            this.gBKey.Controls.Add(this.tBKey);
            this.gBKey.Location = new System.Drawing.Point(180, 12);
            this.gBKey.Name = "gBKey";
            this.gBKey.Size = new System.Drawing.Size(185, 77);
            this.gBKey.TabIndex = 2;
            this.gBKey.TabStop = false;
            this.gBKey.Text = "Key";
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(7, 43);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(75, 23);
            this.btndraw.TabIndex = 1;
            this.btndraw.Text = "Draw";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.Btndraw_Click);
            // 
            // tBKey
            // 
            this.tBKey.Location = new System.Drawing.Point(7, 20);
            this.tBKey.Name = "tBKey";
            this.tBKey.Size = new System.Drawing.Size(100, 20);
            this.tBKey.TabIndex = 0;
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(14, 96);
            this.tBText.Multiline = true;
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(278, 200);
            this.tBText.TabIndex = 3;
            // 
            // tBMessage
            // 
            this.tBMessage.Enabled = false;
            this.tBMessage.Location = new System.Drawing.Point(298, 96);
            this.tBMessage.Multiline = true;
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(278, 200);
            this.tBMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 308);
            this.Controls.Add(this.tBMessage);
            this.Controls.Add(this.tBText);
            this.Controls.Add(this.gBKey);
            this.Controls.Add(this.gBOperation);
            this.Controls.Add(this.gBSource);
            this.Name = "Form1";
            this.Text = "Caesar cipher";
            this.gBSource.ResumeLayout(false);
            this.gBSource.PerformLayout();
            this.gBOperation.ResumeLayout(false);
            this.gBOperation.PerformLayout();
            this.gBKey.ResumeLayout(false);
            this.gBKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSource;
        private System.Windows.Forms.RadioButton rBFile;
        private System.Windows.Forms.RadioButton rBText;
        private System.Windows.Forms.GroupBox gBOperation;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.GroupBox gBKey;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.TextBox tBKey;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.TextBox tBMessage;
        private System.Windows.Forms.RadioButton rBD;
        private System.Windows.Forms.RadioButton rBE;
    }
}

