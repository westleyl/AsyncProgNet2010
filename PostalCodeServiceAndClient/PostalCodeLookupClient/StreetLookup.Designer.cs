namespace PostalCodeClient
{
    partial class StreetLookup
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
            this.bFindStreet = new System.Windows.Forms.Button();
            this.tSearchPostalCode = new System.Windows.Forms.TextBox();
            this.tRoadName = new System.Windows.Forms.TextBox();
            this.tTown = new System.Windows.Forms.TextBox();
            this.tCity = new System.Windows.Forms.TextBox();
            this.tCounty = new System.Windows.Forms.TextBox();
            this.tPostalCode = new System.Windows.Forms.TextBox();
            this.tProgress = new System.Windows.Forms.TextBox();
            this.tAllResults = new System.Windows.Forms.TextBox();
            this.gbAsync = new System.Windows.Forms.GroupBox();
            this.rWhenAny = new System.Windows.Forms.RadioButton();
            this.rWhenAll = new System.Windows.Forms.RadioButton();
            this.cUseAsync = new System.Windows.Forms.CheckBox();
            this.gServices = new System.Windows.Forms.GroupBox();
            this.rMixed = new System.Windows.Forms.RadioButton();
            this.rSlowService = new System.Windows.Forms.RadioButton();
            this.rFastService = new System.Windows.Forms.RadioButton();
            this.bClear = new System.Windows.Forms.Button();
            this.gbAsync.SuspendLayout();
            this.gServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFindStreet
            // 
            this.bFindStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFindStreet.Location = new System.Drawing.Point(15, 27);
            this.bFindStreet.Name = "bFindStreet";
            this.bFindStreet.Size = new System.Drawing.Size(251, 39);
            this.bFindStreet.TabIndex = 0;
            this.bFindStreet.Text = "Find Street";
            this.bFindStreet.UseVisualStyleBackColor = true;
            this.bFindStreet.Click += new System.EventHandler(this.bFindStreet_Click);
            // 
            // tSearchPostalCode
            // 
            this.tSearchPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearchPostalCode.Location = new System.Drawing.Point(289, 28);
            this.tSearchPostalCode.Name = "tSearchPostalCode";
            this.tSearchPostalCode.Size = new System.Drawing.Size(627, 31);
            this.tSearchPostalCode.TabIndex = 1;
            this.tSearchPostalCode.Text = ",BB12 0AZ, BT324GF, BT324GF, EN55XQ, KA71RQ";
            // 
            // tRoadName
            // 
            this.tRoadName.Enabled = false;
            this.tRoadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRoadName.Location = new System.Drawing.Point(16, 208);
            this.tRoadName.Name = "tRoadName";
            this.tRoadName.ReadOnly = true;
            this.tRoadName.Size = new System.Drawing.Size(254, 31);
            this.tRoadName.TabIndex = 2;
            this.tRoadName.Text = "Road Name";
            // 
            // tTown
            // 
            this.tTown.Enabled = false;
            this.tTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTown.Location = new System.Drawing.Point(15, 245);
            this.tTown.Name = "tTown";
            this.tTown.ReadOnly = true;
            this.tTown.Size = new System.Drawing.Size(254, 31);
            this.tTown.TabIndex = 3;
            this.tTown.Text = "Town";
            this.tTown.TextChanged += new System.EventHandler(this.tTown_TextChanged);
            // 
            // tCity
            // 
            this.tCity.Enabled = false;
            this.tCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCity.Location = new System.Drawing.Point(16, 282);
            this.tCity.Name = "tCity";
            this.tCity.ReadOnly = true;
            this.tCity.Size = new System.Drawing.Size(254, 31);
            this.tCity.TabIndex = 4;
            this.tCity.Text = "City";
            // 
            // tCounty
            // 
            this.tCounty.Enabled = false;
            this.tCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCounty.Location = new System.Drawing.Point(16, 319);
            this.tCounty.Name = "tCounty";
            this.tCounty.ReadOnly = true;
            this.tCounty.Size = new System.Drawing.Size(254, 31);
            this.tCounty.TabIndex = 5;
            this.tCounty.Text = "County";
            // 
            // tPostalCode
            // 
            this.tPostalCode.Enabled = false;
            this.tPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPostalCode.Location = new System.Drawing.Point(16, 356);
            this.tPostalCode.Name = "tPostalCode";
            this.tPostalCode.ReadOnly = true;
            this.tPostalCode.Size = new System.Drawing.Size(254, 31);
            this.tPostalCode.TabIndex = 6;
            this.tPostalCode.Text = "Postal Code";
            // 
            // tProgress
            // 
            this.tProgress.Enabled = false;
            this.tProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProgress.Location = new System.Drawing.Point(289, 65);
            this.tProgress.Name = "tProgress";
            this.tProgress.ReadOnly = true;
            this.tProgress.Size = new System.Drawing.Size(254, 29);
            this.tProgress.TabIndex = 7;
            // 
            // tAllResults
            // 
            this.tAllResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAllResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAllResults.Location = new System.Drawing.Point(289, 100);
            this.tAllResults.Multiline = true;
            this.tAllResults.Name = "tAllResults";
            this.tAllResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tAllResults.Size = new System.Drawing.Size(622, 287);
            this.tAllResults.TabIndex = 8;
            // 
            // gbAsync
            // 
            this.gbAsync.Controls.Add(this.rWhenAny);
            this.gbAsync.Controls.Add(this.rWhenAll);
            this.gbAsync.Controls.Add(this.cUseAsync);
            this.gbAsync.Location = new System.Drawing.Point(134, 72);
            this.gbAsync.Name = "gbAsync";
            this.gbAsync.Size = new System.Drawing.Size(136, 114);
            this.gbAsync.TabIndex = 15;
            this.gbAsync.TabStop = false;
            // 
            // rWhenAny
            // 
            this.rWhenAny.AutoSize = true;
            this.rWhenAny.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rWhenAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWhenAny.Location = new System.Drawing.Point(24, 80);
            this.rWhenAny.Name = "rWhenAny";
            this.rWhenAny.Size = new System.Drawing.Size(106, 26);
            this.rWhenAny.TabIndex = 14;
            this.rWhenAny.Text = "WhenAny";
            this.rWhenAny.UseVisualStyleBackColor = true;
            // 
            // rWhenAll
            // 
            this.rWhenAll.AutoSize = true;
            this.rWhenAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rWhenAll.Checked = true;
            this.rWhenAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWhenAll.Location = new System.Drawing.Point(35, 48);
            this.rWhenAll.Name = "rWhenAll";
            this.rWhenAll.Size = new System.Drawing.Size(95, 26);
            this.rWhenAll.TabIndex = 13;
            this.rWhenAll.Text = "WhenAll";
            this.rWhenAll.UseVisualStyleBackColor = true;
            // 
            // cUseAsync
            // 
            this.cUseAsync.AutoSize = true;
            this.cUseAsync.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cUseAsync.Checked = true;
            this.cUseAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cUseAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUseAsync.Location = new System.Drawing.Point(11, 14);
            this.cUseAsync.Name = "cUseAsync";
            this.cUseAsync.Size = new System.Drawing.Size(119, 28);
            this.cUseAsync.TabIndex = 12;
            this.cUseAsync.Text = "Use Async";
            this.cUseAsync.UseVisualStyleBackColor = true;
            // 
            // gServices
            // 
            this.gServices.Controls.Add(this.rMixed);
            this.gServices.Controls.Add(this.rSlowService);
            this.gServices.Controls.Add(this.rFastService);
            this.gServices.Location = new System.Drawing.Point(16, 72);
            this.gServices.Name = "gServices";
            this.gServices.Size = new System.Drawing.Size(112, 114);
            this.gServices.TabIndex = 16;
            this.gServices.TabStop = false;
            // 
            // rMixed
            // 
            this.rMixed.AutoSize = true;
            this.rMixed.Enabled = false;
            this.rMixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMixed.Location = new System.Drawing.Point(16, 82);
            this.rMixed.Name = "rMixed";
            this.rMixed.Size = new System.Drawing.Size(80, 28);
            this.rMixed.TabIndex = 17;
            this.rMixed.Text = "Mixed";
            this.rMixed.UseVisualStyleBackColor = true;
            // 
            // rSlowService
            // 
            this.rSlowService.AutoSize = true;
            this.rSlowService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSlowService.Location = new System.Drawing.Point(16, 48);
            this.rSlowService.Name = "rSlowService";
            this.rSlowService.Size = new System.Drawing.Size(69, 28);
            this.rSlowService.TabIndex = 16;
            this.rSlowService.Text = "Slow";
            this.rSlowService.UseVisualStyleBackColor = true;
            // 
            // rFastService
            // 
            this.rFastService.AutoSize = true;
            this.rFastService.Checked = true;
            this.rFastService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFastService.Location = new System.Drawing.Point(16, 14);
            this.rFastService.Name = "rFastService";
            this.rFastService.Size = new System.Drawing.Size(63, 28);
            this.rFastService.TabIndex = 15;
            this.rFastService.Text = "Fast";
            this.rFastService.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(802, 393);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(109, 28);
            this.bClear.TabIndex = 17;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            // 
            // StreetLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 433);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.gServices);
            this.Controls.Add(this.gbAsync);
            this.Controls.Add(this.tAllResults);
            this.Controls.Add(this.tProgress);
            this.Controls.Add(this.tPostalCode);
            this.Controls.Add(this.tCounty);
            this.Controls.Add(this.tCity);
            this.Controls.Add(this.tTown);
            this.Controls.Add(this.tRoadName);
            this.Controls.Add(this.tSearchPostalCode);
            this.Controls.Add(this.bFindStreet);
            this.Name = "StreetLookup";
            this.Text = "Form1";
            this.gbAsync.ResumeLayout(false);
            this.gbAsync.PerformLayout();
            this.gServices.ResumeLayout(false);
            this.gServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFindStreet;
        private System.Windows.Forms.TextBox tSearchPostalCode;
        private System.Windows.Forms.TextBox tRoadName;
        private System.Windows.Forms.TextBox tTown;
        private System.Windows.Forms.TextBox tCity;
        private System.Windows.Forms.TextBox tCounty;
        private System.Windows.Forms.TextBox tPostalCode;
        private System.Windows.Forms.TextBox tProgress;
        private System.Windows.Forms.TextBox tAllResults;
        private System.Windows.Forms.GroupBox gbAsync;
        private System.Windows.Forms.RadioButton rWhenAny;
        private System.Windows.Forms.RadioButton rWhenAll;
        private System.Windows.Forms.CheckBox cUseAsync;
        private System.Windows.Forms.GroupBox gServices;
        private System.Windows.Forms.RadioButton rMixed;
        private System.Windows.Forms.RadioButton rSlowService;
        private System.Windows.Forms.RadioButton rFastService;
        private System.Windows.Forms.Button bClear;
    }
}

