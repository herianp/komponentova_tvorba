namespace xherp016_semestralniProjekt.Forms
{
    partial class FormBill
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
            this.labelChoosePerson = new System.Windows.Forms.Label();
            this.buttonAddToBill = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChoosePerson
            // 
            this.labelChoosePerson.AutoSize = true;
            this.labelChoosePerson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChoosePerson.Location = new System.Drawing.Point(54, 40);
            this.labelChoosePerson.Name = "labelChoosePerson";
            this.labelChoosePerson.Size = new System.Drawing.Size(120, 21);
            this.labelChoosePerson.TabIndex = 0;
            this.labelChoosePerson.Text = "Choose person";
            this.labelChoosePerson.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAddToBill
            // 
            this.buttonAddToBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToBill.Location = new System.Drawing.Point(105, 204);
            this.buttonAddToBill.Name = "buttonAddToBill";
            this.buttonAddToBill.Size = new System.Drawing.Size(181, 49);
            this.buttonAddToBill.TabIndex = 3;
            this.buttonAddToBill.Text = "Send to the Bill";
            this.buttonAddToBill.UseVisualStyleBackColor = true;
            this.buttonAddToBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 23);
            this.textBox2.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(54, 96);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(94, 21);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.Location = new System.Drawing.Point(54, 153);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(61, 21);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "Money";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAddToBill);
            this.Controls.Add(this.labelChoosePerson);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelChoosePerson;
        private Button buttonAddToBill;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelDescription;
        private Label labelMoney;
    }
}