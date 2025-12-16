namespace CarRentalLogin
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddCar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUpdateCar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDeleteCar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClearCar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvCars = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(130, 117);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(130, 150);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plaka:";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(130, 187);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(100, 22);
            this.txtPlate.TabIndex = 2;
            this.txtPlate.TextChanged += new System.EventHandler(this.txtPlate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yıl:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(130, 226);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Günlük Ücret:";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Location = new System.Drawing.Point(130, 263);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(100, 22);
            this.txtDailyPrice.TabIndex = 4;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.ForeColor = System.Drawing.Color.Black;
            this.chkAvailable.Location = new System.Drawing.Point(18, 306);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(68, 20);
            this.chkAvailable.TabIndex = 5;
            this.chkAvailable.Text = "Müsait";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(41, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 57);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Araç Yönetimi";
            // 
            // btnAddCar
            // 
            this.btnAddCar.AllowAnimations = true;
            this.btnAddCar.AllowMouseEffects = true;
            this.btnAddCar.AllowToggling = false;
            this.btnAddCar.AnimationSpeed = 200;
            this.btnAddCar.AutoGenerateColors = false;
            this.btnAddCar.AutoRoundBorders = false;
            this.btnAddCar.AutoSizeLeftIcon = true;
            this.btnAddCar.AutoSizeRightIcon = true;
            this.btnAddCar.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCar.BackgroundImage")));
            this.btnAddCar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCar.ButtonText = "Ekle";
            this.btnAddCar.ButtonTextMarginLeft = 0;
            this.btnAddCar.ColorContrastOnClick = 45;
            this.btnAddCar.ColorContrastOnHover = 45;
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddCar.CustomizableEdges = borderEdges1;
            this.btnAddCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddCar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddCar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.IconLeft = null;
            this.btnAddCar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddCar.IconMarginLeft = 11;
            this.btnAddCar.IconPadding = 10;
            this.btnAddCar.IconRight = null;
            this.btnAddCar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddCar.IconSize = 25;
            this.btnAddCar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddCar.IdleBorderRadius = 0;
            this.btnAddCar.IdleBorderThickness = 0;
            this.btnAddCar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddCar.IdleIconLeftImage = null;
            this.btnAddCar.IdleIconRightImage = null;
            this.btnAddCar.IndicateFocus = false;
            this.btnAddCar.Location = new System.Drawing.Point(51, 460);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCar.OnDisabledState.BorderRadius = 1;
            this.btnAddCar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCar.OnDisabledState.BorderThickness = 1;
            this.btnAddCar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCar.OnDisabledState.IconLeftImage = null;
            this.btnAddCar.OnDisabledState.IconRightImage = null;
            this.btnAddCar.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAddCar.onHoverState.BorderRadius = 1;
            this.btnAddCar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCar.onHoverState.BorderThickness = 1;
            this.btnAddCar.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnAddCar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.onHoverState.IconLeftImage = null;
            this.btnAddCar.onHoverState.IconRightImage = null;
            this.btnAddCar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddCar.OnIdleState.BorderRadius = 1;
            this.btnAddCar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCar.OnIdleState.BorderThickness = 1;
            this.btnAddCar.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnAddCar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.OnIdleState.IconLeftImage = null;
            this.btnAddCar.OnIdleState.IconRightImage = null;
            this.btnAddCar.OnPressedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAddCar.OnPressedState.BorderRadius = 1;
            this.btnAddCar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCar.OnPressedState.BorderThickness = 1;
            this.btnAddCar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddCar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.OnPressedState.IconLeftImage = null;
            this.btnAddCar.OnPressedState.IconRightImage = null;
            this.btnAddCar.Size = new System.Drawing.Size(150, 39);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCar.TextMarginLeft = 0;
            this.btnAddCar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddCar.UseDefaultRadiusAndThickness = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.AllowAnimations = true;
            this.btnUpdateCar.AllowMouseEffects = true;
            this.btnUpdateCar.AllowToggling = false;
            this.btnUpdateCar.AnimationSpeed = 200;
            this.btnUpdateCar.AutoGenerateColors = false;
            this.btnUpdateCar.AutoRoundBorders = false;
            this.btnUpdateCar.AutoSizeLeftIcon = true;
            this.btnUpdateCar.AutoSizeRightIcon = true;
            this.btnUpdateCar.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnUpdateCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCar.BackgroundImage")));
            this.btnUpdateCar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateCar.ButtonText = "Güncelle";
            this.btnUpdateCar.ButtonTextMarginLeft = 0;
            this.btnUpdateCar.ColorContrastOnClick = 45;
            this.btnUpdateCar.ColorContrastOnHover = 45;
            this.btnUpdateCar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnUpdateCar.CustomizableEdges = borderEdges2;
            this.btnUpdateCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateCar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdateCar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnUpdateCar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnUpdateCar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdateCar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCar.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCar.IconLeft = null;
            this.btnUpdateCar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateCar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpdateCar.IconMarginLeft = 11;
            this.btnUpdateCar.IconPadding = 10;
            this.btnUpdateCar.IconRight = null;
            this.btnUpdateCar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateCar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpdateCar.IconSize = 25;
            this.btnUpdateCar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnUpdateCar.IdleBorderRadius = 0;
            this.btnUpdateCar.IdleBorderThickness = 0;
            this.btnUpdateCar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnUpdateCar.IdleIconLeftImage = null;
            this.btnUpdateCar.IdleIconRightImage = null;
            this.btnUpdateCar.IndicateFocus = false;
            this.btnUpdateCar.Location = new System.Drawing.Point(293, 460);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdateCar.OnDisabledState.BorderRadius = 1;
            this.btnUpdateCar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateCar.OnDisabledState.BorderThickness = 1;
            this.btnUpdateCar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdateCar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdateCar.OnDisabledState.IconLeftImage = null;
            this.btnUpdateCar.OnDisabledState.IconRightImage = null;
            this.btnUpdateCar.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateCar.onHoverState.BorderRadius = 1;
            this.btnUpdateCar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateCar.onHoverState.BorderThickness = 1;
            this.btnUpdateCar.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateCar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCar.onHoverState.IconLeftImage = null;
            this.btnUpdateCar.onHoverState.IconRightImage = null;
            this.btnUpdateCar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateCar.OnIdleState.BorderRadius = 1;
            this.btnUpdateCar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateCar.OnIdleState.BorderThickness = 1;
            this.btnUpdateCar.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdateCar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCar.OnIdleState.IconLeftImage = null;
            this.btnUpdateCar.OnIdleState.IconRightImage = null;
            this.btnUpdateCar.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateCar.OnPressedState.BorderRadius = 1;
            this.btnUpdateCar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateCar.OnPressedState.BorderThickness = 1;
            this.btnUpdateCar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUpdateCar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCar.OnPressedState.IconLeftImage = null;
            this.btnUpdateCar.OnPressedState.IconRightImage = null;
            this.btnUpdateCar.Size = new System.Drawing.Size(150, 39);
            this.btnUpdateCar.TabIndex = 7;
            this.btnUpdateCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateCar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateCar.TextMarginLeft = 0;
            this.btnUpdateCar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpdateCar.UseDefaultRadiusAndThickness = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.AllowAnimations = true;
            this.btnDeleteCar.AllowMouseEffects = true;
            this.btnDeleteCar.AllowToggling = false;
            this.btnDeleteCar.AnimationSpeed = 200;
            this.btnDeleteCar.AutoGenerateColors = false;
            this.btnDeleteCar.AutoRoundBorders = false;
            this.btnDeleteCar.AutoSizeLeftIcon = true;
            this.btnDeleteCar.AutoSizeRightIcon = true;
            this.btnDeleteCar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDeleteCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCar.BackgroundImage")));
            this.btnDeleteCar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCar.ButtonText = "Sil";
            this.btnDeleteCar.ButtonTextMarginLeft = 0;
            this.btnDeleteCar.ColorContrastOnClick = 45;
            this.btnDeleteCar.ColorContrastOnHover = 45;
            this.btnDeleteCar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnDeleteCar.CustomizableEdges = borderEdges3;
            this.btnDeleteCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteCar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteCar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDeleteCar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDeleteCar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDeleteCar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCar.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCar.IconLeft = null;
            this.btnDeleteCar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteCar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDeleteCar.IconMarginLeft = 11;
            this.btnDeleteCar.IconPadding = 10;
            this.btnDeleteCar.IconRight = null;
            this.btnDeleteCar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteCar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteCar.IconSize = 25;
            this.btnDeleteCar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDeleteCar.IdleBorderRadius = 0;
            this.btnDeleteCar.IdleBorderThickness = 0;
            this.btnDeleteCar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDeleteCar.IdleIconLeftImage = null;
            this.btnDeleteCar.IdleIconRightImage = null;
            this.btnDeleteCar.IndicateFocus = false;
            this.btnDeleteCar.Location = new System.Drawing.Point(551, 460);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteCar.OnDisabledState.BorderRadius = 1;
            this.btnDeleteCar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCar.OnDisabledState.BorderThickness = 1;
            this.btnDeleteCar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteCar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteCar.OnDisabledState.IconLeftImage = null;
            this.btnDeleteCar.OnDisabledState.IconRightImage = null;
            this.btnDeleteCar.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteCar.onHoverState.BorderRadius = 1;
            this.btnDeleteCar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCar.onHoverState.BorderThickness = 1;
            this.btnDeleteCar.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteCar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCar.onHoverState.IconLeftImage = null;
            this.btnDeleteCar.onHoverState.IconRightImage = null;
            this.btnDeleteCar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCar.OnIdleState.BorderRadius = 1;
            this.btnDeleteCar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCar.OnIdleState.BorderThickness = 1;
            this.btnDeleteCar.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteCar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCar.OnIdleState.IconLeftImage = null;
            this.btnDeleteCar.OnIdleState.IconRightImage = null;
            this.btnDeleteCar.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCar.OnPressedState.BorderRadius = 1;
            this.btnDeleteCar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCar.OnPressedState.BorderThickness = 1;
            this.btnDeleteCar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDeleteCar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCar.OnPressedState.IconLeftImage = null;
            this.btnDeleteCar.OnPressedState.IconRightImage = null;
            this.btnDeleteCar.Size = new System.Drawing.Size(150, 39);
            this.btnDeleteCar.TabIndex = 8;
            this.btnDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteCar.TextMarginLeft = 0;
            this.btnDeleteCar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDeleteCar.UseDefaultRadiusAndThickness = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click_1);
            // 
            // btnClearCar
            // 
            this.btnClearCar.AllowAnimations = true;
            this.btnClearCar.AllowMouseEffects = true;
            this.btnClearCar.AllowToggling = false;
            this.btnClearCar.AnimationSpeed = 200;
            this.btnClearCar.AutoGenerateColors = false;
            this.btnClearCar.AutoRoundBorders = false;
            this.btnClearCar.AutoSizeLeftIcon = true;
            this.btnClearCar.AutoSizeRightIcon = true;
            this.btnClearCar.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClearCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearCar.BackgroundImage")));
            this.btnClearCar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearCar.ButtonText = "Temizle";
            this.btnClearCar.ButtonTextMarginLeft = 0;
            this.btnClearCar.ColorContrastOnClick = 45;
            this.btnClearCar.ColorContrastOnHover = 45;
            this.btnClearCar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnClearCar.CustomizableEdges = borderEdges4;
            this.btnClearCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearCar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClearCar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClearCar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClearCar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClearCar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearCar.ForeColor = System.Drawing.Color.White;
            this.btnClearCar.IconLeft = null;
            this.btnClearCar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClearCar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClearCar.IconMarginLeft = 11;
            this.btnClearCar.IconPadding = 10;
            this.btnClearCar.IconRight = null;
            this.btnClearCar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearCar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClearCar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClearCar.IconSize = 25;
            this.btnClearCar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClearCar.IdleBorderRadius = 0;
            this.btnClearCar.IdleBorderThickness = 0;
            this.btnClearCar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClearCar.IdleIconLeftImage = null;
            this.btnClearCar.IdleIconRightImage = null;
            this.btnClearCar.IndicateFocus = false;
            this.btnClearCar.Location = new System.Drawing.Point(813, 460);
            this.btnClearCar.Name = "btnClearCar";
            this.btnClearCar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClearCar.OnDisabledState.BorderRadius = 1;
            this.btnClearCar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearCar.OnDisabledState.BorderThickness = 1;
            this.btnClearCar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearCar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClearCar.OnDisabledState.IconLeftImage = null;
            this.btnClearCar.OnDisabledState.IconRightImage = null;
            this.btnClearCar.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnClearCar.onHoverState.BorderRadius = 1;
            this.btnClearCar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearCar.onHoverState.BorderThickness = 1;
            this.btnClearCar.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnClearCar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClearCar.onHoverState.IconLeftImage = null;
            this.btnClearCar.onHoverState.IconRightImage = null;
            this.btnClearCar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnClearCar.OnIdleState.BorderRadius = 1;
            this.btnClearCar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearCar.OnIdleState.BorderThickness = 1;
            this.btnClearCar.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnClearCar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClearCar.OnIdleState.IconLeftImage = null;
            this.btnClearCar.OnIdleState.IconRightImage = null;
            this.btnClearCar.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnClearCar.OnPressedState.BorderRadius = 1;
            this.btnClearCar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearCar.OnPressedState.BorderThickness = 1;
            this.btnClearCar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClearCar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClearCar.OnPressedState.IconLeftImage = null;
            this.btnClearCar.OnPressedState.IconRightImage = null;
            this.btnClearCar.Size = new System.Drawing.Size(150, 39);
            this.btnClearCar.TabIndex = 9;
            this.btnClearCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearCar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearCar.TextMarginLeft = 0;
            this.btnClearCar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClearCar.UseDefaultRadiusAndThickness = true;
            this.btnClearCar.Click += new System.EventHandler(this.btnClearCar_Click_1);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowCustomTheming = false;
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCars.CausesValidation = false;
            this.dgvCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCars.ColumnHeadersHeight = 40;
            this.dgvCars.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvCars.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCars.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCars.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvCars.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCars.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvCars.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvCars.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvCars.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvCars.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCars.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvCars.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCars.CurrentTheme.Name = null;
            this.dgvCars.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvCars.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCars.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCars.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvCars.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCars.EnableHeadersVisualStyles = false;
            this.dgvCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvCars.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvCars.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCars.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCars.Location = new System.Drawing.Point(276, 117);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 40;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(784, 294);
            this.dgvCars.TabIndex = 21;
            this.dgvCars.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentClick);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1165, 564);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.btnClearCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtDailyPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateCar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteCar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClearCar;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvCars;
    }
}