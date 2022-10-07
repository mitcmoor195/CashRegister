namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.hatLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.robesLabel = new System.Windows.Forms.Label();
            this.hatsInput = new System.Windows.Forms.NumericUpDown();
            this.robesInput = new System.Windows.Forms.NumericUpDown();
            this.booksInput = new System.Windows.Forms.NumericUpDown();
            this.priceButton = new System.Windows.Forms.Button();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptTitle = new System.Windows.Forms.Label();
            this.receiptLeft = new System.Windows.Forms.Label();
            this.receiptRight = new System.Windows.Forms.Label();
            this.receiptBottom = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.seperationBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hatsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(-4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(847, 56);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Ye Olde Wizard Shoppe";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hatLabel
            // 
            this.hatLabel.BackColor = System.Drawing.Color.Transparent;
            this.hatLabel.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hatLabel.Location = new System.Drawing.Point(0, 68);
            this.hatLabel.Name = "hatLabel";
            this.hatLabel.Size = new System.Drawing.Size(175, 40);
            this.hatLabel.TabIndex = 1;
            this.hatLabel.Text = "Wizard Hats";
            this.hatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookLabel
            // 
            this.bookLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookLabel.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookLabel.Location = new System.Drawing.Point(0, 172);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(176, 40);
            this.bookLabel.TabIndex = 2;
            this.bookLabel.Text = "Spellbooks";
            this.bookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // robesLabel
            // 
            this.robesLabel.BackColor = System.Drawing.Color.Transparent;
            this.robesLabel.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.robesLabel.Location = new System.Drawing.Point(-1, 121);
            this.robesLabel.Name = "robesLabel";
            this.robesLabel.Size = new System.Drawing.Size(177, 40);
            this.robesLabel.TabIndex = 3;
            this.robesLabel.Text = "Wizard Robes";
            this.robesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hatsInput
            // 
            this.hatsInput.BackColor = System.Drawing.Color.Wheat;
            this.hatsInput.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatsInput.Location = new System.Drawing.Point(222, 70);
            this.hatsInput.Name = "hatsInput";
            this.hatsInput.Size = new System.Drawing.Size(120, 40);
            this.hatsInput.TabIndex = 4;
            this.hatsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // robesInput
            // 
            this.robesInput.BackColor = System.Drawing.Color.Wheat;
            this.robesInput.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robesInput.Location = new System.Drawing.Point(222, 123);
            this.robesInput.Name = "robesInput";
            this.robesInput.Size = new System.Drawing.Size(120, 40);
            this.robesInput.TabIndex = 5;
            this.robesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // booksInput
            // 
            this.booksInput.BackColor = System.Drawing.Color.Wheat;
            this.booksInput.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksInput.Location = new System.Drawing.Point(222, 174);
            this.booksInput.Name = "booksInput";
            this.booksInput.Size = new System.Drawing.Size(120, 40);
            this.booksInput.TabIndex = 6;
            this.booksInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.booksInput.ThousandsSeparator = true;
            // 
            // priceButton
            // 
            this.priceButton.BackColor = System.Drawing.Color.Transparent;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.priceButton.Location = new System.Drawing.Point(84, 220);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(215, 65);
            this.priceButton.TabIndex = 7;
            this.priceButton.Text = "Calculate Price";
            this.priceButton.UseVisualStyleBackColor = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.taxLabel.Location = new System.Drawing.Point(12, 328);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(164, 40);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalLabel.Location = new System.Drawing.Point(12, 368);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(164, 40);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 288);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(164, 40);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutput.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subtotalOutput.Location = new System.Drawing.Point(222, 288);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(120, 40);
            this.subtotalOutput.TabIndex = 12;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.taxOutput.Location = new System.Drawing.Point(222, 328);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(120, 40);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalOutput.Location = new System.Drawing.Point(222, 368);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(120, 40);
            this.totalOutput.TabIndex = 14;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 427);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(164, 40);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Amount Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.Enabled = false;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeButton.Location = new System.Drawing.Point(75, 470);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(224, 52);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeLabel.Location = new System.Drawing.Point(12, 525);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(164, 40);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change Owed";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Transparent;
            this.receiptButton.Enabled = false;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.receiptButton.Location = new System.Drawing.Point(75, 578);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(224, 81);
            this.receiptButton.TabIndex = 19;
            this.receiptButton.Text = "Confirm Order?";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.BackColor = System.Drawing.Color.Wheat;
            this.tenderedInput.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(227, 435);
            this.tenderedInput.Multiline = true;
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(115, 29);
            this.tenderedInput.TabIndex = 20;
            this.tenderedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tenderedInput.Visible = false;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeOutput.Location = new System.Drawing.Point(222, 525);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(120, 40);
            this.changeOutput.TabIndex = 21;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptTitle
            // 
            this.receiptTitle.BackColor = System.Drawing.Color.Wheat;
            this.receiptTitle.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTitle.Location = new System.Drawing.Point(454, 107);
            this.receiptTitle.Name = "receiptTitle";
            this.receiptTitle.Size = new System.Drawing.Size(326, 54);
            this.receiptTitle.TabIndex = 23;
            this.receiptTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptLeft
            // 
            this.receiptLeft.BackColor = System.Drawing.Color.Wheat;
            this.receiptLeft.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLeft.Location = new System.Drawing.Point(454, 161);
            this.receiptLeft.Name = "receiptLeft";
            this.receiptLeft.Size = new System.Drawing.Size(160, 230);
            this.receiptLeft.TabIndex = 24;
            // 
            // receiptRight
            // 
            this.receiptRight.BackColor = System.Drawing.Color.Wheat;
            this.receiptRight.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptRight.Location = new System.Drawing.Point(614, 161);
            this.receiptRight.Name = "receiptRight";
            this.receiptRight.Size = new System.Drawing.Size(166, 230);
            this.receiptRight.TabIndex = 25;
            this.receiptRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptBottom
            // 
            this.receiptBottom.BackColor = System.Drawing.Color.Wheat;
            this.receiptBottom.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBottom.Location = new System.Drawing.Point(454, 391);
            this.receiptBottom.Name = "receiptBottom";
            this.receiptBottom.Size = new System.Drawing.Size(326, 54);
            this.receiptBottom.TabIndex = 26;
            this.receiptBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // neworderButton
            // 
            this.neworderButton.BackColor = System.Drawing.Color.Transparent;
            this.neworderButton.Enabled = false;
            this.neworderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neworderButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.neworderButton.Location = new System.Drawing.Point(457, 525);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(323, 117);
            this.neworderButton.TabIndex = 27;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // seperationBar
            // 
            this.seperationBar.BackColor = System.Drawing.Color.Black;
            this.seperationBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.seperationBar.Location = new System.Drawing.Point(-4, 408);
            this.seperationBar.Name = "seperationBar";
            this.seperationBar.Size = new System.Drawing.Size(346, 19);
            this.seperationBar.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::CashRegister.Properties.Resources.registerbackground;
            this.ClientSize = new System.Drawing.Size(841, 671);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptBottom);
            this.Controls.Add(this.receiptRight);
            this.Controls.Add(this.receiptLeft);
            this.Controls.Add(this.receiptTitle);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.seperationBar);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.booksInput);
            this.Controls.Add(this.robesInput);
            this.Controls.Add(this.hatsInput);
            this.Controls.Add(this.robesLabel);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.hatLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wizard Shoppe";
            ((System.ComponentModel.ISupportInitialize)(this.hatsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hatLabel;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Label robesLabel;
        private System.Windows.Forms.NumericUpDown hatsInput;
        private System.Windows.Forms.NumericUpDown robesInput;
        private System.Windows.Forms.NumericUpDown booksInput;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label receiptTitle;
        private System.Windows.Forms.Label receiptLeft;
        private System.Windows.Forms.Label receiptRight;
        private System.Windows.Forms.Label receiptBottom;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label seperationBar;
    }
}

