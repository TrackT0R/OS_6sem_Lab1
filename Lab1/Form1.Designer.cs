namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FactorialProgressBar = new System.Windows.Forms.ProgressBar();
            this.FactorialTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.FactorialLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FactorialTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FactorialProgressBar
            // 
            this.FactorialProgressBar.Location = new System.Drawing.Point(12, 51);
            this.FactorialProgressBar.Name = "FactorialProgressBar";
            this.FactorialProgressBar.Size = new System.Drawing.Size(300, 30);
            this.FactorialProgressBar.TabIndex = 0;
            // 
            // FactorialTrackBar
            // 
            this.FactorialTrackBar.Location = new System.Drawing.Point(12, 110);
            this.FactorialTrackBar.Maximum = 20;
            this.FactorialTrackBar.Minimum = 1;
            this.FactorialTrackBar.Name = "FactorialTrackBar";
            this.FactorialTrackBar.Size = new System.Drawing.Size(300, 56);
            this.FactorialTrackBar.TabIndex = 1;
            this.FactorialTrackBar.Value = 1;
            this.FactorialTrackBar.Scroll += new System.EventHandler(this.FactorialTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прогресс выполнения расчёта :";
            // 
            // FactorialLabel
            // 
            this.FactorialLabel.AutoSize = true;
            this.FactorialLabel.Location = new System.Drawing.Point(319, 110);
            this.FactorialLabel.Name = "FactorialLabel";
            this.FactorialLabel.Size = new System.Drawing.Size(0, 17);
            this.FactorialLabel.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 173);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(84, 17);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Результат :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 488);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FactorialLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FactorialTrackBar);
            this.Controls.Add(this.FactorialProgressBar);
            this.Name = "Form1";
            this.Text = "Factorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FactorialTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar FactorialProgressBar;
        private System.Windows.Forms.TrackBar FactorialTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FactorialLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

