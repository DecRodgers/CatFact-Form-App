namespace CatFact_Form_App
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            CatFactTextlbl = new Label();
            groupBox2 = new GroupBox();
            CatFactLengthlbl = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(182, 167);
            button1.Name = "button1";
            button1.Size = new Size(259, 50);
            button1.TabIndex = 0;
            button1.Text = "Fetch Catfact";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CatFactTextlbl);
            groupBox1.Location = new Point(17, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "FACT";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // CatFactTextlbl
            // 
            CatFactTextlbl.AutoSize = true;
            CatFactTextlbl.Dock = DockStyle.Fill;
            CatFactTextlbl.Location = new Point(3, 19);
            CatFactTextlbl.MaximumSize = new Size(600, 0);
            CatFactTextlbl.Name = "CatFactTextlbl";
            CatFactTextlbl.Size = new Size(197, 15);
            CatFactTextlbl.TabIndex = 0;
            CatFactTextlbl.Text = " Click the button to fetch a Cat Fact!";
            CatFactTextlbl.Click += CatFactTextlbl_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CatFactLengthlbl);
            groupBox2.Location = new Point(17, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(626, 40);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "LENGTH";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // CatFactLengthlbl
            // 
            CatFactLengthlbl.AutoSize = true;
            CatFactLengthlbl.Location = new Point(6, 19);
            CatFactLengthlbl.Name = "CatFactLengthlbl";
            CatFactLengthlbl.Size = new Size(10, 15);
            CatFactLengthlbl.TabIndex = 0;
            CatFactLengthlbl.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 237);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CatFacts";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label CatFactTextlbl;
        private GroupBox groupBox2;
        private Label CatFactLengthlbl;
    }
}
