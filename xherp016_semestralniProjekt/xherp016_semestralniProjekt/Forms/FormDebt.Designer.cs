namespace xherp016_semestralniProjekt.Forms
{
    partial class FormDebt
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
            this.labelMoney = new System.Windows.Forms.Label();
            this.dataGridViewMoney = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.Location = new System.Drawing.Point(364, 12);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(80, 32);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Debts";
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewMoney
            // 
            this.dataGridViewMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoney.Location = new System.Drawing.Point(463, 12);
            this.dataGridViewMoney.Name = "dataGridViewMoney";
            this.dataGridViewMoney.RowTemplate.Height = 25;
            this.dataGridViewMoney.Size = new System.Drawing.Size(325, 426);
            this.dataGridViewMoney.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.MaximumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "There are information, how much every body have to pay or how much they have to g" +
    "et.";
            // 
            // FormDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMoney);
            this.Controls.Add(this.labelMoney);
            this.Name = "FormDebt";
            this.Text = "FormMoney";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMoney;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewMoney;
        private Label label1;
    }
}