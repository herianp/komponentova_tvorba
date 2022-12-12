namespace xherp016_semestralniProjekt.Forms
{
    partial class FormPeople
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
            this.labelPeople = new System.Windows.Forms.Label();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxSureName = new System.Windows.Forms.TextBox();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.labelChoosePerson = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPeople.Location = new System.Drawing.Point(347, 21);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(91, 32);
            this.labelPeople.TabIndex = 0;
            this.labelPeople.Text = "People";
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Location = new System.Drawing.Point(444, 21);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.RowTemplate.Height = 25;
            this.dataGridViewPeople.Size = new System.Drawing.Size(344, 417);
            this.dataGridViewPeople.TabIndex = 1;
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.BackColor = System.Drawing.Color.Red;
            this.buttonDeletePerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeletePerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeletePerson.Location = new System.Drawing.Point(208, 214);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(181, 49);
            this.buttonDeletePerson.TabIndex = 21;
            this.buttonDeletePerson.Text = "DELETE";
            this.buttonDeletePerson.UseVisualStyleBackColor = false;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "ADD NEW BILL";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(29, 165);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(86, 21);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "SureName";
            // 
            // textBoxSureName
            // 
            this.textBoxSureName.Location = new System.Drawing.Point(169, 165);
            this.textBoxSureName.Name = "textBoxSureName";
            this.textBoxSureName.Size = new System.Drawing.Size(158, 23);
            this.textBoxSureName.TabIndex = 16;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAddPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddPerson.Location = new System.Drawing.Point(11, 214);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(181, 49);
            this.buttonAddPerson.TabIndex = 14;
            this.buttonAddPerson.Text = "ADD";
            this.buttonAddPerson.UseVisualStyleBackColor = false;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // labelChoosePerson
            // 
            this.labelChoosePerson.AutoSize = true;
            this.labelChoosePerson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChoosePerson.Location = new System.Drawing.Point(29, 109);
            this.labelChoosePerson.Name = "labelChoosePerson";
            this.labelChoosePerson.Size = new System.Drawing.Size(53, 21);
            this.labelChoosePerson.TabIndex = 13;
            this.labelChoosePerson.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 109);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 23);
            this.textBoxName.TabIndex = 22;
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxSureName);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.labelChoosePerson);
            this.Controls.Add(this.dataGridViewPeople);
            this.Controls.Add(this.labelPeople);
            this.Name = "FormPeople";
            this.Text = "FormPeople";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPeople;
        private DataGridView dataGridViewPeople;
        private Button buttonDeletePerson;
        private Label label1;
        private Label labelDescription;
        private TextBox textBoxSureName;
        private Button buttonAddPerson;
        private Label labelChoosePerson;
        private TextBox textBoxName;
    }
}