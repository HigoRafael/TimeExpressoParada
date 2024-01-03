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
            label1 = new Label();
            label2 = new Label();
            btnCalc = new Button();
            mtxtIniTimer = new MaskedTextBox();
            mtxtFinalTimer = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 69);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Término:";
            // 
            // btnCalc
            // 
            btnCalc.Dock = DockStyle.Bottom;
            btnCalc.FlatStyle = FlatStyle.Popup;
            btnCalc.Location = new Point(0, 106);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(291, 67);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calcular Intervalo";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // mtxtIniTimer
            // 
            mtxtIniTimer.Location = new Point(129, 22);
            mtxtIniTimer.Mask = "00:00";
            mtxtIniTimer.Name = "mtxtIniTimer";
            mtxtIniTimer.Size = new Size(46, 23);
            mtxtIniTimer.TabIndex = 0;
            mtxtIniTimer.KeyUp += maskedTextBox1_KeyUp;
            // 
            // mtxtFinalTimer
            // 
            mtxtFinalTimer.Location = new Point(129, 61);
            mtxtFinalTimer.Mask = "00:00";
            mtxtFinalTimer.Name = "mtxtFinalTimer";
            mtxtFinalTimer.Size = new Size(46, 23);
            mtxtFinalTimer.TabIndex = 1;
            mtxtFinalTimer.KeyUp += mtxtFinalTimer_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 173);
            Controls.Add(mtxtFinalTimer);
            Controls.Add(mtxtIniTimer);
            Controls.Add(btnCalc);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer Expresso Parada";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCalc;
        private MaskedTextBox mtxtIniTimer;
        private MaskedTextBox mtxtFinalTimer;
    }
}