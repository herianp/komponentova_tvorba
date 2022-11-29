namespace xherp016_semestralniProjekt
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
            this.homeText = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBill = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeText
            // 
            this.homeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeText.AutoSize = true;
            this.homeText.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeText.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeText.Location = new System.Drawing.Point(12, 20);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(179, 36);
            this.homeText.TabIndex = 4;
            this.homeText.Text = "Debt Counter";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelMenu.Controls.Add(this.btnMoney);
            this.panelMenu.Controls.Add(this.btnPeople);
            this.panelMenu.Controls.Add(this.btnBills);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 17;
            // 
            // btnMoney
            // 
            this.btnMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoney.ForeColor = System.Drawing.Color.Black;
            this.btnMoney.Image = global::xherp016_semestralniProjekt.Properties.Resources.output_onlinepngtools__1___1_;
            this.btnMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.Location = new System.Drawing.Point(0, 200);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMoney.Size = new System.Drawing.Size(200, 60);
            this.btnMoney.TabIndex = 2;
            this.btnMoney.Text = " MONEY";
            this.btnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPeople.ForeColor = System.Drawing.Color.Black;
            this.btnPeople.Image = global::xherp016_semestralniProjekt.Properties.Resources.people__1_;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(0, 140);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPeople.Size = new System.Drawing.Size(200, 60);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Text = " PEOPLE";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnBills
            // 
            this.btnBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBills.ForeColor = System.Drawing.Color.Black;
            this.btnBills.Image = global::xherp016_semestralniProjekt.Properties.Resources.bills__1_;
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(0, 80);
            this.btnBills.Name = "btnBills";
            this.btnBills.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBills.Size = new System.Drawing.Size(200, 60);
            this.btnBills.TabIndex = 0;
            this.btnBills.Text = " BILLS";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DimGray;
            this.panelLogo.Controls.Add(this.homeText);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Gray;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(600, 80);
            this.panelTitleBar.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(253, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(80, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelBill
            // 
            this.panelBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBill.Location = new System.Drawing.Point(200, 80);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(600, 370);
            this.panelBill.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label homeText;
        private Panel panelMenu;
        private Button btnBills;
        private Panel panelLogo;
        private Button btnMoney;
        private Button btnPeople;
        private Panel panelTitleBar;
        private Label labelTitle;
        private Panel panelBill;
    }
}