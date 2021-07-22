namespace Avtoservis2
{
    partial class DellEmpl
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
            this.label1 = new System.Windows.Forms.Label();
            this.fioEmpl = new System.Windows.Forms.Label();
            this.dell = new System.Windows.Forms.Button();
            this.noDell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите уволить сотрудника:";
            // 
            // fioEmpl
            // 
            this.fioEmpl.AutoSize = true;
            this.fioEmpl.Location = new System.Drawing.Point(10, 76);
            this.fioEmpl.Name = "fioEmpl";
            this.fioEmpl.Size = new System.Drawing.Size(33, 13);
            this.fioEmpl.TabIndex = 1;
            this.fioEmpl.Text = "None";
            // 
            // dell
            // 
            this.dell.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dell.Location = new System.Drawing.Point(38, 152);
            this.dell.Name = "dell";
            this.dell.Size = new System.Drawing.Size(96, 28);
            this.dell.TabIndex = 2;
            this.dell.Text = "Да";
            this.dell.UseVisualStyleBackColor = true;
            // 
            // noDell
            // 
            this.noDell.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noDell.Location = new System.Drawing.Point(187, 152);
            this.noDell.Name = "noDell";
            this.noDell.Size = new System.Drawing.Size(92, 28);
            this.noDell.TabIndex = 3;
            this.noDell.Text = "Нет";
            this.noDell.UseVisualStyleBackColor = true;
            // 
            // DellEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 193);
            this.Controls.Add(this.noDell);
            this.Controls.Add(this.dell);
            this.Controls.Add(this.fioEmpl);
            this.Controls.Add(this.label1);
            this.Name = "DellEmpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уволить сотрудника";
            this.Load += new System.EventHandler(this.DellEmpl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dell;
        private System.Windows.Forms.Button noDell;
        public System.Windows.Forms.Label fioEmpl;
    }
}