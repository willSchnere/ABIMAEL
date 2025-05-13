namespace WinFormsAplicativo_App2
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
            BTN1 = new Button();
            TXTBOX1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTN1
            // 
            BTN1.Font = new Font("Segoe UI", 21F);
            BTN1.Location = new Point(304, 140);
            BTN1.Name = "BTN1";
            BTN1.Size = new Size(236, 89);
            BTN1.TabIndex = 0;
            BTN1.Text = "clique aqui";
            BTN1.UseVisualStyleBackColor = true;
            BTN1.Click += BTN1_Click;
            // 
            // TXTBOX1
            // 
            TXTBOX1.Font = new Font("Segoe UI", 21F);
            TXTBOX1.Location = new Point(304, 89);
            TXTBOX1.Name = "TXTBOX1";
            TXTBOX1.Size = new Size(236, 45);
            TXTBOX1.TabIndex = 1;
            TXTBOX1.Text = "Texto inicial";
            TXTBOX1.TextChanged += TXTBOX1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F);
            label1.Location = new Point(304, 258);
            label1.Name = "label1";
            label1.Size = new Size(76, 38);
            label1.TabIndex = 2;
            label1.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TXTBOX1);
            Controls.Add(BTN1);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN1;
        private TextBox TXTBOX1;
        private Label label1;
    }
}
