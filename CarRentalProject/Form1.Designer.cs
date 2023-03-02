namespace CarRentalProject {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.carRentalLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.personalInfoBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.carSelectionBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.finalizeBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.exitBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.tabPage2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carRentalLabel
            // 
            this.carRentalLabel.AutoSize = true;
            this.carRentalLabel.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carRentalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.carRentalLabel.Location = new System.Drawing.Point(22, 24);
            this.carRentalLabel.Name = "carRentalLabel";
            this.carRentalLabel.Size = new System.Drawing.Size(180, 39);
            this.carRentalLabel.TabIndex = 2;
            this.carRentalLabel.Text = "Car Rental";
            this.carRentalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nightLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(122, 76);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(69, 15);
            this.nightLabel1.TabIndex = 0;
            this.nightLabel1.Text = "nightLabel1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.MinimumSize = new System.Drawing.Size(261, 61);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(52, 66);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(858, 409);
            this.materialTabControl1.TabIndex = 0;
            // 
            // personalInfoBtn
            // 
            this.personalInfoBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.personalInfoBtn.ButtonImage = global::CarRentalProject.Properties.Resources.user;
            this.personalInfoBtn.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.personalInfoBtn.ButtonText = "Personal Information";
            this.personalInfoBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.personalInfoBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.personalInfoBtn.CornerRadius = 5;
            this.personalInfoBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personalInfoBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.personalInfoBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.personalInfoBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.personalInfoBtn.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.personalInfoBtn.Location = new System.Drawing.Point(446, 31);
            this.personalInfoBtn.Name = "personalInfoBtn";
            this.personalInfoBtn.Size = new System.Drawing.Size(173, 29);
            this.personalInfoBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.personalInfoBtn.TabIndex = 3;
            this.personalInfoBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.personalInfoBtn.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.personalInfoBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.personalInfoBtn.Click += new System.EventHandler(this.personalInfoBtn_Click);
            // 
            // carSelectionBtn
            // 
            this.carSelectionBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.carSelectionBtn.ButtonImage = global::CarRentalProject.Properties.Resources.car;
            this.carSelectionBtn.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.carSelectionBtn.ButtonText = "Car Selection";
            this.carSelectionBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.carSelectionBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.carSelectionBtn.CornerRadius = 5;
            this.carSelectionBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carSelectionBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.carSelectionBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.carSelectionBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.carSelectionBtn.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.carSelectionBtn.Location = new System.Drawing.Point(635, 31);
            this.carSelectionBtn.Name = "carSelectionBtn";
            this.carSelectionBtn.Padding = new System.Windows.Forms.Padding(50);
            this.carSelectionBtn.Size = new System.Drawing.Size(130, 29);
            this.carSelectionBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.carSelectionBtn.TabIndex = 4;
            this.carSelectionBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.carSelectionBtn.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.carSelectionBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.carSelectionBtn.Click += new System.EventHandler(this.carSelectionBtn_Click);
            // 
            // finalizeBtn
            // 
            this.finalizeBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.finalizeBtn.ButtonImage = global::CarRentalProject.Properties.Resources.flag;
            this.finalizeBtn.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.finalizeBtn.ButtonText = "Finalize";
            this.finalizeBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.finalizeBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.finalizeBtn.CornerRadius = 5;
            this.finalizeBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalizeBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.finalizeBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.finalizeBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.finalizeBtn.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.finalizeBtn.Location = new System.Drawing.Point(782, 31);
            this.finalizeBtn.Name = "finalizeBtn";
            this.finalizeBtn.Padding = new System.Windows.Forms.Padding(50);
            this.finalizeBtn.Size = new System.Drawing.Size(101, 29);
            this.finalizeBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.finalizeBtn.TabIndex = 5;
            this.finalizeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.finalizeBtn.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.finalizeBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.exitBtn.ButtonImage = global::CarRentalProject.Properties.Resources.exit;
            this.exitBtn.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.exitBtn.ButtonText = "";
            this.exitBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.exitBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.exitBtn.CornerRadius = 5;
            this.exitBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.exitBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.exitBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.exitBtn.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.exitBtn.Location = new System.Drawing.Point(909, 31);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(30, 29);
            this.exitBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.exitBtn.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.exitBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(967, 512);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.finalizeBtn);
            this.Controls.Add(this.carSelectionBtn);
            this.Controls.Add(this.personalInfoBtn);
            this.Controls.Add(this.carRentalLabel);
            this.Controls.Add(this.materialTabControl1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label carRentalLabel;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private ReaLTaiizor.Controls.ParrotButton personalInfoBtn;
        private ReaLTaiizor.Controls.ParrotButton carSelectionBtn;
        private ReaLTaiizor.Controls.ParrotButton finalizeBtn;
        private ReaLTaiizor.Controls.ParrotButton exitBtn;
    }
}