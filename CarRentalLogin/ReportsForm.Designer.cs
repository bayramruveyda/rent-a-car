namespace CarRentalLogin
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.chkUseDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReports = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnApplyFilter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(118, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durum:";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(205, 131);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbStatusFilter.TabIndex = 1;
            // 
            // chkUseDate
            // 
            this.chkUseDate.AutoSize = true;
            this.chkUseDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkUseDate.Location = new System.Drawing.Point(443, 164);
            this.chkUseDate.Name = "chkUseDate";
            this.chkUseDate.Size = new System.Drawing.Size(137, 20);
            this.chkUseDate.TabIndex = 2;
            this.chkUseDate.Text = "Tarihe göre filtrele";
            this.chkUseDate.UseVisualStyleBackColor = true;
            this.chkUseDate.CheckedChanged += new System.EventHandler(this.chkUseDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(119, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(205, 162);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(119, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(205, 201);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 6;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalRevenue.Location = new System.Drawing.Point(182, 251);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(125, 16);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "Toplam Gelir: 0,00 ₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(441, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "Raporlar";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReports.ColumnHeadersHeight = 40;
            this.dgvReports.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvReports.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvReports.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReports.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvReports.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReports.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvReports.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvReports.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvReports.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvReports.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReports.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvReports.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReports.CurrentTheme.Name = null;
            this.dgvReports.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvReports.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvReports.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReports.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvReports.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvReports.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvReports.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvReports.HeaderForeColor = System.Drawing.Color.White;
            this.dgvReports.Location = new System.Drawing.Point(165, 355);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 40;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(757, 285);
            this.dgvReports.TabIndex = 11;
            this.dgvReports.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.AllowAnimations = true;
            this.btnApplyFilter.AllowMouseEffects = true;
            this.btnApplyFilter.AllowToggling = false;
            this.btnApplyFilter.AnimationSpeed = 200;
            this.btnApplyFilter.AutoGenerateColors = false;
            this.btnApplyFilter.AutoRoundBorders = false;
            this.btnApplyFilter.AutoSizeLeftIcon = true;
            this.btnApplyFilter.AutoSizeRightIcon = true;
            this.btnApplyFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyFilter.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnApplyFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApplyFilter.BackgroundImage")));
            this.btnApplyFilter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyFilter.ButtonText = "Filtrele";
            this.btnApplyFilter.ButtonTextMarginLeft = 0;
            this.btnApplyFilter.ColorContrastOnClick = 45;
            this.btnApplyFilter.ColorContrastOnHover = 45;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnApplyFilter.CustomizableEdges = borderEdges1;
            this.btnApplyFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApplyFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApplyFilter.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnApplyFilter.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnApplyFilter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.IconLeft = null;
            this.btnApplyFilter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplyFilter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnApplyFilter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnApplyFilter.IconMarginLeft = 11;
            this.btnApplyFilter.IconPadding = 10;
            this.btnApplyFilter.IconRight = null;
            this.btnApplyFilter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplyFilter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnApplyFilter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnApplyFilter.IconSize = 25;
            this.btnApplyFilter.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnApplyFilter.IdleBorderRadius = 0;
            this.btnApplyFilter.IdleBorderThickness = 0;
            this.btnApplyFilter.IdleFillColor = System.Drawing.Color.Empty;
            this.btnApplyFilter.IdleIconLeftImage = null;
            this.btnApplyFilter.IdleIconRightImage = null;
            this.btnApplyFilter.IndicateFocus = false;
            this.btnApplyFilter.Location = new System.Drawing.Point(451, 287);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApplyFilter.OnDisabledState.BorderRadius = 1;
            this.btnApplyFilter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyFilter.OnDisabledState.BorderThickness = 1;
            this.btnApplyFilter.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApplyFilter.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnApplyFilter.OnDisabledState.IconLeftImage = null;
            this.btnApplyFilter.OnDisabledState.IconRightImage = null;
            this.btnApplyFilter.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnApplyFilter.onHoverState.BorderRadius = 1;
            this.btnApplyFilter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyFilter.onHoverState.BorderThickness = 1;
            this.btnApplyFilter.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnApplyFilter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.onHoverState.IconLeftImage = null;
            this.btnApplyFilter.onHoverState.IconRightImage = null;
            this.btnApplyFilter.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnApplyFilter.OnIdleState.BorderRadius = 1;
            this.btnApplyFilter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyFilter.OnIdleState.BorderThickness = 1;
            this.btnApplyFilter.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnApplyFilter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.OnIdleState.IconLeftImage = null;
            this.btnApplyFilter.OnIdleState.IconRightImage = null;
            this.btnApplyFilter.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApplyFilter.OnPressedState.BorderRadius = 1;
            this.btnApplyFilter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyFilter.OnPressedState.BorderThickness = 1;
            this.btnApplyFilter.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApplyFilter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.OnPressedState.IconLeftImage = null;
            this.btnApplyFilter.OnPressedState.IconRightImage = null;
            this.btnApplyFilter.Size = new System.Drawing.Size(177, 49);
            this.btnApplyFilter.TabIndex = 12;
            this.btnApplyFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplyFilter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApplyFilter.TextMarginLeft = 0;
            this.btnApplyFilter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnApplyFilter.UseDefaultRadiusAndThickness = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1147, 710);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkUseDate);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.label1);
            this.Name = "ReportsForm";
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.CheckBox chkUseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvReports;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnApplyFilter;
    }
}