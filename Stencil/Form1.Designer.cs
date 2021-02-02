namespace Stencil
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelNavigatiom = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnItog = new System.Windows.Forms.Button();
            this.btnSaller = new System.Windows.Forms.Button();
            this.btnGAmes = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PanelNavigatiom);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnItog);
            this.panel1.Controls.Add(this.btnSaller);
            this.panel1.Controls.Add(this.btnGAmes);
            this.panel1.Controls.Add(this.btnPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // PanelNavigatiom
            // 
            this.PanelNavigatiom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PanelNavigatiom.Location = new System.Drawing.Point(3, 193);
            this.PanelNavigatiom.Name = "PanelNavigatiom";
            this.PanelNavigatiom.Size = new System.Drawing.Size(3, 100);
            this.PanelNavigatiom.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(0, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Leave += new System.EventHandler(this.btnExit_Leave_1);
            // 
            // btnItog
            // 
            this.btnItog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItog.FlatAppearance.BorderSize = 0;
            this.btnItog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItog.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnItog.Location = new System.Drawing.Point(0, 288);
            this.btnItog.Name = "btnItog";
            this.btnItog.Size = new System.Drawing.Size(186, 42);
            this.btnItog.TabIndex = 2;
            this.btnItog.Text = "Итог";
            this.btnItog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnItog.UseVisualStyleBackColor = true;
            this.btnItog.Click += new System.EventHandler(this.btnItog_Click);
            this.btnItog.Leave += new System.EventHandler(this.btnItog_Leave);
            // 
            // btnSaller
            // 
            this.btnSaller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaller.FlatAppearance.BorderSize = 0;
            this.btnSaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaller.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSaller.Location = new System.Drawing.Point(0, 246);
            this.btnSaller.Name = "btnSaller";
            this.btnSaller.Size = new System.Drawing.Size(186, 42);
            this.btnSaller.TabIndex = 2;
            this.btnSaller.Text = "Продавцы";
            this.btnSaller.UseVisualStyleBackColor = true;
            this.btnSaller.Click += new System.EventHandler(this.btnSaller_Click);
            this.btnSaller.Leave += new System.EventHandler(this.btnSaller_Leave);
            // 
            // btnGAmes
            // 
            this.btnGAmes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGAmes.FlatAppearance.BorderSize = 0;
            this.btnGAmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGAmes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGAmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGAmes.Location = new System.Drawing.Point(0, 204);
            this.btnGAmes.Name = "btnGAmes";
            this.btnGAmes.Size = new System.Drawing.Size(186, 42);
            this.btnGAmes.TabIndex = 2;
            this.btnGAmes.Text = "Игры";
            this.btnGAmes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGAmes.UseVisualStyleBackColor = true;
            this.btnGAmes.Click += new System.EventHandler(this.btnGAmes_Click);
            this.btnGAmes.Leave += new System.EventHandler(this.btnGAmes_Leave);
            // 
            // btnPanel
            // 
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.FlatAppearance.BorderSize = 0;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPanel.Location = new System.Drawing.Point(0, 162);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(186, 42);
            this.btnPanel.TabIndex = 2;
            this.btnPanel.Text = "Панель";
            this.btnPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            this.btnPanel.Leave += new System.EventHandler(this.btnPanel_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PnlNav);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 162);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "User:";
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(208, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(388, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ознакомительная панель";
            // 
            // PanelFormLoader
            // 
            this.PanelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PanelFormLoader.Name = "PanelFormLoader";
            this.PanelFormLoader.Size = new System.Drawing.Size(765, 477);
            this.PanelFormLoader.TabIndex = 2;
            this.PanelFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormLoader_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PanelFormLoader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItsJustWorks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnItog;
        private System.Windows.Forms.Button btnSaller;
        private System.Windows.Forms.Button btnGAmes;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelNavigatiom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PanelFormLoader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

