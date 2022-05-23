namespace Praktikum_AD_Week_13
{
    partial class PraktikumWeek13
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtBoxPlayerID = new System.Windows.Forms.TextBox();
            this.txtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.dtPickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.numUpDownTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.cbBoxNationality = new System.Windows.Forms.ComboBox();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(66, 35);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(113, 62);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(201, 35);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(113, 62);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(340, 35);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 62);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(482, 35);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(113, 62);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(66, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(248, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(248, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(96, 132);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(73, 20);
            this.lblPlayerID.TabIndex = 6;
            this.lblPlayerID.Text = "Player ID";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(96, 184);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(98, 20);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(96, 234);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(77, 20);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "BirthDate";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(97, 282);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(82, 20);
            this.lblNationality.TabIndex = 9;
            this.lblNationality.Text = "Nationality";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(97, 328);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(49, 20);
            this.lblTeam.TabIndex = 10;
            this.lblTeam.Text = "Team";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Location = new System.Drawing.Point(96, 373);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(109, 20);
            this.lblTeamNumber.TabIndex = 11;
            this.lblTeamNumber.Text = "Team Number";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(425, 373);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(21, 20);
            this.lblAvailable.TabIndex = 12;
            this.lblAvailable.Text = "...";
            // 
            // txtBoxPlayerID
            // 
            this.txtBoxPlayerID.Location = new System.Drawing.Point(229, 132);
            this.txtBoxPlayerID.Name = "txtBoxPlayerID";
            this.txtBoxPlayerID.Size = new System.Drawing.Size(224, 26);
            this.txtBoxPlayerID.TabIndex = 13;
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.Location = new System.Drawing.Point(229, 184);
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.Size = new System.Drawing.Size(359, 26);
            this.txtBoxPlayerName.TabIndex = 14;
            // 
            // dtPickerBirthDate
            // 
            this.dtPickerBirthDate.CustomFormat = "dddd, MMMM dd,  yyyy";
            this.dtPickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerBirthDate.Location = new System.Drawing.Point(230, 234);
            this.dtPickerBirthDate.Name = "dtPickerBirthDate";
            this.dtPickerBirthDate.Size = new System.Drawing.Size(359, 26);
            this.dtPickerBirthDate.TabIndex = 15;
            // 
            // numUpDownTeamNumber
            // 
            this.numUpDownTeamNumber.Location = new System.Drawing.Point(229, 367);
            this.numUpDownTeamNumber.Name = "numUpDownTeamNumber";
            this.numUpDownTeamNumber.Size = new System.Drawing.Size(152, 26);
            this.numUpDownTeamNumber.TabIndex = 18;
            this.numUpDownTeamNumber.ValueChanged += new System.EventHandler(this.numUpDownTeamNumber_ValueChanged);
            // 
            // cbBoxNationality
            // 
            this.cbBoxNationality.FormattingEnabled = true;
            this.cbBoxNationality.Location = new System.Drawing.Point(229, 282);
            this.cbBoxNationality.Name = "cbBoxNationality";
            this.cbBoxNationality.Size = new System.Drawing.Size(359, 28);
            this.cbBoxNationality.TabIndex = 19;
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Location = new System.Drawing.Point(230, 325);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(359, 28);
            this.cBoxTeam.TabIndex = 20;
            // 
            // PraktikumWeek13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 511);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.cbBoxNationality);
            this.Controls.Add(this.numUpDownTeamNumber);
            this.Controls.Add(this.dtPickerBirthDate);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.txtBoxPlayerID);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "PraktikumWeek13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.PraktikumWeek13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtBoxPlayerID;
        private System.Windows.Forms.TextBox txtBoxPlayerName;
        private System.Windows.Forms.DateTimePicker dtPickerBirthDate;
        private System.Windows.Forms.NumericUpDown numUpDownTeamNumber;
        private System.Windows.Forms.ComboBox cbBoxNationality;
        private System.Windows.Forms.ComboBox cBoxTeam;
    }
}

