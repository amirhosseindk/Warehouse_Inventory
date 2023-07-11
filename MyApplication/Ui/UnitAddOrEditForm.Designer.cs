namespace MyApp.Ui
{
    partial class UnitAddOrEditForm
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
            textBox1 = new Usf.WinForms.Forms.TextBox();
            button1 = new Usf.WinForms.Forms.Button();
            checkBox1 = new Usf.WinForms.Forms.CheckBox();
            label1 = new Usf.WinForms.Forms.Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(186, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 32);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Appearance.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Appearance.ForeColor = Color.Maroon;
            button1.Appearance.Options.UseFont = true;
            button1.Appearance.Options.UseForeColor = true;
            button1.Location = new Point(186, 93);
            button1.Name = "button1";
            button1.Size = new Size(182, 46);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Teal;
            checkBox1.Location = new Point(70, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 28);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Active";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Appearance.ForeColor = Color.Teal;
            label1.Appearance.Options.UseFont = true;
            label1.Appearance.Options.UseForeColor = true;
            label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            label1.Location = new Point(71, 49);
            label1.Name = "label1";
            label1.Size = new Size(150, 38);
            label1.TabIndex = 4;
            label1.Text = "Name :";
            // 
            // UnitAddOrEditForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 189);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "UnitAddOrEditForm";
            Text = "UnitAddOrEditForm";
            Load += UnitAddOrEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Usf.WinForms.Forms.TextBox textBox1;
        private Usf.WinForms.Forms.Button button1;
        private Usf.WinForms.Forms.CheckBox checkBox1;
        private Usf.WinForms.Forms.Label label1;
    }
}