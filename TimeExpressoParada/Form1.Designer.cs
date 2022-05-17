namespace TimeExpressoParada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.mtxtIniTimer = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFinalTimer = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio (start):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termino (terminus):";
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(0, 126);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(291, 67);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular Tempo";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // mtxtIniTimer
            // 
            this.mtxtIniTimer.Location = new System.Drawing.Point(129, 22);
            this.mtxtIniTimer.Mask = "00:00";
            this.mtxtIniTimer.Name = "mtxtIniTimer";
            this.mtxtIniTimer.Size = new System.Drawing.Size(46, 23);
            this.mtxtIniTimer.TabIndex = 0;
            this.mtxtIniTimer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyUp);
            // 
            // mtxtFinalTimer
            // 
            this.mtxtFinalTimer.Location = new System.Drawing.Point(129, 61);
            this.mtxtFinalTimer.Mask = "00:00";
            this.mtxtFinalTimer.Name = "mtxtFinalTimer";
            this.mtxtFinalTimer.Size = new System.Drawing.Size(46, 23);
            this.mtxtFinalTimer.TabIndex = 1;
            this.mtxtFinalTimer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtFinalTimer_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 193);
            this.Controls.Add(this.mtxtFinalTimer);
            this.Controls.Add(this.mtxtIniTimer);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Expresso Parada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCalc;
        private MaskedTextBox mtxtIniTimer;
        private MaskedTextBox mtxtFinalTimer;
    }
}