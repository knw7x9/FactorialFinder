namespace FactorialFinder {
    partial class frmFactorialFinder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.trOneToTwenty = new System.Windows.Forms.TrackBar();
            this.lblFactorialsUpTo = new System.Windows.Forms.Label();
            this.lblTrackbarNumber = new System.Windows.Forms.Label();
            this.btnGenerateFactorials = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLongFactorialsDisplay = new System.Windows.Forms.TextBox();
            this.txtLongFactorials = new System.Windows.Forms.TextBox();
            this.txtIntFactorialsDisplay = new System.Windows.Forms.TextBox();
            this.txtIntFactorials = new System.Windows.Forms.TextBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.chkRandomize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trOneToTwenty)).BeginInit();
            this.SuspendLayout();
            // 
            // trOneToTwenty
            // 
            this.trOneToTwenty.Location = new System.Drawing.Point(26, 12);
            this.trOneToTwenty.Maximum = 20;
            this.trOneToTwenty.Minimum = 1;
            this.trOneToTwenty.Name = "trOneToTwenty";
            this.trOneToTwenty.Size = new System.Drawing.Size(881, 45);
            this.trOneToTwenty.TabIndex = 0;
            this.trOneToTwenty.Value = 1;
            this.trOneToTwenty.Scroll += new System.EventHandler(this.trOneToTwenty_Scroll);
            // 
            // lblFactorialsUpTo
            // 
            this.lblFactorialsUpTo.AutoSize = true;
            this.lblFactorialsUpTo.Location = new System.Drawing.Point(412, 57);
            this.lblFactorialsUpTo.Name = "lblFactorialsUpTo";
            this.lblFactorialsUpTo.Size = new System.Drawing.Size(88, 13);
            this.lblFactorialsUpTo.TabIndex = 1;
            this.lblFactorialsUpTo.Text = "Factorials Up To:";
            // 
            // lblTrackbarNumber
            // 
            this.lblTrackbarNumber.AutoSize = true;
            this.lblTrackbarNumber.Location = new System.Drawing.Point(506, 57);
            this.lblTrackbarNumber.Name = "lblTrackbarNumber";
            this.lblTrackbarNumber.Size = new System.Drawing.Size(13, 13);
            this.lblTrackbarNumber.TabIndex = 2;
            this.lblTrackbarNumber.Text = "1";
            // 
            // btnGenerateFactorials
            // 
            this.btnGenerateFactorials.Location = new System.Drawing.Point(389, 82);
            this.btnGenerateFactorials.Name = "btnGenerateFactorials";
            this.btnGenerateFactorials.Size = new System.Drawing.Size(160, 25);
            this.btnGenerateFactorials.TabIndex = 3;
            this.btnGenerateFactorials.Text = "Generate Factorials";
            this.btnGenerateFactorials.UseVisualStyleBackColor = true;
            this.btnGenerateFactorials.Click += new System.EventHandler(this.btnGenerateFactorials_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(185, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(594, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLongFactorialsDisplay
            // 
            this.txtLongFactorialsDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongFactorialsDisplay.Location = new System.Drawing.Point(26, 118);
            this.txtLongFactorialsDisplay.Multiline = true;
            this.txtLongFactorialsDisplay.Name = "txtLongFactorialsDisplay";
            this.txtLongFactorialsDisplay.ReadOnly = true;
            this.txtLongFactorialsDisplay.Size = new System.Drawing.Size(60, 290);
            this.txtLongFactorialsDisplay.TabIndex = 6;
            this.txtLongFactorialsDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLongFactorials
            // 
            this.txtLongFactorials.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongFactorials.Location = new System.Drawing.Point(92, 118);
            this.txtLongFactorials.Multiline = true;
            this.txtLongFactorials.Name = "txtLongFactorials";
            this.txtLongFactorials.ReadOnly = true;
            this.txtLongFactorials.Size = new System.Drawing.Size(815, 290);
            this.txtLongFactorials.TabIndex = 7;
            // 
            // txtIntFactorialsDisplay
            // 
            this.txtIntFactorialsDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntFactorialsDisplay.Location = new System.Drawing.Point(26, 417);
            this.txtIntFactorialsDisplay.Multiline = true;
            this.txtIntFactorialsDisplay.Name = "txtIntFactorialsDisplay";
            this.txtIntFactorialsDisplay.ReadOnly = true;
            this.txtIntFactorialsDisplay.Size = new System.Drawing.Size(60, 290);
            this.txtIntFactorialsDisplay.TabIndex = 8;
            this.txtIntFactorialsDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIntFactorials
            // 
            this.txtIntFactorials.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntFactorials.Location = new System.Drawing.Point(92, 417);
            this.txtIntFactorials.Multiline = true;
            this.txtIntFactorials.Name = "txtIntFactorials";
            this.txtIntFactorials.ReadOnly = true;
            this.txtIntFactorials.Size = new System.Drawing.Size(815, 290);
            this.txtIntFactorials.TabIndex = 9;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(792, 124);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(0, 13);
            this.lblLong.TabIndex = 10;
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(792, 422);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(0, 13);
            this.lblInt.TabIndex = 11;
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(224, 53);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(66, 17);
            this.chkReverse.TabIndex = 12;
            this.chkReverse.Text = "Reverse";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // chkRandomize
            // 
            this.chkRandomize.AutoSize = true;
            this.chkRandomize.Location = new System.Drawing.Point(632, 52);
            this.chkRandomize.Name = "chkRandomize";
            this.chkRandomize.Size = new System.Drawing.Size(79, 17);
            this.chkRandomize.TabIndex = 14;
            this.chkRandomize.Text = "Randomize";
            this.chkRandomize.UseVisualStyleBackColor = true;
            // 
            // frmFactorialFinder
            // 
            this.AcceptButton = this.btnGenerateFactorials;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 722);
            this.Controls.Add(this.chkRandomize);
            this.Controls.Add(this.chkReverse);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.txtIntFactorials);
            this.Controls.Add(this.txtIntFactorialsDisplay);
            this.Controls.Add(this.txtLongFactorials);
            this.Controls.Add(this.txtLongFactorialsDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerateFactorials);
            this.Controls.Add(this.lblTrackbarNumber);
            this.Controls.Add(this.lblFactorialsUpTo);
            this.Controls.Add(this.trOneToTwenty);
            this.Name = "frmFactorialFinder";
            this.Text = "Factorial Finder";
            ((System.ComponentModel.ISupportInitialize)(this.trOneToTwenty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trOneToTwenty;
        private System.Windows.Forms.Label lblFactorialsUpTo;
        private System.Windows.Forms.Label lblTrackbarNumber;
        private System.Windows.Forms.Button btnGenerateFactorials;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLongFactorialsDisplay;
        private System.Windows.Forms.TextBox txtLongFactorials;
        private System.Windows.Forms.TextBox txtIntFactorialsDisplay;
        private System.Windows.Forms.TextBox txtIntFactorials;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.CheckBox chkRandomize;
    }
}

