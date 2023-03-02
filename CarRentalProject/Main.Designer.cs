using CarRentalProject.Properties;

namespace CarRentalProject {
    partial class Main {
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
            this.components = new System.ComponentModel.Container();
            this.carRentalLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectedCarLabel = new System.Windows.Forms.Label();
            this.carSelectLabel = new System.Windows.Forms.Label();
            this.carPreviewBox = new ReaLTaiizor.Controls.HopePictureBox();
            this.iconComboBox1 = new CarRentalProject.IconComboBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.egnLabel = new System.Windows.Forms.Label();
            this.egnTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.tabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rentBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.finalizeOrderLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new ReaLTaiizor.Controls.PoisonDateTime();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new ReaLTaiizor.Controls.PoisonDateTime();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.smsLabel = new System.Windows.Forms.Label();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.personalInfoBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.carSelectionBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.finalizeBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.exitBtn = new ReaLTaiizor.Controls.ParrotButton();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPreviewBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.selectedCarLabel);
            this.tabPage2.Controls.Add(this.carSelectLabel);
            this.tabPage2.Controls.Add(this.carPreviewBox);
            this.tabPage2.Controls.Add(this.iconComboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // selectedCarLabel
            // 
            this.selectedCarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarLabel.AutoSize = true;
            this.selectedCarLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedCarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.selectedCarLabel.Location = new System.Drawing.Point(318, 17);
            this.selectedCarLabel.Name = "selectedCarLabel";
            this.selectedCarLabel.Size = new System.Drawing.Size(0, 26);
            this.selectedCarLabel.TabIndex = 9;
            this.selectedCarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carSelectLabel
            // 
            this.carSelectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carSelectLabel.AutoSize = true;
            this.carSelectLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.carSelectLabel.Location = new System.Drawing.Point(319, 311);
            this.carSelectLabel.Name = "carSelectLabel";
            this.carSelectLabel.Size = new System.Drawing.Size(239, 26);
            this.carSelectLabel.TabIndex = 8;
            this.carSelectLabel.Text = "Select a car to rent:";
            this.carSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carPreviewBox
            // 
            this.carPreviewBox.BackColor = System.Drawing.Color.Transparent;
            this.carPreviewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carPreviewBox.Location = new System.Drawing.Point(217, 59);
            this.carPreviewBox.Name = "carPreviewBox";
            this.carPreviewBox.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.carPreviewBox.Size = new System.Drawing.Size(446, 227);
            this.carPreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPreviewBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.carPreviewBox.TabIndex = 1;
            this.carPreviewBox.TabStop = false;
            this.carPreviewBox.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // iconComboBox1
            // 
            this.iconComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.iconComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iconComboBox1.DropDownHeight = 190;
            this.iconComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iconComboBox1.DropDownWidth = 160;
            this.iconComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconComboBox1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconComboBox1.FormattingEnabled = true;
            this.iconComboBox1.IconList = this.imageList;
            this.iconComboBox1.IntegralHeight = false;
            this.iconComboBox1.ItemHeight = 30;
            this.iconComboBox1.Location = new System.Drawing.Point(312, 340);
            this.iconComboBox1.Name = "iconComboBox1";
            this.iconComboBox1.Size = new System.Drawing.Size(253, 36);
            this.iconComboBox1.TabIndex = 0;
            this.iconComboBox1.SelectedIndexChanged += new System.EventHandler(this.iconComboBox1_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.phoneLabel);
            this.tabPage1.Controls.Add(this.phoneTextBox);
            this.tabPage1.Controls.Add(this.egnLabel);
            this.tabPage1.Controls.Add(this.egnTextBox);
            this.tabPage1.Controls.Add(this.lastNameLabel);
            this.tabPage1.Controls.Add(this.lastNameTextBox);
            this.tabPage1.Controls.Add(this.firstNameLabel);
            this.tabPage1.Controls.Add(this.firstNameTextBox);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.MinimumSize = new System.Drawing.Size(261, 61);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.phoneLabel.Location = new System.Drawing.Point(507, 237);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(179, 26);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Phone Number";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.White;
            this.phoneTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.phoneTextBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.phoneTextBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.phoneTextBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.phoneTextBox.Hint = "ex: +359 89000000";
            this.phoneTextBox.Location = new System.Drawing.Point(511, 266);
            this.phoneTextBox.MaxLength = 50;
            this.phoneTextBox.Multiline = false;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.SelectionLength = 0;
            this.phoneTextBox.SelectionStart = 0;
            this.phoneTextBox.Size = new System.Drawing.Size(255, 36);
            this.phoneTextBox.TabIndex = 12;
            this.phoneTextBox.TabStop = false;
            this.phoneTextBox.UseSystemPasswordChar = false;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.egnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.egnLabel.Location = new System.Drawing.Point(507, 59);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(60, 26);
            this.egnLabel.TabIndex = 11;
            this.egnLabel.Text = "EGN";
            this.egnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // egnTextBox
            // 
            this.egnTextBox.BackColor = System.Drawing.Color.White;
            this.egnTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.egnTextBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.egnTextBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.egnTextBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.egnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.egnTextBox.Hint = "ex: 8206018462";
            this.egnTextBox.Location = new System.Drawing.Point(511, 88);
            this.egnTextBox.MaxLength = 10;
            this.egnTextBox.Multiline = false;
            this.egnTextBox.Name = "egnTextBox";
            this.egnTextBox.PasswordChar = '\0';
            this.egnTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.egnTextBox.SelectedText = "";
            this.egnTextBox.SelectionLength = 0;
            this.egnTextBox.SelectionStart = 0;
            this.egnTextBox.Size = new System.Drawing.Size(255, 36);
            this.egnTextBox.TabIndex = 10;
            this.egnTextBox.TabStop = false;
            this.egnTextBox.UseSystemPasswordChar = false;
            this.egnTextBox.TextChanged += new System.EventHandler(this.egnTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.lastNameLabel.Location = new System.Drawing.Point(75, 237);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(133, 26);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.lastNameTextBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.lastNameTextBox.Hint = "ex: Ivanov";
            this.lastNameTextBox.Location = new System.Drawing.Point(79, 266);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Multiline = false;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.SelectionLength = 0;
            this.lastNameTextBox.SelectionStart = 0;
            this.lastNameTextBox.Size = new System.Drawing.Size(255, 36);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.TabStop = false;
            this.lastNameTextBox.UseSystemPasswordChar = false;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.firstNameLabel.Location = new System.Drawing.Point(75, 59);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(135, 26);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.firstNameTextBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.firstNameTextBox.Hint = "ex: Ivan";
            this.firstNameTextBox.Location = new System.Drawing.Point(79, 88);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Multiline = false;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.SelectionLength = 0;
            this.firstNameTextBox.SelectionStart = 0;
            this.firstNameTextBox.Size = new System.Drawing.Size(255, 36);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TabStop = false;
            this.firstNameTextBox.UseSystemPasswordChar = false;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(52, 66);
            this.tabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(858, 434);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tabPage3.Controls.Add(this.rentBtn);
            this.tabPage3.Controls.Add(this.finalizeOrderLabel);
            this.tabPage3.Controls.Add(this.endDateLabel);
            this.tabPage3.Controls.Add(this.endDatePicker);
            this.tabPage3.Controls.Add(this.startDateLabel);
            this.tabPage3.Controls.Add(this.startDatePicker);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(850, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // rentBtn
            // 
            this.rentBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.rentBtn.ButtonImage = global::CarRentalProject.Properties.Resources.check;
            this.rentBtn.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.rentBtn.ButtonText = "Rent";
            this.rentBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.rentBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.rentBtn.CornerRadius = 5;
            this.rentBtn.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.rentBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.rentBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.rentBtn.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.rentBtn.Location = new System.Drawing.Point(390, 351);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Padding = new System.Windows.Forms.Padding(50);
            this.rentBtn.Size = new System.Drawing.Size(101, 29);
            this.rentBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.rentBtn.TabIndex = 7;
            this.rentBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.rentBtn.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.rentBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // finalizeOrderLabel
            // 
            this.finalizeOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalizeOrderLabel.AutoSize = true;
            this.finalizeOrderLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalizeOrderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.finalizeOrderLabel.Location = new System.Drawing.Point(360, 27);
            this.finalizeOrderLabel.Name = "finalizeOrderLabel";
            this.finalizeOrderLabel.Size = new System.Drawing.Size(0, 26);
            this.finalizeOrderLabel.TabIndex = 12;
            this.finalizeOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.endDateLabel.Location = new System.Drawing.Point(386, 264);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(116, 26);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "End Date";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.endDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.endDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.endDatePicker.Location = new System.Drawing.Point(346, 293);
            this.endDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 29);
            this.endDatePicker.TabIndex = 10;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.startDateLabel.Location = new System.Drawing.Point(377, 191);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(130, 26);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.startDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.startDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.startDatePicker.Location = new System.Drawing.Point(346, 220);
            this.startDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 29);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tabPage4.Controls.Add(this.smsLabel);
            this.tabPage4.Controls.Add(this.thankYouLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(850, 406);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // smsLabel
            // 
            this.smsLabel.AutoSize = true;
            this.smsLabel.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.smsLabel.Location = new System.Drawing.Point(123, 239);
            this.smsLabel.Name = "smsLabel";
            this.smsLabel.Size = new System.Drawing.Size(602, 29);
            this.smsLabel.TabIndex = 8;
            this.smsLabel.Text = "You will receive a sms with more details very soon !";
            this.smsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thankYouLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.thankYouLabel.Location = new System.Drawing.Point(73, 122);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(718, 39);
            this.thankYouLabel.TabIndex = 7;
            this.thankYouLabel.Text = "Thank you for using our Car Rental Services !";
            this.thankYouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.finalizeBtn.Click += new System.EventHandler(this.finalizeBtn_Click);
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
            // Main
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
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPreviewBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label carRentalLabel;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialTabControl tabControl;
        private ReaLTaiizor.Controls.ParrotButton personalInfoBtn;
        private ReaLTaiizor.Controls.ParrotButton carSelectionBtn;
        private ReaLTaiizor.Controls.ParrotButton finalizeBtn;
        private ReaLTaiizor.Controls.ParrotButton exitBtn;
        private TabPage tabPage3;
        private ReaLTaiizor.Controls.HopeTextBox firstNameTextBox;
        private Label lastNameLabel;
        private ReaLTaiizor.Controls.HopeTextBox lastNameTextBox;
        private Label firstNameLabel;
        private Label phoneLabel;
        private ReaLTaiizor.Controls.HopeTextBox phoneTextBox;
        private Label egnLabel;
        private ReaLTaiizor.Controls.HopeTextBox egnTextBox;
        private IconComboBox iconComboBox1;
        private ImageList imageList;
        private ReaLTaiizor.Controls.HopePictureBox carPreviewBox;
        private Label carSelectLabel;
        private Label selectedCarLabel;
        private ReaLTaiizor.Controls.PoisonDateTime startDatePicker;
        private Label endDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime endDatePicker;
        private Label startDateLabel;
        private Label finalizeOrderLabel;
        private ReaLTaiizor.Controls.ParrotButton rentBtn;
        private TabPage tabPage4;
        private Label thankYouLabel;
        private Label smsLabel;
    }
}