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
            this.comboBoxChoosePerson = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelFormBill = new System.Windows.Forms.Label();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteFromBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChoosePerson
            // 
            this.labelChoosePerson.AutoSize = true;
            this.labelChoosePerson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChoosePerson.Location = new System.Drawing.Point(31, 109);
            this.labelChoosePerson.Name = "labelChoosePerson";
            this.labelChoosePerson.Size = new System.Drawing.Size(120, 21);
            this.labelChoosePerson.TabIndex = 0;
            this.labelChoosePerson.Text = "Choose person";
            // 
            // buttonAddToBill
            // 
            this.buttonAddToBill.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAddToBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddToBill.Location = new System.Drawing.Point(12, 273);
            this.buttonAddToBill.Name = "buttonAddToBill";
            this.buttonAddToBill.Size = new System.Drawing.Size(181, 49);
            this.buttonAddToBill.TabIndex = 3;
            this.buttonAddToBill.Text = "ADD";
            this.buttonAddToBill.UseVisualStyleBackColor = false;
            this.buttonAddToBill.Click += new System.EventHandler(this.ButtonAddToBill_Click);
            // 
            // comboBoxChoosePerson
            // 
            this.comboBoxChoosePerson.FormattingEnabled = true;
            this.comboBoxChoosePerson.Location = new System.Drawing.Point(171, 109);
            this.comboBoxChoosePerson.Name = "comboBoxChoosePerson";
            this.comboBoxChoosePerson.Size = new System.Drawing.Size(158, 23);
            this.comboBoxChoosePerson.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(171, 167);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(158, 23);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(171, 224);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(158, 23);
            this.textBoxMoney.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(31, 165);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(94, 21);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.Location = new System.Drawing.Point(31, 222);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(61, 21);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "Money";
            // 
            // labelFormBill
            // 
            this.labelFormBill.AutoSize = true;
            this.labelFormBill.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFormBill.Location = new System.Drawing.Point(342, 22);
            this.labelFormBill.Name = "labelFormBill";
            this.labelFormBill.Size = new System.Drawing.Size(61, 32);
            this.labelFormBill.TabIndex = 9;
            this.labelFormBill.Text = "BILL";
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBill.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(409, 22);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowTemplate.Height = 25;
            this.dataGridViewBill.Size = new System.Drawing.Size(367, 416);
            this.dataGridViewBill.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADD NEW BILL";
            // 
            // buttonDeleteFromBill
            // 
            this.buttonDeleteFromBill.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteFromBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteFromBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteFromBill.Location = new System.Drawing.Point(209, 273);
            this.buttonDeleteFromBill.Name = "buttonDeleteFromBill";
            this.buttonDeleteFromBill.Size = new System.Drawing.Size(181, 49);
            this.buttonDeleteFromBill.TabIndex = 12;
            this.buttonDeleteFromBill.Text = "DELETE";
            this.buttonDeleteFromBill.UseVisualStyleBackColor = false;
            this.buttonDeleteFromBill.Click += new System.EventHandler(this.ButtonDeleteFromBill_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteFromBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.labelFormBill);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxChoosePerson);
            this.Controls.Add(this.buttonAddToBill);
            this.Controls.Add(this.labelChoosePerson);
            this.Name = "FormBill";
            this.Text = "FormBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelChoosePerson;
        private Button buttonAddToBill;
        private ComboBox comboBoxChoosePerson;
        private TextBox textBoxDescription;
        private TextBox textBoxMoney;
        private Label labelDescription;
        private Label labelMoney;
        private Label labelFormBill;
        private DataGridView dataGridViewBill;
        private Label label1;
        private Button buttonDeleteFromBill;
    }
}