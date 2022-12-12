namespace xherp016_semestralniProjekt.Forms
{
    partial class FilterBills
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
            this.dataGridViewFiltredDebts = new System.Windows.Forms.DataGridView();
            this.labelByUser = new System.Windows.Forms.Label();
            this.labelDebts = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilterByUser = new System.Windows.Forms.ComboBox();
            this.labelByDescription = new System.Windows.Forms.Label();
            this.buttonFilterDebts = new System.Windows.Forms.Button();
            this.buttonRefreshComboBox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltredDebts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFiltredDebts
            // 
            this.dataGridViewFiltredDebts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiltredDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltredDebts.Location = new System.Drawing.Point(452, 36);
            this.dataGridViewFiltredDebts.Name = "dataGridViewFiltredDebts";
            this.dataGridViewFiltredDebts.RowTemplate.Height = 25;
            this.dataGridViewFiltredDebts.Size = new System.Drawing.Size(336, 402);
            this.dataGridViewFiltredDebts.TabIndex = 0;
            // 
            // labelByUser
            // 
            this.labelByUser.AutoSize = true;
            this.labelByUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelByUser.Location = new System.Drawing.Point(42, 83);
            this.labelByUser.Name = "labelByUser";
            this.labelByUser.Size = new System.Drawing.Size(65, 21);
            this.labelByUser.TabIndex = 1;
            this.labelByUser.Text = "By user";
            // 
            // labelDebts
            // 
            this.labelDebts.AutoSize = true;
            this.labelDebts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDebts.Location = new System.Drawing.Point(359, 36);
            this.labelDebts.Name = "labelDebts";
            this.labelDebts.Size = new System.Drawing.Size(80, 32);
            this.labelDebts.TabIndex = 2;
            this.labelDebts.Text = "Debts";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(12, 38);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(63, 30);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Filter";
            // 
            // comboBoxFilterByUser
            // 
            this.comboBoxFilterByUser.FormattingEnabled = true;
            this.comboBoxFilterByUser.Location = new System.Drawing.Point(175, 81);
            this.comboBoxFilterByUser.Name = "comboBoxFilterByUser";
            this.comboBoxFilterByUser.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFilterByUser.TabIndex = 4;
            // 
            // labelByDescription
            // 
            this.labelByDescription.AutoSize = true;
            this.labelByDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelByDescription.Location = new System.Drawing.Point(42, 126);
            this.labelByDescription.Name = "labelByDescription";
            this.labelByDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelByDescription.Size = new System.Drawing.Size(117, 27);
            this.labelByDescription.TabIndex = 5;
            this.labelByDescription.Text = "By description";
            this.labelByDescription.UseCompatibleTextRendering = true;
            // 
            // buttonFilterDebts
            // 
            this.buttonFilterDebts.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonFilterDebts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFilterDebts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFilterDebts.Location = new System.Drawing.Point(40, 212);
            this.buttonFilterDebts.Name = "buttonFilterDebts";
            this.buttonFilterDebts.Size = new System.Drawing.Size(181, 49);
            this.buttonFilterDebts.TabIndex = 15;
            this.buttonFilterDebts.Text = "FILTER";
            this.buttonFilterDebts.UseVisualStyleBackColor = false;
            this.buttonFilterDebts.Click += new System.EventHandler(this.buttonFilterDebts_Click);
            // 
            // buttonRefreshComboBox
            // 
            this.buttonRefreshComboBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRefreshComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefreshComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefreshComboBox.Location = new System.Drawing.Point(245, 212);
            this.buttonRefreshComboBox.Name = "buttonRefreshComboBox";
            this.buttonRefreshComboBox.Size = new System.Drawing.Size(181, 49);
            this.buttonRefreshComboBox.TabIndex = 16;
            this.buttonRefreshComboBox.Text = "REFRESH FILTERS";
            this.buttonRefreshComboBox.UseVisualStyleBackColor = false;
            this.buttonRefreshComboBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 17;
            // 
            // FilterBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRefreshComboBox);
            this.Controls.Add(this.buttonFilterDebts);
            this.Controls.Add(this.labelByDescription);
            this.Controls.Add(this.comboBoxFilterByUser);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelDebts);
            this.Controls.Add(this.labelByUser);
            this.Controls.Add(this.dataGridViewFiltredDebts);
            this.Name = "FilterBills";
            this.Text = "FilterBills";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltredDebts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewFiltredDebts;
        private Label labelByUser;
        private Label labelDebts;
        private Label labelFilter;
        private ComboBox comboBoxFilterByUser;
        private Label labelByDescription;
        private Button buttonFilterDebts;
        private Button buttonRefreshComboBox;
        private TextBox textBox1;
    }
}