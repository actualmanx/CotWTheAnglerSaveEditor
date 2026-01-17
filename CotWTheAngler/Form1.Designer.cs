namespace CotWTheAngler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBrowse = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            statusStrip1 = new StatusStrip();
            lblMoney = new Label();
            txtMoneyValue = new TextBox();
            goldlabel = new Label();
            txtGoldValue = new TextBox();
            explabel = new Label();
            txtExpValue = new TextBox();
            replabel = new Label();
            txtRepUS = new TextBox();
            diamondlabel = new Label();
            legendarylabel = new Label();
            txtDiamondValue = new TextBox();
            txtLegendaryValue = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            rtbDebug = new RichTextBox();
            rtbDebugButton = new Button();
            locUsa = new Label();
            locNorway = new Label();
            txtGoldNorwayValue = new TextBox();
            txtDiamondNorwayValue = new TextBox();
            txtLegendaryNorwayValue = new TextBox();
            txtRepNorway = new TextBox();
            chkMoneyWrite = new CheckBox();
            chkExpWrite = new CheckBox();
            chkRepWrite = new CheckBox();
            locSpain = new Label();
            txtGoldSpainValue = new TextBox();
            txtDiamondSpainValue = new TextBox();
            txtLegendarySpainValue = new TextBox();
            txtRepSpain = new TextBox();
            locSouthAfrica = new Label();
            txtGoldAfricaValue = new TextBox();
            txtDiamondAfricaValue = new TextBox();
            txtLegendaryAfricaValue = new TextBox();
            txtRepAfrica = new TextBox();
            txtRepJapan = new TextBox();
            locJapan = new Label();
            txtGoldJapanValue = new TextBox();
            txtDiamondJapanValue = new TextBox();
            txtLegendaryJapanValue = new TextBox();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(1784, 29);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(172, 34);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Open File";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRead
            // 
            btnRead.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRead.Location = new Point(1784, 437);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(172, 34);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read Values";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnWrite.Location = new Point(1784, 647);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(172, 34);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Write Values";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ButtonFace;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 743);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1981, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblMoney
            // 
            lblMoney.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMoney.AutoSize = true;
            lblMoney.Location = new Point(62, 378);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(67, 25);
            lblMoney.TabIndex = 4;
            lblMoney.Text = "Money";
            // 
            // txtMoneyValue
            // 
            txtMoneyValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtMoneyValue.Location = new Point(168, 375);
            txtMoneyValue.Name = "txtMoneyValue";
            txtMoneyValue.Size = new Size(116, 31);
            txtMoneyValue.TabIndex = 6;
            // 
            // goldlabel
            // 
            goldlabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            goldlabel.AutoSize = true;
            goldlabel.Location = new Point(62, 185);
            goldlabel.Name = "goldlabel";
            goldlabel.Size = new Size(50, 25);
            goldlabel.TabIndex = 7;
            goldlabel.Text = "Gold";
            // 
            // txtGoldValue
            // 
            txtGoldValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtGoldValue.Location = new Point(168, 182);
            txtGoldValue.Name = "txtGoldValue";
            txtGoldValue.Size = new Size(65, 31);
            txtGoldValue.TabIndex = 9;
            // 
            // explabel
            // 
            explabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            explabel.AutoSize = true;
            explabel.Location = new Point(62, 434);
            explabel.Name = "explabel";
            explabel.Size = new Size(40, 25);
            explabel.TabIndex = 10;
            explabel.Text = "Exp";
            // 
            // txtExpValue
            // 
            txtExpValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtExpValue.Location = new Point(168, 431);
            txtExpValue.Name = "txtExpValue";
            txtExpValue.Size = new Size(65, 31);
            txtExpValue.TabIndex = 12;
            // 
            // replabel
            // 
            replabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            replabel.AutoSize = true;
            replabel.Location = new Point(62, 489);
            replabel.Name = "replabel";
            replabel.Size = new Size(42, 25);
            replabel.TabIndex = 13;
            replabel.Text = "Rep";
            // 
            // txtRepUS
            // 
            txtRepUS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtRepUS.Location = new Point(168, 483);
            txtRepUS.Name = "txtRepUS";
            txtRepUS.Size = new Size(65, 31);
            txtRepUS.TabIndex = 15;
            // 
            // diamondlabel
            // 
            diamondlabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            diamondlabel.AutoSize = true;
            diamondlabel.Location = new Point(62, 238);
            diamondlabel.Name = "diamondlabel";
            diamondlabel.Size = new Size(86, 25);
            diamondlabel.TabIndex = 16;
            diamondlabel.Text = "Diamond";
            // 
            // legendarylabel
            // 
            legendarylabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            legendarylabel.AutoSize = true;
            legendarylabel.Location = new Point(62, 300);
            legendarylabel.Name = "legendarylabel";
            legendarylabel.Size = new Size(94, 25);
            legendarylabel.TabIndex = 17;
            legendarylabel.Text = "Legendary";
            // 
            // txtDiamondValue
            // 
            txtDiamondValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDiamondValue.Location = new Point(168, 238);
            txtDiamondValue.Name = "txtDiamondValue";
            txtDiamondValue.Size = new Size(65, 31);
            txtDiamondValue.TabIndex = 19;
            // 
            // txtLegendaryValue
            // 
            txtLegendaryValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtLegendaryValue.Location = new Point(168, 297);
            txtLegendaryValue.Name = "txtLegendaryValue";
            txtLegendaryValue.Size = new Size(65, 31);
            txtLegendaryValue.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbDebug
            // 
            rtbDebug.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rtbDebug.Location = new Point(1287, 2);
            rtbDebug.Name = "rtbDebug";
            rtbDebug.Size = new Size(491, 297);
            rtbDebug.TabIndex = 28;
            rtbDebug.Text = "";
            // 
            // rtbDebugButton
            // 
            rtbDebugButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rtbDebugButton.Location = new Point(1666, 330);
            rtbDebugButton.Name = "rtbDebugButton";
            rtbDebugButton.Size = new Size(112, 34);
            rtbDebugButton.TabIndex = 29;
            rtbDebugButton.Text = "Clear";
            rtbDebugButton.UseVisualStyleBackColor = true;
            rtbDebugButton.Click += rtbDebugButton_Click;
            // 
            // locUsa
            // 
            locUsa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            locUsa.AutoSize = true;
            locUsa.Location = new Point(168, 117);
            locUsa.Name = "locUsa";
            locUsa.Size = new Size(34, 25);
            locUsa.TabIndex = 30;
            locUsa.Text = "US";
            // 
            // locNorway
            // 
            locNorway.AutoSize = true;
            locNorway.Location = new Point(322, 117);
            locNorway.Name = "locNorway";
            locNorway.Size = new Size(73, 25);
            locNorway.TabIndex = 31;
            locNorway.Text = "Norway";
            // 
            // txtGoldNorwayValue
            // 
            txtGoldNorwayValue.Location = new Point(322, 179);
            txtGoldNorwayValue.Name = "txtGoldNorwayValue";
            txtGoldNorwayValue.Size = new Size(65, 31);
            txtGoldNorwayValue.TabIndex = 32;
            // 
            // txtDiamondNorwayValue
            // 
            txtDiamondNorwayValue.Location = new Point(322, 238);
            txtDiamondNorwayValue.Name = "txtDiamondNorwayValue";
            txtDiamondNorwayValue.Size = new Size(65, 31);
            txtDiamondNorwayValue.TabIndex = 33;
            // 
            // txtLegendaryNorwayValue
            // 
            txtLegendaryNorwayValue.Location = new Point(322, 300);
            txtLegendaryNorwayValue.Name = "txtLegendaryNorwayValue";
            txtLegendaryNorwayValue.Size = new Size(65, 31);
            txtLegendaryNorwayValue.TabIndex = 34;
            // 
            // txtRepNorway
            // 
            txtRepNorway.Location = new Point(322, 486);
            txtRepNorway.Name = "txtRepNorway";
            txtRepNorway.Size = new Size(65, 31);
            txtRepNorway.TabIndex = 35;
            // 
            // chkMoneyWrite
            // 
            chkMoneyWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkMoneyWrite.AutoSize = true;
            chkMoneyWrite.Location = new Point(972, 378);
            chkMoneyWrite.Name = "chkMoneyWrite";
            chkMoneyWrite.Size = new Size(223, 29);
            chkMoneyWrite.TabIndex = 25;
            chkMoneyWrite.Text = "Write Value To Save File";
            chkMoneyWrite.UseVisualStyleBackColor = true;
            // 
            // chkExpWrite
            // 
            chkExpWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkExpWrite.AutoSize = true;
            chkExpWrite.Location = new Point(972, 433);
            chkExpWrite.Name = "chkExpWrite";
            chkExpWrite.Size = new Size(223, 29);
            chkExpWrite.TabIndex = 26;
            chkExpWrite.Text = "Write Value To Save File";
            chkExpWrite.UseVisualStyleBackColor = true;
            // 
            // chkRepWrite
            // 
            chkRepWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkRepWrite.AutoSize = true;
            chkRepWrite.Location = new Point(972, 488);
            chkRepWrite.Name = "chkRepWrite";
            chkRepWrite.Size = new Size(231, 29);
            chkRepWrite.TabIndex = 27;
            chkRepWrite.Text = "Write Values To Save File";
            chkRepWrite.UseVisualStyleBackColor = true;
            // 
            // locSpain
            // 
            locSpain.AutoSize = true;
            locSpain.Location = new Point(490, 117);
            locSpain.Name = "locSpain";
            locSpain.Size = new Size(56, 25);
            locSpain.TabIndex = 36;
            locSpain.Text = "Spain";
            // 
            // txtGoldSpainValue
            // 
            txtGoldSpainValue.Location = new Point(490, 179);
            txtGoldSpainValue.Name = "txtGoldSpainValue";
            txtGoldSpainValue.Size = new Size(65, 31);
            txtGoldSpainValue.TabIndex = 37;
            // 
            // txtDiamondSpainValue
            // 
            txtDiamondSpainValue.Location = new Point(490, 238);
            txtDiamondSpainValue.Name = "txtDiamondSpainValue";
            txtDiamondSpainValue.Size = new Size(65, 31);
            txtDiamondSpainValue.TabIndex = 38;
            // 
            // txtLegendarySpainValue
            // 
            txtLegendarySpainValue.Location = new Point(490, 300);
            txtLegendarySpainValue.Name = "txtLegendarySpainValue";
            txtLegendarySpainValue.Size = new Size(65, 31);
            txtLegendarySpainValue.TabIndex = 39;
            // 
            // txtRepSpain
            // 
            txtRepSpain.Location = new Point(490, 486);
            txtRepSpain.Name = "txtRepSpain";
            txtRepSpain.Size = new Size(65, 31);
            txtRepSpain.TabIndex = 40;
            // 
            // locSouthAfrica
            // 
            locSouthAfrica.AutoSize = true;
            locSouthAfrica.Location = new Point(655, 117);
            locSouthAfrica.Name = "locSouthAfrica";
            locSouthAfrica.Size = new Size(109, 25);
            locSouthAfrica.TabIndex = 41;
            locSouthAfrica.Text = "South Africa";
            // 
            // txtGoldAfricaValue
            // 
            txtGoldAfricaValue.Location = new Point(655, 179);
            txtGoldAfricaValue.Name = "txtGoldAfricaValue";
            txtGoldAfricaValue.Size = new Size(65, 31);
            txtGoldAfricaValue.TabIndex = 42;
            // 
            // txtDiamondAfricaValue
            // 
            txtDiamondAfricaValue.Location = new Point(655, 238);
            txtDiamondAfricaValue.Name = "txtDiamondAfricaValue";
            txtDiamondAfricaValue.Size = new Size(65, 31);
            txtDiamondAfricaValue.TabIndex = 43;
            // 
            // txtLegendaryAfricaValue
            // 
            txtLegendaryAfricaValue.Location = new Point(655, 300);
            txtLegendaryAfricaValue.Name = "txtLegendaryAfricaValue";
            txtLegendaryAfricaValue.Size = new Size(65, 31);
            txtLegendaryAfricaValue.TabIndex = 44;
            // 
            // txtRepAfrica
            // 
            txtRepAfrica.Location = new Point(655, 483);
            txtRepAfrica.Name = "txtRepAfrica";
            txtRepAfrica.Size = new Size(65, 31);
            txtRepAfrica.TabIndex = 45;
            // 
            // txtRepJapan
            // 
            txtRepJapan.Location = new Point(809, 483);
            txtRepJapan.Name = "txtRepJapan";
            txtRepJapan.Size = new Size(65, 31);
            txtRepJapan.TabIndex = 46;
            // 
            // locJapan
            // 
            locJapan.AutoSize = true;
            locJapan.Location = new Point(809, 117);
            locJapan.Name = "locJapan";
            locJapan.Size = new Size(57, 25);
            locJapan.TabIndex = 47;
            locJapan.Text = "Japan";
            // 
            // txtGoldJapanValue
            // 
            txtGoldJapanValue.Location = new Point(809, 179);
            txtGoldJapanValue.Name = "txtGoldJapanValue";
            txtGoldJapanValue.Size = new Size(65, 31);
            txtGoldJapanValue.TabIndex = 48;
            // 
            // txtDiamondJapanValue
            // 
            txtDiamondJapanValue.Location = new Point(809, 238);
            txtDiamondJapanValue.Name = "txtDiamondJapanValue";
            txtDiamondJapanValue.Size = new Size(65, 31);
            txtDiamondJapanValue.TabIndex = 49;
            // 
            // txtLegendaryJapanValue
            // 
            txtLegendaryJapanValue.Location = new Point(809, 300);
            txtLegendaryJapanValue.Name = "txtLegendaryJapanValue";
            txtLegendaryJapanValue.Size = new Size(65, 31);
            txtLegendaryJapanValue.TabIndex = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1981, 765);
            Controls.Add(txtLegendaryJapanValue);
            Controls.Add(txtDiamondJapanValue);
            Controls.Add(txtGoldJapanValue);
            Controls.Add(locJapan);
            Controls.Add(txtRepJapan);
            Controls.Add(txtRepAfrica);
            Controls.Add(txtLegendaryAfricaValue);
            Controls.Add(txtDiamondAfricaValue);
            Controls.Add(txtGoldAfricaValue);
            Controls.Add(locSouthAfrica);
            Controls.Add(txtRepSpain);
            Controls.Add(txtLegendarySpainValue);
            Controls.Add(txtDiamondSpainValue);
            Controls.Add(txtGoldSpainValue);
            Controls.Add(locSpain);
            Controls.Add(txtRepNorway);
            Controls.Add(txtLegendaryNorwayValue);
            Controls.Add(txtDiamondNorwayValue);
            Controls.Add(txtGoldNorwayValue);
            Controls.Add(locNorway);
            Controls.Add(locUsa);
            Controls.Add(rtbDebugButton);
            Controls.Add(rtbDebug);
            Controls.Add(chkRepWrite);
            Controls.Add(chkExpWrite);
            Controls.Add(chkMoneyWrite);
            Controls.Add(txtLegendaryValue);
            Controls.Add(txtDiamondValue);
            Controls.Add(legendarylabel);
            Controls.Add(diamondlabel);
            Controls.Add(txtRepUS);
            Controls.Add(replabel);
            Controls.Add(txtExpValue);
            Controls.Add(explabel);
            Controls.Add(txtGoldValue);
            Controls.Add(goldlabel);
            Controls.Add(txtMoneyValue);
            Controls.Add(lblMoney);
            Controls.Add(statusStrip1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnBrowse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CotW The Angler Save Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button btnRead;
        private Button btnWrite;
        private StatusStrip statusStrip1;
        private Label lblMoney;
        private TextBox txtMoneyValue;
        private Label goldlabel;
        private TextBox txtGoldValue;
        private Label explabel;
        private TextBox txtExpValue;
        private Label replabel;
        private TextBox txtRepUS;
        private Label diamondlabel;
        private Label legendarylabel;
        private TextBox txtDiamondValue;
        private TextBox txtLegendaryValue;
        private OpenFileDialog openFileDialog1;
        private RichTextBox rtbDebug;
        private Button rtbDebugButton;
        private Label locUsa;
        private Label locNorway;
        private TextBox txtGoldNorwayValue;
        private TextBox txtDiamondNorwayValue;
        private TextBox txtLegendaryNorwayValue;
        private TextBox txtRepNorway;
        private CheckBox chkMoneyWrite;
        private CheckBox chkExpWrite;
        private CheckBox chkRepWrite;
        private Label locSpain;
        private TextBox txtGoldSpainValue;
        private TextBox txtDiamondSpainValue;
        private TextBox txtLegendarySpainValue;
        private TextBox txtRepSpain;
        private Label locSouthAfrica;
        private TextBox txtGoldAfricaValue;
        private TextBox txtDiamondAfricaValue;
        private TextBox txtLegendaryAfricaValue;
        private TextBox txtRepAfrica;
        private TextBox txtRepJapan;
        private Label locJapan;
        private TextBox txtGoldJapanValue;
        private TextBox txtDiamondJapanValue;
        private TextBox txtLegendaryJapanValue;
    }
}
