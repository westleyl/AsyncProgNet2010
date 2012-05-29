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
            this.cUseAsync = new System.Windows.Forms.CheckBox();
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
            this.tRoadName.Location = new System.Drawing.Point(16, 100);
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
            this.tTown.Location = new System.Drawing.Point(15, 137);
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
            this.tCity.Location = new System.Drawing.Point(16, 174);
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
            this.tCounty.Location = new System.Drawing.Point(16, 211);
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
            this.tPostalCode.Location = new System.Drawing.Point(16, 248);
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
            this.tAllResults.Size = new System.Drawing.Size(627, 287);
            this.tAllResults.TabIndex = 8;
            // 
            // cUseAsync
            // 
            this.cUseAsync.AutoSize = true;
            this.cUseAsync.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cUseAsync.Checked = true;
            this.cUseAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cUseAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUseAsync.Location = new System.Drawing.Point(147, 66);
            this.cUseAsync.Name = "cUseAsync";
            this.cUseAsync.Size = new System.Drawing.Size(119, 28);
            this.cUseAsync.TabIndex = 9;
            this.cUseAsync.Text = "Use Async";
            this.cUseAsync.UseVisualStyleBackColor = true;
            // 
            // StreetLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 406);
            this.Controls.Add(this.cUseAsync);
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
        private System.Windows.Forms.CheckBox cUseAsync;
    }
}

