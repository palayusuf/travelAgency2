namespace travelAgency2
{
    partial class Vacations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridLocations = new System.Windows.Forms.DataGridView();
            this.dataGridVacDate = new System.Windows.Forms.DataGridView();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridLocations
            // 
            this.dataGridLocations.AllowUserToAddRows = false;
            this.dataGridLocations.AllowUserToDeleteRows = false;
            this.dataGridLocations.AllowUserToResizeColumns = false;
            this.dataGridLocations.AllowUserToResizeRows = false;
            this.dataGridLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLocations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.dataGridLocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLocations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridLocations.ColumnHeadersHeight = 34;
            this.dataGridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLocations.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridLocations.EnableHeadersVisualStyles = false;
            this.dataGridLocations.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridLocations.Location = new System.Drawing.Point(689, 204);
            this.dataGridLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridLocations.MultiSelect = false;
            this.dataGridLocations.Name = "dataGridLocations";
            this.dataGridLocations.ReadOnly = true;
            this.dataGridLocations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridLocations.RowHeadersVisible = false;
            this.dataGridLocations.RowHeadersWidth = 62;
            this.dataGridLocations.RowTemplate.Height = 50;
            this.dataGridLocations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridLocations.Size = new System.Drawing.Size(593, 310);
            this.dataGridLocations.TabIndex = 2;
            // 
            // dataGridVacDate
            // 
            this.dataGridVacDate.AllowUserToAddRows = false;
            this.dataGridVacDate.AllowUserToDeleteRows = false;
            this.dataGridVacDate.AllowUserToResizeColumns = false;
            this.dataGridVacDate.AllowUserToResizeRows = false;
            this.dataGridVacDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVacDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.dataGridVacDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVacDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridVacDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVacDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridVacDate.ColumnHeadersHeight = 34;
            this.dataGridVacDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVacDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridVacDate.EnableHeadersVisualStyles = false;
            this.dataGridVacDate.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridVacDate.Location = new System.Drawing.Point(23, 204);
            this.dataGridVacDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridVacDate.MultiSelect = false;
            this.dataGridVacDate.Name = "dataGridVacDate";
            this.dataGridVacDate.ReadOnly = true;
            this.dataGridVacDate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridVacDate.RowHeadersVisible = false;
            this.dataGridVacDate.RowHeadersWidth = 62;
            this.dataGridVacDate.RowTemplate.Height = 25;
            this.dataGridVacDate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridVacDate.Size = new System.Drawing.Size(568, 448);
            this.dataGridVacDate.TabIndex = 2;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle1.Location = new System.Drawing.Point(75, 134);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(330, 48);
            this.lblTitle1.TabIndex = 3;
            this.lblTitle1.Text = "Seyahat Zamanları";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle2.Location = new System.Drawing.Point(748, 134);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(337, 48);
            this.lblTitle2.TabIndex = 3;
            this.lblTitle2.Text = "Seyahat Konumları";
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Location = new System.Drawing.Point(1015, 604);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(170, 70);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "BAŞVUR";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // Vacations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 698);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.dataGridVacDate);
            this.Controls.Add(this.dataGridLocations);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vacations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacations";
            this.Load += new System.EventHandler(this.Vacations_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vacations_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridLocations;
        private System.Windows.Forms.DataGridView dataGridVacDate;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btnContact;
    }
}