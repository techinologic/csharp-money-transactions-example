namespace GuysForm
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.joesGivesToBob = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joesCashLabel.Location = new System.Drawing.Point(13, 13);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(96, 20);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "Joe has $50";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobsCashLabel.Location = new System.Drawing.Point(13, 48);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(108, 20);
            this.bobsCashLabel.TabIndex = 2;
            this.bobsCashLabel.Text = "Bob has $100";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCashLabel.Location = new System.Drawing.Point(13, 84);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(116, 20);
            this.bankCashLabel.TabIndex = 3;
            this.bankCashLabel.Text = "Bank has $100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bank gives $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // joesGivesToBob
            // 
            this.joesGivesToBob.Location = new System.Drawing.Point(16, 193);
            this.joesGivesToBob.Name = "joesGivesToBob";
            this.joesGivesToBob.Size = new System.Drawing.Size(110, 47);
            this.joesGivesToBob.TabIndex = 7;
            this.joesGivesToBob.Text = "Joe gives $10 to Bob";
            this.joesGivesToBob.UseVisualStyleBackColor = true;
            this.joesGivesToBob.Click += new System.EventHandler(this.joesGivesToBob_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bob gives $5 to Bank";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(162, 193);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(110, 47);
            this.bobGivesToJoe.TabIndex = 9;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(162, 13);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(110, 91);
            this.messageLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.joesGivesToBob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Name = "Form1";
            this.Text = "Guy Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button joesGivesToBob;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bobGivesToJoe;
        private System.Windows.Forms.Label messageLabel;
    }
}

