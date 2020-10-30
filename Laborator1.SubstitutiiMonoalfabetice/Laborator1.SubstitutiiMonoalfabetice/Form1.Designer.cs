namespace Laborator1.SubstitutiiMonoalfabetice
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
            this.txtbInitial = new System.Windows.Forms.TextBox();
            this.btnCezar = new System.Windows.Forms.Button();
            this.btnCezarN = new System.Windows.Forms.Button();
            this.btnRot13 = new System.Windows.Forms.Button();
            this.btnSM = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTxtFinal = new System.Windows.Forms.Label();
            this.numericUDNumarPasi = new System.Windows.Forms.NumericUpDown();
            this.btnCezarDecipher = new System.Windows.Forms.Button();
            this.btnCezarNDecipher = new System.Windows.Forms.Button();
            this.btnRot13Decipher = new System.Windows.Forms.Button();
            this.btnSMDecipher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNumarPasi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbInitial
            // 
            this.txtbInitial.Location = new System.Drawing.Point(12, 27);
            this.txtbInitial.Multiline = true;
            this.txtbInitial.Name = "txtbInitial";
            this.txtbInitial.Size = new System.Drawing.Size(368, 268);
            this.txtbInitial.TabIndex = 0;
            // 
            // btnCezar
            // 
            this.btnCezar.Location = new System.Drawing.Point(32, 385);
            this.btnCezar.Name = "btnCezar";
            this.btnCezar.Size = new System.Drawing.Size(113, 37);
            this.btnCezar.TabIndex = 2;
            this.btnCezar.Text = "Cezar";
            this.btnCezar.UseVisualStyleBackColor = true;
            this.btnCezar.Click += new System.EventHandler(this.btnCezar_Click);
            // 
            // btnCezarN
            // 
            this.btnCezarN.Location = new System.Drawing.Point(238, 385);
            this.btnCezarN.Name = "btnCezarN";
            this.btnCezarN.Size = new System.Drawing.Size(113, 37);
            this.btnCezarN.TabIndex = 3;
            this.btnCezarN.Text = "Cezar N";
            this.btnCezarN.UseVisualStyleBackColor = true;
            this.btnCezarN.Click += new System.EventHandler(this.btnCezarN_Click);
            // 
            // btnRot13
            // 
            this.btnRot13.Location = new System.Drawing.Point(450, 385);
            this.btnRot13.Name = "btnRot13";
            this.btnRot13.Size = new System.Drawing.Size(113, 37);
            this.btnRot13.TabIndex = 4;
            this.btnRot13.Text = "Rot13";
            this.btnRot13.UseVisualStyleBackColor = true;
            this.btnRot13.Click += new System.EventHandler(this.btnRot13_Click);
            // 
            // btnSM
            // 
            this.btnSM.Location = new System.Drawing.Point(659, 385);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(113, 37);
            this.btnSM.TabIndex = 5;
            this.btnSM.Text = "SM";
            this.btnSM.UseVisualStyleBackColor = true;
            this.btnSM.Click += new System.EventHandler(this.btnSM_Click);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(132, 1);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 23);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Textul Initial";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(573, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Textul Final";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alegeti formatul de cifrare:";
            // 
            // lbTxtFinal
            // 
            this.lbTxtFinal.Location = new System.Drawing.Point(424, 27);
            this.lbTxtFinal.Name = "lbTxtFinal";
            this.lbTxtFinal.Size = new System.Drawing.Size(364, 268);
            this.lbTxtFinal.TabIndex = 9;
            // 
            // numericUDNumarPasi
            // 
            this.numericUDNumarPasi.Location = new System.Drawing.Point(238, 359);
            this.numericUDNumarPasi.Name = "numericUDNumarPasi";
            this.numericUDNumarPasi.Size = new System.Drawing.Size(113, 20);
            this.numericUDNumarPasi.TabIndex = 10;
            // 
            // btnCezarDecipher
            // 
            this.btnCezarDecipher.Location = new System.Drawing.Point(32, 428);
            this.btnCezarDecipher.Name = "btnCezarDecipher";
            this.btnCezarDecipher.Size = new System.Drawing.Size(113, 37);
            this.btnCezarDecipher.TabIndex = 11;
            this.btnCezarDecipher.Text = "CezarDecipher";
            this.btnCezarDecipher.UseVisualStyleBackColor = true;
            this.btnCezarDecipher.Click += new System.EventHandler(this.btnCezarDecipher_Click);
            // 
            // btnCezarNDecipher
            // 
            this.btnCezarNDecipher.Location = new System.Drawing.Point(238, 428);
            this.btnCezarNDecipher.Name = "btnCezarNDecipher";
            this.btnCezarNDecipher.Size = new System.Drawing.Size(113, 37);
            this.btnCezarNDecipher.TabIndex = 12;
            this.btnCezarNDecipher.Text = "CezarNDecipher";
            this.btnCezarNDecipher.UseVisualStyleBackColor = true;
            this.btnCezarNDecipher.Click += new System.EventHandler(this.btnCezarNDecipher_Click);
            // 
            // btnRot13Decipher
            // 
            this.btnRot13Decipher.Location = new System.Drawing.Point(450, 428);
            this.btnRot13Decipher.Name = "btnRot13Decipher";
            this.btnRot13Decipher.Size = new System.Drawing.Size(113, 37);
            this.btnRot13Decipher.TabIndex = 13;
            this.btnRot13Decipher.Text = "ROT13Decipher";
            this.btnRot13Decipher.UseVisualStyleBackColor = true;
            this.btnRot13Decipher.Click += new System.EventHandler(this.btnRot13Decipher_Click);
            // 
            // btnSMDecipher
            // 
            this.btnSMDecipher.Location = new System.Drawing.Point(659, 428);
            this.btnSMDecipher.Name = "btnSMDecipher";
            this.btnSMDecipher.Size = new System.Drawing.Size(113, 37);
            this.btnSMDecipher.TabIndex = 14;
            this.btnSMDecipher.Text = "SMDecipher";
            this.btnSMDecipher.UseVisualStyleBackColor = true;
            this.btnSMDecipher.Click += new System.EventHandler(this.btnSMDecipher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btnSMDecipher);
            this.Controls.Add(this.btnRot13Decipher);
            this.Controls.Add(this.btnCezarNDecipher);
            this.Controls.Add(this.btnCezarDecipher);
            this.Controls.Add(this.numericUDNumarPasi);
            this.Controls.Add(this.lbTxtFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSM);
            this.Controls.Add(this.btnRot13);
            this.Controls.Add(this.btnCezarN);
            this.Controls.Add(this.btnCezar);
            this.Controls.Add(this.txtbInitial);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNumarPasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbInitial;
        private System.Windows.Forms.Button btnCezar;
        private System.Windows.Forms.Button btnCezarN;
        private System.Windows.Forms.Button btnRot13;
        private System.Windows.Forms.Button btnSM;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTxtFinal;
        private System.Windows.Forms.NumericUpDown numericUDNumarPasi;
        private System.Windows.Forms.Button btnCezarDecipher;
        private System.Windows.Forms.Button btnCezarNDecipher;
        private System.Windows.Forms.Button btnRot13Decipher;
        private System.Windows.Forms.Button btnSMDecipher;
    }
}

