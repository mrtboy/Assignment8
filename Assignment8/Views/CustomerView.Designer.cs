namespace Assignment8.Views
{
    partial class CustomerView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbFlightId = new System.Windows.Forms.ComboBox();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.txtOrogin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.dgFlights = new System.Windows.Forms.DataGridView();
            this.btnAddNewFlight = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMessageFlight = new System.Windows.Forms.Label();
            this.lblMessageCustomer = new System.Windows.Forms.Label();
            this.txtFindCustomer = new System.Windows.Forms.TextBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.txtFlightSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtDeleteCustomer = new System.Windows.Forms.TextBox();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.txtFlightToDelete = new System.Windows.Forms.TextBox();
            this.btnShowAllFlight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.txtEditCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 2;
            // 
            // cbFlightId
            // 
            this.cbFlightId.FormattingEnabled = true;
            this.cbFlightId.Location = new System.Drawing.Point(125, 82);
            this.cbFlightId.Name = "cbFlightId";
            this.cbFlightId.Size = new System.Drawing.Size(121, 21);
            this.cbFlightId.TabIndex = 3;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(284, 57);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewCustomer.TabIndex = 4;
            this.btnAddNewCustomer.Text = "Register";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCustomer.Location = new System.Drawing.Point(0, 300);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(415, 377);
            this.dgCustomer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add New Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Airline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Origin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date";
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(140, 39);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(121, 20);
            this.txtAirline.TabIndex = 12;
            // 
            // txtOrogin
            // 
            this.txtOrogin.Location = new System.Drawing.Point(140, 77);
            this.txtOrogin.Name = "txtOrogin";
            this.txtOrogin.Size = new System.Drawing.Size(121, 20);
            this.txtOrogin.TabIndex = 13;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(367, 35);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(158, 20);
            this.txtDestination.TabIndex = 14;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(367, 77);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(158, 20);
            this.txtDate.TabIndex = 15;
            // 
            // dgFlights
            // 
            this.dgFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgFlights.Location = new System.Drawing.Point(0, 300);
            this.dgFlights.Name = "dgFlights";
            this.dgFlights.Size = new System.Drawing.Size(829, 377);
            this.dgFlights.TabIndex = 16;
            // 
            // btnAddNewFlight
            // 
            this.btnAddNewFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewFlight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddNewFlight.Location = new System.Drawing.Point(551, 49);
            this.btnAddNewFlight.Name = "btnAddNewFlight";
            this.btnAddNewFlight.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFlight.TabIndex = 17;
            this.btnAddNewFlight.Text = "Add Flight";
            this.btnAddNewFlight.UseVisualStyleBackColor = true;
            this.btnAddNewFlight.Click += new System.EventHandler(this.btnAddNewFlight_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtEditCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.txtDeleteCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btnCustomerSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtFindCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.lblMessageCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.dgCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddNewCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbFlightId);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnShowAllFlight);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteFlight);
            this.splitContainer1.Panel2.Controls.Add(this.txtFlightToDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnFlightSearch);
            this.splitContainer1.Panel2.Controls.Add(this.txtFlightSearch);
            this.splitContainer1.Panel2.Controls.Add(this.lblMessageFlight);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.dgFlights);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddNewFlight);
            this.splitContainer1.Panel2.Controls.Add(this.txtOrogin);
            this.splitContainer1.Panel2.Controls.Add(this.txtDate);
            this.splitContainer1.Panel2.Controls.Add(this.txtDestination);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtAirline);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 677);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Add New Flight";
            // 
            // lblMessageFlight
            // 
            this.lblMessageFlight.AutoSize = true;
            this.lblMessageFlight.Location = new System.Drawing.Point(560, 90);
            this.lblMessageFlight.Name = "lblMessageFlight";
            this.lblMessageFlight.Size = new System.Drawing.Size(0, 13);
            this.lblMessageFlight.TabIndex = 18;
            // 
            // lblMessageCustomer
            // 
            this.lblMessageCustomer.AutoSize = true;
            this.lblMessageCustomer.Location = new System.Drawing.Point(267, 105);
            this.lblMessageCustomer.Name = "lblMessageCustomer";
            this.lblMessageCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblMessageCustomer.TabIndex = 19;
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.Location = new System.Drawing.Point(104, 140);
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtFindCustomer.TabIndex = 20;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCustomerSearch.Location = new System.Drawing.Point(272, 140);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSearch.TabIndex = 21;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // btnFlightSearch
            // 
            this.btnFlightSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFlightSearch.Location = new System.Drawing.Point(432, 140);
            this.btnFlightSearch.Name = "btnFlightSearch";
            this.btnFlightSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFlightSearch.TabIndex = 23;
            this.btnFlightSearch.Text = "Search";
            this.btnFlightSearch.UseVisualStyleBackColor = true;
            this.btnFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // txtFlightSearch
            // 
            this.txtFlightSearch.Location = new System.Drawing.Point(264, 140);
            this.txtFlightSearch.Name = "txtFlightSearch";
            this.txtFlightSearch.Size = new System.Drawing.Size(142, 20);
            this.txtFlightSearch.TabIndex = 22;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(272, 188);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 23;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtDeleteCustomer
            // 
            this.txtDeleteCustomer.Location = new System.Drawing.Point(104, 188);
            this.txtDeleteCustomer.Name = "txtDeleteCustomer";
            this.txtDeleteCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtDeleteCustomer.TabIndex = 22;
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDeleteFlight.Location = new System.Drawing.Point(432, 191);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFlight.TabIndex = 25;
            this.btnDeleteFlight.Text = "Delete";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // txtFlightToDelete
            // 
            this.txtFlightToDelete.Location = new System.Drawing.Point(264, 191);
            this.txtFlightToDelete.Name = "txtFlightToDelete";
            this.txtFlightToDelete.Size = new System.Drawing.Size(142, 20);
            this.txtFlightToDelete.TabIndex = 24;
            // 
            // btnShowAllFlight
            // 
            this.btnShowAllFlight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnShowAllFlight.Location = new System.Drawing.Point(709, 271);
            this.btnShowAllFlight.Name = "btnShowAllFlight";
            this.btnShowAllFlight.Size = new System.Drawing.Size(108, 23);
            this.btnShowAllFlight.TabIndex = 26;
            this.btnShowAllFlight.Text = "Show All Flights";
            this.btnShowAllFlight.UseVisualStyleBackColor = true;
            this.btnShowAllFlight.Click += new System.EventHandler(this.btnShowAllFlight_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(295, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Show All Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(270, 229);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomer.TabIndex = 28;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // txtEditCustomer
            // 
            this.txtEditCustomer.Location = new System.Drawing.Point(105, 229);
            this.txtEditCustomer.Name = "txtEditCustomer";
            this.txtEditCustomer.Size = new System.Drawing.Size(141, 20);
            this.txtEditCustomer.TabIndex = 29;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 677);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlights)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbFlightId;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.TextBox txtOrogin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DataGridView dgFlights;
        private System.Windows.Forms.Button btnAddNewFlight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMessageCustomer;
        private System.Windows.Forms.Label lblMessageFlight;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.TextBox txtFindCustomer;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.TextBox txtFlightSearch;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.TextBox txtFlightToDelete;
        private System.Windows.Forms.Button btnShowAllFlight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEditCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
    }
}