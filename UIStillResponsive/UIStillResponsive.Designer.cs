namespace WhenAllWhenAny
{
    partial class frmUIStillResponsive
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
            this.btnEatMe = new System.Windows.Forms.Button();
            this.btnDrinkMe = new System.Windows.Forms.Button();
            this.txtBodilyNoises = new System.Windows.Forms.TextBox();
            this.lblPlayingCardsCounted = new System.Windows.Forms.Label();
            this.btnCountCards = new System.Windows.Forms.Button();
            this.chkUseAsync = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnEatMe
            // 
            this.btnEatMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatMe.Location = new System.Drawing.Point(12, 12);
            this.btnEatMe.Name = "btnEatMe";
            this.btnEatMe.Size = new System.Drawing.Size(137, 37);
            this.btnEatMe.TabIndex = 0;
            this.btnEatMe.Text = "Eat Me";
            this.btnEatMe.UseVisualStyleBackColor = true;
            this.btnEatMe.Click += new System.EventHandler(this.btnEatMe_Click);
            // 
            // btnDrinkMe
            // 
            this.btnDrinkMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinkMe.Location = new System.Drawing.Point(12, 79);
            this.btnDrinkMe.Name = "btnDrinkMe";
            this.btnDrinkMe.Size = new System.Drawing.Size(137, 37);
            this.btnDrinkMe.TabIndex = 0;
            this.btnDrinkMe.Text = "Drink Me";
            this.btnDrinkMe.UseVisualStyleBackColor = true;
            this.btnDrinkMe.Click += new System.EventHandler(this.btnDrinkMe_Click);
            // 
            // txtBodilyNoises
            // 
            this.txtBodilyNoises.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodilyNoises.Location = new System.Drawing.Point(172, 15);
            this.txtBodilyNoises.Multiline = true;
            this.txtBodilyNoises.Name = "txtBodilyNoises";
            this.txtBodilyNoises.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBodilyNoises.Size = new System.Drawing.Size(325, 345);
            this.txtBodilyNoises.TabIndex = 1;
            // 
            // lblPlayingCardsCounted
            // 
            this.lblPlayingCardsCounted.AutoSize = true;
            this.lblPlayingCardsCounted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingCardsCounted.Location = new System.Drawing.Point(6, 288);
            this.lblPlayingCardsCounted.Name = "lblPlayingCardsCounted";
            this.lblPlayingCardsCounted.Size = new System.Drawing.Size(322, 31);
            this.lblPlayingCardsCounted.TabIndex = 2;
            this.lblPlayingCardsCounted.Text = "[lblPlayingCardsCounted]";
            // 
            // btnCountCards
            // 
            this.btnCountCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountCards.Location = new System.Drawing.Point(12, 164);
            this.btnCountCards.Name = "btnCountCards";
            this.btnCountCards.Size = new System.Drawing.Size(137, 78);
            this.btnCountCards.TabIndex = 0;
            this.btnCountCards.Text = "Count Cards";
            this.btnCountCards.UseVisualStyleBackColor = true;
            this.btnCountCards.Click += new System.EventHandler(this.btnCountCards_Click);
            // 
            // chkUseAsync
            // 
            this.chkUseAsync.AutoSize = true;
            this.chkUseAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseAsync.Location = new System.Drawing.Point(12, 248);
            this.chkUseAsync.Name = "chkUseAsync";
            this.chkUseAsync.Size = new System.Drawing.Size(136, 30);
            this.chkUseAsync.TabIndex = 3;
            this.chkUseAsync.Text = "Use Async";
            this.chkUseAsync.UseVisualStyleBackColor = true;
            // 
            // frmUIStillResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 374);
            this.Controls.Add(this.chkUseAsync);
            this.Controls.Add(this.lblPlayingCardsCounted);
            this.Controls.Add(this.txtBodilyNoises);
            this.Controls.Add(this.btnCountCards);
            this.Controls.Add(this.btnDrinkMe);
            this.Controls.Add(this.btnEatMe);
            this.Name = "frmUIStillResponsive";
            this.Text = "UI Still Responsive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEatMe;
        private System.Windows.Forms.Button btnDrinkMe;
        private System.Windows.Forms.TextBox txtBodilyNoises;
        private System.Windows.Forms.Label lblPlayingCardsCounted;
        private System.Windows.Forms.Button btnCountCards;
        private System.Windows.Forms.CheckBox chkUseAsync;
    }
}

