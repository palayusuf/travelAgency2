namespace travelAgency2
{
    partial class formContact
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
            this.cmbBoxTravels = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelInfermations = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblJoiner = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.btnContact = new System.Windows.Forms.Button();
            this.panelInfermations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxTravels
            // 
            this.cmbBoxTravels.BackColor = System.Drawing.SystemColors.WindowText;
            this.cmbBoxTravels.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbBoxTravels.FormattingEnabled = true;
            this.cmbBoxTravels.Location = new System.Drawing.Point(628, 166);
            this.cmbBoxTravels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxTravels.Name = "cmbBoxTravels";
            this.cmbBoxTravels.Size = new System.Drawing.Size(625, 28);
            this.cmbBoxTravels.TabIndex = 0;
            this.cmbBoxTravels.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTravels_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelInfermations
            // 
            this.panelInfermations.BackColor = System.Drawing.Color.Transparent;
            this.panelInfermations.Controls.Add(this.textBoxPhone);
            this.panelInfermations.Controls.Add(this.lblTotal);
            this.panelInfermations.Controls.Add(this.lblTotal1);
            this.panelInfermations.Controls.Add(this.lblPrice);
            this.panelInfermations.Controls.Add(this.lblPrice1);
            this.panelInfermations.Controls.Add(this.lblJoiner);
            this.panelInfermations.Controls.Add(this.label6);
            this.panelInfermations.Controls.Add(this.lblParticipant);
            this.panelInfermations.Controls.Add(this.lblEndDate);
            this.panelInfermations.Controls.Add(this.lblStartDate);
            this.panelInfermations.Controls.Add(this.lblEnd);
            this.panelInfermations.Controls.Add(this.lblStart);
            this.panelInfermations.Controls.Add(this.pictureBox3);
            this.panelInfermations.Controls.Add(this.pictureBox1);
            this.panelInfermations.Location = new System.Drawing.Point(628, 339);
            this.panelInfermations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInfermations.Name = "panelInfermations";
            this.panelInfermations.Size = new System.Drawing.Size(627, 611);
            this.panelInfermations.TabIndex = 4;
            this.panelInfermations.Visible = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.Black;
            this.textBoxPhone.ForeColor = System.Drawing.Color.White;
            this.textBoxPhone.Location = new System.Drawing.Point(352, 286);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.MaxLength = 11;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(242, 26);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(345, 450);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 40);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Toplam";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal1.ForeColor = System.Drawing.Color.White;
            this.lblTotal1.Location = new System.Drawing.Point(33, 450);
            this.lblTotal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(118, 40);
            this.lblTotal1.TabIndex = 2;
            this.lblTotal1.Text = "Toplam";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(345, 401);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 40);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Ücret";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice1.ForeColor = System.Drawing.Color.White;
            this.lblPrice1.Location = new System.Drawing.Point(33, 401);
            this.lblPrice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(91, 40);
            this.lblPrice1.TabIndex = 2;
            this.lblPrice1.Text = "Ücret";
            // 
            // lblJoiner
            // 
            this.lblJoiner.AutoSize = true;
            this.lblJoiner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJoiner.ForeColor = System.Drawing.Color.White;
            this.lblJoiner.Location = new System.Drawing.Point(345, 344);
            this.lblJoiner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoiner.Name = "lblJoiner";
            this.lblJoiner.Size = new System.Drawing.Size(136, 40);
            this.lblJoiner.TabIndex = 2;
            this.lblJoiner.Text = "Katılımcı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefon Numarası:";
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParticipant.ForeColor = System.Drawing.Color.White;
            this.lblParticipant.Location = new System.Drawing.Point(33, 344);
            this.lblParticipant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(136, 40);
            this.lblParticipant.TabIndex = 2;
            this.lblParticipant.Text = "Katılımcı";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(80, 217);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 40);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "end";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(80, 77);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(81, 40);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnd.ForeColor = System.Drawing.Color.Gray;
            this.lblEnd.Location = new System.Drawing.Point(78, 175);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(48, 28);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Bitiş";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStart.ForeColor = System.Drawing.Color.Gray;
            this.lblStart.Location = new System.Drawing.Point(78, 32);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(93, 28);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Başlangıç";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::travelAgency2.Properties.Resources.calendar__1_;
            this.pictureBox3.Location = new System.Drawing.Point(28, 175);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::travelAgency2.Properties.Resources.calendar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(28, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.BackColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxPerson.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Items.AddRange(new object[] {
            "1 Kişi",
            "2 Kişi",
            "3 Kişi",
            "4 Kişi",
            "5 Kişi",
            "6 Kişi",
            "7 Kişi",
            "8 Kişi"});
            this.comboBoxPerson.Location = new System.Drawing.Point(628, 218);
            this.comboBoxPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(625, 28);
            this.comboBoxPerson.TabIndex = 0;
            this.comboBoxPerson.SelectedIndexChanged += new System.EventHandler(this.comboBoxPerson_SelectedIndexChanged);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Location = new System.Drawing.Point(1343, 534);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(330, 89);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "HEMEN BAŞVUR";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // formContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::travelAgency2.Properties.Resources.homePageBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.panelInfermations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxPerson);
            this.Controls.Add(this.cmbBoxTravels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formContact";
            this.Load += new System.EventHandler(this.formContact_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formContact_MouseDown);
            this.panelInfermations.ResumeLayout(false);
            this.panelInfermations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxTravels;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelInfermations;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblJoiner;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnContact;
    }
}