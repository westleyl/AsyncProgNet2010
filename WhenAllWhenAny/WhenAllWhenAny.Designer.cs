namespace WhenAllWhenAny
{
    partial class WhenAllWhenAny
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
            this.ArtistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.btnGetMetadata = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.chkFastestWins = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.Location = new System.Drawing.Point(25, 9);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(156, 31);
            this.ArtistName.TabIndex = 0;
            this.ArtistName.Text = "Artist Name";
            this.ArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName.Location = new System.Drawing.Point(188, 13);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(349, 38);
            this.txtArtistName.TabIndex = 0;
            this.txtArtistName.Text = "U2";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbumName.Location = new System.Drawing.Point(188, 57);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(349, 38);
            this.txtAlbumName.TabIndex = 1;
            this.txtAlbumName.Text = "The Joshua Tree";
            // 
            // btnGetMetadata
            // 
            this.btnGetMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMetadata.Location = new System.Drawing.Point(317, 137);
            this.btnGetMetadata.Name = "btnGetMetadata";
            this.btnGetMetadata.Size = new System.Drawing.Size(220, 44);
            this.btnGetMetadata.TabIndex = 3;
            this.btnGetMetadata.Text = "Get Metadata";
            this.btnGetMetadata.UseVisualStyleBackColor = true;
            this.btnGetMetadata.Click += new System.EventHandler(this.btnGetMetadata_Click);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(18, 187);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(518, 299);
            this.txtResults.TabIndex = 4;
            // 
            // chkFastestWins
            // 
            this.chkFastestWins.AutoSize = true;
            this.chkFastestWins.Checked = true;
            this.chkFastestWins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFastestWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFastestWins.Location = new System.Drawing.Point(380, 101);
            this.chkFastestWins.Name = "chkFastestWins";
            this.chkFastestWins.Size = new System.Drawing.Size(157, 30);
            this.chkFastestWins.TabIndex = 2;
            this.chkFastestWins.Text = "Fastest Wins";
            this.chkFastestWins.UseVisualStyleBackColor = true;
            // 
            // WhenAllWhenAny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 498);
            this.Controls.Add(this.chkFastestWins);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGetMetadata);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtistName);
            this.Name = "WhenAllWhenAny";
            this.Text = "WhenAll and WhenAny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Button btnGetMetadata;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.CheckBox chkFastestWins;
    }
}

