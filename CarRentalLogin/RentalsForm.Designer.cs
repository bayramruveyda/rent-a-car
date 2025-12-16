namespace CarRentalLogin
{
    partial class RentalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalsForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCalculate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddRental = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCloseRental = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClearRental = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvRentals = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç:";
            // 
            // cmbCars
            // 
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Location = new System.Drawing.Point(146, 122);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(121, 24);
            this.cmbCars.TabIndex = 1;
            this.cmbCars.SelectedIndexChanged += new System.EventHandler(this.cmbCars_SelectedIndexChanged);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(146, 157);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 24);
            this.cmbCustomers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlangıç Tarihi:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(146, 196);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bitiş Tarihi:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(146, 231);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 7;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Günlük Ücret:";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.BackColor = System.Drawing.Color.White;
            this.txtDailyPrice.Location = new System.Drawing.Point(146, 265);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.ReadOnly = true;
            this.txtDailyPrice.Size = new System.Drawing.Size(100, 22);
            this.txtDailyPrice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Toplam Ücret:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(146, 299);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 57);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kiralama İşlemleri";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AllowAnimations = true;
            this.btnCalculate.AllowMouseEffects = true;
            this.btnCalculate.AllowToggling = false;
            this.btnCalculate.AnimationSpeed = 200;
            this.btnCalculate.AutoGenerateColors = false;
            this.btnCalculate.AutoRoundBorders = false;
            this.btnCalculate.AutoSizeLeftIcon = true;
            this.btnCalculate.AutoSizeRightIcon = true;
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.ButtonText = "Ücret Hesapla";
            this.btnCalculate.ButtonTextMarginLeft = 0;
            this.btnCalculate.ColorContrastOnClick = 45;
            this.btnCalculate.ColorContrastOnHover = 45;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCalculate.CustomizableEdges = borderEdges1;
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalculate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCalculate.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCalculate.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCalculate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.IconLeft = null;
            this.btnCalculate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCalculate.IconMarginLeft = 11;
            this.btnCalculate.IconPadding = 10;
            this.btnCalculate.IconRight = null;
            this.btnCalculate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCalculate.IconSize = 25;
            this.btnCalculate.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCalculate.IdleBorderRadius = 0;
            this.btnCalculate.IdleBorderThickness = 0;
            this.btnCalculate.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCalculate.IdleIconLeftImage = null;
            this.btnCalculate.IdleIconRightImage = null;
            this.btnCalculate.IndicateFocus = false;
            this.btnCalculate.Location = new System.Drawing.Point(36, 461);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCalculate.OnDisabledState.BorderRadius = 1;
            this.btnCalculate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.OnDisabledState.BorderThickness = 1;
            this.btnCalculate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCalculate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCalculate.OnDisabledState.IconLeftImage = null;
            this.btnCalculate.OnDisabledState.IconRightImage = null;
            this.btnCalculate.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnCalculate.onHoverState.BorderRadius = 1;
            this.btnCalculate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.onHoverState.BorderThickness = 1;
            this.btnCalculate.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnCalculate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.onHoverState.IconLeftImage = null;
            this.btnCalculate.onHoverState.IconRightImage = null;
            this.btnCalculate.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnCalculate.OnIdleState.BorderRadius = 1;
            this.btnCalculate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.OnIdleState.BorderThickness = 1;
            this.btnCalculate.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnCalculate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.OnIdleState.IconLeftImage = null;
            this.btnCalculate.OnIdleState.IconRightImage = null;
            this.btnCalculate.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnCalculate.OnPressedState.BorderRadius = 1;
            this.btnCalculate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.OnPressedState.BorderThickness = 1;
            this.btnCalculate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCalculate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.OnPressedState.IconLeftImage = null;
            this.btnCalculate.OnPressedState.IconRightImage = null;
            this.btnCalculate.Size = new System.Drawing.Size(150, 39);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalculate.TextMarginLeft = 0;
            this.btnCalculate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCalculate.UseDefaultRadiusAndThickness = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.AllowAnimations = true;
            this.btnAddRental.AllowMouseEffects = true;
            this.btnAddRental.AllowToggling = false;
            this.btnAddRental.AnimationSpeed = 200;
            this.btnAddRental.AutoGenerateColors = false;
            this.btnAddRental.AutoRoundBorders = false;
            this.btnAddRental.AutoSizeLeftIcon = true;
            this.btnAddRental.AutoSizeRightIcon = true;
            this.btnAddRental.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRental.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddRental.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRental.BackgroundImage")));
            this.btnAddRental.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddRental.ButtonText = "Ekle";
            this.btnAddRental.ButtonTextMarginLeft = 0;
            this.btnAddRental.ColorContrastOnClick = 45;
            this.btnAddRental.ColorContrastOnHover = 45;
            this.btnAddRental.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddRental.CustomizableEdges = borderEdges2;
            this.btnAddRental.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddRental.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddRental.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddRental.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddRental.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddRental.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddRental.ForeColor = System.Drawing.Color.White;
            this.btnAddRental.IconLeft = null;
            this.btnAddRental.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRental.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddRental.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddRental.IconMarginLeft = 11;
            this.btnAddRental.IconPadding = 10;
            this.btnAddRental.IconRight = null;
            this.btnAddRental.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRental.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddRental.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddRental.IconSize = 25;
            this.btnAddRental.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddRental.IdleBorderRadius = 0;
            this.btnAddRental.IdleBorderThickness = 0;
            this.btnAddRental.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddRental.IdleIconLeftImage = null;
            this.btnAddRental.IdleIconRightImage = null;
            this.btnAddRental.IndicateFocus = false;
            this.btnAddRental.Location = new System.Drawing.Point(292, 461);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddRental.OnDisabledState.BorderRadius = 1;
            this.btnAddRental.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddRental.OnDisabledState.BorderThickness = 1;
            this.btnAddRental.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddRental.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddRental.OnDisabledState.IconLeftImage = null;
            this.btnAddRental.OnDisabledState.IconRightImage = null;
            this.btnAddRental.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAddRental.onHoverState.BorderRadius = 1;
            this.btnAddRental.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddRental.onHoverState.BorderThickness = 1;
            this.btnAddRental.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnAddRental.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddRental.onHoverState.IconLeftImage = null;
            this.btnAddRental.onHoverState.IconRightImage = null;
            this.btnAddRental.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddRental.OnIdleState.BorderRadius = 1;
            this.btnAddRental.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddRental.OnIdleState.BorderThickness = 1;
            this.btnAddRental.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnAddRental.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddRental.OnIdleState.IconLeftImage = null;
            this.btnAddRental.OnIdleState.IconRightImage = null;
            this.btnAddRental.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnAddRental.OnPressedState.BorderRadius = 1;
            this.btnAddRental.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddRental.OnPressedState.BorderThickness = 1;
            this.btnAddRental.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddRental.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddRental.OnPressedState.IconLeftImage = null;
            this.btnAddRental.OnPressedState.IconRightImage = null;
            this.btnAddRental.Size = new System.Drawing.Size(150, 39);
            this.btnAddRental.TabIndex = 19;
            this.btnAddRental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRental.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddRental.TextMarginLeft = 0;
            this.btnAddRental.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddRental.UseDefaultRadiusAndThickness = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnCloseRental
            // 
            this.btnCloseRental.AllowAnimations = true;
            this.btnCloseRental.AllowMouseEffects = true;
            this.btnCloseRental.AllowToggling = false;
            this.btnCloseRental.AnimationSpeed = 200;
            this.btnCloseRental.AutoGenerateColors = false;
            this.btnCloseRental.AutoRoundBorders = false;
            this.btnCloseRental.AutoSizeLeftIcon = true;
            this.btnCloseRental.AutoSizeRightIcon = true;
            this.btnCloseRental.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseRental.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCloseRental.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseRental.BackgroundImage")));
            this.btnCloseRental.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCloseRental.ButtonText = "Kaydet";
            this.btnCloseRental.ButtonTextMarginLeft = 0;
            this.btnCloseRental.ColorContrastOnClick = 45;
            this.btnCloseRental.ColorContrastOnHover = 45;
            this.btnCloseRental.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCloseRental.CustomizableEdges = borderEdges3;
            this.btnCloseRental.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseRental.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCloseRental.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCloseRental.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCloseRental.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCloseRental.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCloseRental.ForeColor = System.Drawing.Color.White;
            this.btnCloseRental.IconLeft = null;
            this.btnCloseRental.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseRental.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCloseRental.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCloseRental.IconMarginLeft = 11;
            this.btnCloseRental.IconPadding = 10;
            this.btnCloseRental.IconRight = null;
            this.btnCloseRental.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseRental.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCloseRental.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCloseRental.IconSize = 25;
            this.btnCloseRental.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCloseRental.IdleBorderRadius = 0;
            this.btnCloseRental.IdleBorderThickness = 0;
            this.btnCloseRental.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCloseRental.IdleIconLeftImage = null;
            this.btnCloseRental.IdleIconRightImage = null;
            this.btnCloseRental.IndicateFocus = false;
            this.btnCloseRental.Location = new System.Drawing.Point(572, 461);
            this.btnCloseRental.Name = "btnCloseRental";
            this.btnCloseRental.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCloseRental.OnDisabledState.BorderRadius = 1;
            this.btnCloseRental.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCloseRental.OnDisabledState.BorderThickness = 1;
            this.btnCloseRental.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCloseRental.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCloseRental.OnDisabledState.IconLeftImage = null;
            this.btnCloseRental.OnDisabledState.IconRightImage = null;
            this.btnCloseRental.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnCloseRental.onHoverState.BorderRadius = 1;
            this.btnCloseRental.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCloseRental.onHoverState.BorderThickness = 1;
            this.btnCloseRental.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnCloseRental.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCloseRental.onHoverState.IconLeftImage = null;
            this.btnCloseRental.onHoverState.IconRightImage = null;
            this.btnCloseRental.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnCloseRental.OnIdleState.BorderRadius = 1;
            this.btnCloseRental.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCloseRental.OnIdleState.BorderThickness = 1;
            this.btnCloseRental.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnCloseRental.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCloseRental.OnIdleState.IconLeftImage = null;
            this.btnCloseRental.OnIdleState.IconRightImage = null;
            this.btnCloseRental.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnCloseRental.OnPressedState.BorderRadius = 1;
            this.btnCloseRental.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCloseRental.OnPressedState.BorderThickness = 1;
            this.btnCloseRental.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCloseRental.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCloseRental.OnPressedState.IconLeftImage = null;
            this.btnCloseRental.OnPressedState.IconRightImage = null;
            this.btnCloseRental.Size = new System.Drawing.Size(150, 39);
            this.btnCloseRental.TabIndex = 20;
            this.btnCloseRental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCloseRental.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCloseRental.TextMarginLeft = 0;
            this.btnCloseRental.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCloseRental.UseDefaultRadiusAndThickness = true;
            this.btnCloseRental.Click += new System.EventHandler(this.btnCloseRental_Click);
            // 
            // btnClearRental
            // 
            this.btnClearRental.AllowAnimations = true;
            this.btnClearRental.AllowMouseEffects = true;
            this.btnClearRental.AllowToggling = false;
            this.btnClearRental.AnimationSpeed = 200;
            this.btnClearRental.AutoGenerateColors = false;
            this.btnClearRental.AutoRoundBorders = false;
            this.btnClearRental.AutoSizeLeftIcon = true;
            this.btnClearRental.AutoSizeRightIcon = true;
            this.btnClearRental.BackColor = System.Drawing.Color.Transparent;
            this.btnClearRental.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClearRental.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearRental.BackgroundImage")));
            this.btnClearRental.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearRental.ButtonText = "Temizle";
            this.btnClearRental.ButtonTextMarginLeft = 0;
            this.btnClearRental.ColorContrastOnClick = 45;
            this.btnClearRental.ColorContrastOnHover = 45;
            this.btnClearRental.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnClearRental.CustomizableEdges = borderEdges4;
            this.btnClearRental.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearRental.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClearRental.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClearRental.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClearRental.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClearRental.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnClearRental.ForeColor = System.Drawing.Color.White;
            this.btnClearRental.IconLeft = null;
            this.btnClearRental.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearRental.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClearRental.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClearRental.IconMarginLeft = 11;
            this.btnClearRental.IconPadding = 10;
            this.btnClearRental.IconRight = null;
            this.btnClearRental.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearRental.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClearRental.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClearRental.IconSize = 25;
            this.btnClearRental.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClearRental.IdleBorderRadius = 0;
            this.btnClearRental.IdleBorderThickness = 0;
            this.btnClearRental.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClearRental.IdleIconLeftImage = null;
            this.btnClearRental.IdleIconRightImage = null;
            this.btnClearRental.IndicateFocus = false;
            this.btnClearRental.Location = new System.Drawing.Point(844, 461);
            this.btnClearRental.Name = "btnClearRental";
            this.btnClearRental.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClearRental.OnDisabledState.BorderRadius = 1;
            this.btnClearRental.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearRental.OnDisabledState.BorderThickness = 1;
            this.btnClearRental.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearRental.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClearRental.OnDisabledState.IconLeftImage = null;
            this.btnClearRental.OnDisabledState.IconRightImage = null;
            this.btnClearRental.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnClearRental.onHoverState.BorderRadius = 1;
            this.btnClearRental.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearRental.onHoverState.BorderThickness = 1;
            this.btnClearRental.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnClearRental.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClearRental.onHoverState.IconLeftImage = null;
            this.btnClearRental.onHoverState.IconRightImage = null;
            this.btnClearRental.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnClearRental.OnIdleState.BorderRadius = 1;
            this.btnClearRental.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearRental.OnIdleState.BorderThickness = 1;
            this.btnClearRental.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnClearRental.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClearRental.OnIdleState.IconLeftImage = null;
            this.btnClearRental.OnIdleState.IconRightImage = null;
            this.btnClearRental.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnClearRental.OnPressedState.BorderRadius = 1;
            this.btnClearRental.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearRental.OnPressedState.BorderThickness = 1;
            this.btnClearRental.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClearRental.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClearRental.OnPressedState.IconLeftImage = null;
            this.btnClearRental.OnPressedState.IconRightImage = null;
            this.btnClearRental.Size = new System.Drawing.Size(150, 39);
            this.btnClearRental.TabIndex = 21;
            this.btnClearRental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearRental.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearRental.TextMarginLeft = 0;
            this.btnClearRental.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClearRental.UseDefaultRadiusAndThickness = true;
            this.btnClearRental.Click += new System.EventHandler(this.btnClearRental_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRentals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentals.ColumnHeadersHeight = 40;
            this.dgvRentals.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvRentals.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRentals.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRentals.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvRentals.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRentals.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvRentals.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvRentals.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvRentals.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvRentals.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRentals.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvRentals.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRentals.CurrentTheme.Name = null;
            this.dgvRentals.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvRentals.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRentals.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRentals.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvRentals.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentals.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentals.EnableHeadersVisualStyles = false;
            this.dgvRentals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvRentals.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvRentals.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvRentals.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRentals.Location = new System.Drawing.Point(372, 122);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 40;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(678, 294);
            this.dgvRentals.TabIndex = 22;
            this.dgvRentals.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dgvRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellClick);
            // 
            // RentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1085, 563);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.btnClearRental);
            this.Controls.Add(this.btnCloseRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDailyPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.cmbCars);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RentalsForm";
            this.Text = "Kiralama İşlemleri";
            this.Load += new System.EventHandler(this.RentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCalculate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddRental;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCloseRental;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClearRental;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvRentals;
    }
}