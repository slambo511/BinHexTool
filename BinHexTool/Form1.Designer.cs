
namespace BinHexTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.lblUnicode = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBin
            // 
            this.txtBin.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBin.Location = new System.Drawing.Point(237, 43);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(1079, 52);
            this.txtBin.TabIndex = 0;
            this.txtBin.TextChanged += new System.EventHandler(this.txtBin_TextChanged);
            this.txtBin.Enter += new System.EventHandler(this.txtBin_Enter);
            // 
            // txtDec
            // 
            this.txtDec.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDec.Location = new System.Drawing.Point(237, 238);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(1079, 52);
            this.txtDec.TabIndex = 1;
            this.txtDec.TextChanged += new System.EventHandler(this.txtDec_TextChanged);
            this.txtDec.Enter += new System.EventHandler(this.txtDec_Enter);
            // 
            // txtHex
            // 
            this.txtHex.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHex.Location = new System.Drawing.Point(237, 141);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(1079, 52);
            this.txtHex.TabIndex = 2;
            this.txtHex.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            this.txtHex.Enter += new System.EventHandler(this.txtHex_Enter);
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBinary.Location = new System.Drawing.Point(19, 46);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(111, 46);
            this.lblBinary.TabIndex = 3;
            this.lblBinary.Text = "Binary";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHex.Location = new System.Drawing.Point(19, 144);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(211, 46);
            this.lblHex.TabIndex = 4;
            this.lblHex.Text = "Hexadecimal";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDec.Location = new System.Drawing.Point(19, 241);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(140, 46);
            this.lblDec.TabIndex = 5;
            this.lblDec.Text = "Decimal";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(19, 471);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(156, 66);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtASCII
            // 
            this.txtASCII.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtASCII.Location = new System.Drawing.Point(237, 336);
            this.txtASCII.MaxLength = 1;
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(81, 52);
            this.txtASCII.TabIndex = 7;
            this.txtASCII.TextChanged += new System.EventHandler(this.txtASCII_TextChanged);
            this.txtASCII.Enter += new System.EventHandler(this.txtASCII_Enter);
            // 
            // lblUnicode
            // 
            this.lblUnicode.AutoSize = true;
            this.lblUnicode.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnicode.Location = new System.Drawing.Point(19, 339);
            this.lblUnicode.Name = "lblUnicode";
            this.lblUnicode.Size = new System.Drawing.Size(144, 46);
            this.lblUnicode.TabIndex = 8;
            this.lblUnicode.Text = "Unicode";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.Location = new System.Drawing.Point(237, 471);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(261, 66);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy Unicode";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1160, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 66);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1328, 579);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblUnicode);
            this.Controls.Add(this.txtASCII);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.txtBin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Binary and Hex Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.Label lblUnicode;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnExit;
    }
}

