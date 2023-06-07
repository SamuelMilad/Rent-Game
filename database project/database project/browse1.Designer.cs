namespace database_project
{
    partial class browse1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pALTFORMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fr_marcous1 = new database_project.fr_marcous1();
            this.gAMETableAdapter = new database_project.fr_marcous1TableAdapters.GAMETableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fr_marcous1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 798);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.MediumPurple;
            this.button6.Image = global::database_project.Properties.Resources.icons8_update_641;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 89);
            this.button6.TabIndex = 5;
            this.button6.Text = "        Update     Info";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MediumPurple;
            this.button3.Image = global::database_project.Properties.Resources.icons8_left_2_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 89);
            this.button3.TabIndex = 4;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(74, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = global::database_project.Properties.Resources.icons8_back_arrow_64;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 543);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 89);
            this.button5.TabIndex = 3;
            this.button5.Text = "   Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumPurple;
            this.button1.Image = global::database_project.Properties.Resources.icons8_rent_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "       Rent ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = global::database_project.Properties.Resources.icons8_fire_exit_64;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 678);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 89);
            this.button4.TabIndex = 2;
            this.button4.Text = "  Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MediumPurple;
            this.button2.Image = global::database_project.Properties.Resources.icons8_browse_64__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 89);
            this.button2.TabIndex = 1;
            this.button2.Text = "             Browsing    ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gAMEIDDataGridViewTextBoxColumn,
            this.aDMINIDDataGridViewTextBoxColumn,
            this.gAMENAMEDataGridViewTextBoxColumn,
            this.pALTFORMDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.yEARGDataGridViewTextBoxColumn,
            this.rATEDataGridViewTextBoxColumn,
            this.vendornameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gAMEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(297, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 424);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gAMEIDDataGridViewTextBoxColumn
            // 
            this.gAMEIDDataGridViewTextBoxColumn.DataPropertyName = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.HeaderText = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gAMEIDDataGridViewTextBoxColumn.Name = "gAMEIDDataGridViewTextBoxColumn";
            this.gAMEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDMINIDDataGridViewTextBoxColumn
            // 
            this.aDMINIDDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.HeaderText = "ADMIN_ID";
            this.aDMINIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDMINIDDataGridViewTextBoxColumn.Name = "aDMINIDDataGridViewTextBoxColumn";
            this.aDMINIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gAMENAMEDataGridViewTextBoxColumn
            // 
            this.gAMENAMEDataGridViewTextBoxColumn.DataPropertyName = "GAME_NAME";
            this.gAMENAMEDataGridViewTextBoxColumn.HeaderText = "GAME_NAME";
            this.gAMENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gAMENAMEDataGridViewTextBoxColumn.Name = "gAMENAMEDataGridViewTextBoxColumn";
            this.gAMENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pALTFORMDataGridViewTextBoxColumn
            // 
            this.pALTFORMDataGridViewTextBoxColumn.DataPropertyName = "PALTFORM";
            this.pALTFORMDataGridViewTextBoxColumn.HeaderText = "PALTFORM";
            this.pALTFORMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pALTFORMDataGridViewTextBoxColumn.Name = "pALTFORMDataGridViewTextBoxColumn";
            this.pALTFORMDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 125;
            // 
            // yEARGDataGridViewTextBoxColumn
            // 
            this.yEARGDataGridViewTextBoxColumn.DataPropertyName = "YEARG";
            this.yEARGDataGridViewTextBoxColumn.HeaderText = "YEARG";
            this.yEARGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yEARGDataGridViewTextBoxColumn.Name = "yEARGDataGridViewTextBoxColumn";
            this.yEARGDataGridViewTextBoxColumn.Width = 125;
            // 
            // rATEDataGridViewTextBoxColumn
            // 
            this.rATEDataGridViewTextBoxColumn.DataPropertyName = "RATE";
            this.rATEDataGridViewTextBoxColumn.HeaderText = "RATE";
            this.rATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rATEDataGridViewTextBoxColumn.Name = "rATEDataGridViewTextBoxColumn";
            this.rATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendornameDataGridViewTextBoxColumn
            // 
            this.vendornameDataGridViewTextBoxColumn.DataPropertyName = "vendor_name";
            this.vendornameDataGridViewTextBoxColumn.HeaderText = "vendor_name";
            this.vendornameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendornameDataGridViewTextBoxColumn.Name = "vendornameDataGridViewTextBoxColumn";
            this.vendornameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gAMEBindingSource
            // 
            this.gAMEBindingSource.DataMember = "GAME";
            this.gAMEBindingSource.DataSource = this.fr_marcous1;
            // 
            // fr_marcous1
            // 
            this.fr_marcous1.DataSetName = "fr_marcous1";
            this.fr_marcous1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMETableAdapter
            // 
            this.gAMETableAdapter.ClearBeforeFill = true;
            // 
            // browse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::database_project.Properties.Resources.Diesel_blog_epic_games_store_update_EGS_Social_Update_News_2560x1440_128a69890d92407b815582c1deba54450e5645f9;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "browse1";
            this.Text = "browse1";
            this.Load += new System.EventHandler(this.browse1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fr_marcous1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fr_marcous1 fr_marcous1;
        private System.Windows.Forms.BindingSource gAMEBindingSource;
        private fr_marcous1TableAdapters.GAMETableAdapter gAMETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pALTFORMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendornameDataGridViewTextBoxColumn;
    }
}