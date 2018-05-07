namespace MappingLayoutTest
{
    partial class MainForm
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
            this.MapGridView = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FYIField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MapLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.map = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IsMapped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.DirectoryTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MapGridView
            // 
            this.MapGridView.AllowUserToAddRows = false;
            this.MapGridView.AllowUserToDeleteRows = false;
            this.MapGridView.AllowUserToResizeRows = false;
            this.MapGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MapGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.FYIField,
            this.MapLocation,
            this.map,
            this.IsMapped});
            this.MapGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.MapGridView.Location = new System.Drawing.Point(12, 45);
            this.MapGridView.MultiSelect = false;
            this.MapGridView.Name = "MapGridView";
            this.MapGridView.RowHeadersVisible = false;
            this.MapGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MapGridView.Size = new System.Drawing.Size(677, 393);
            this.MapGridView.TabIndex = 0;
            this.MapGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MapGridView_CellContentClick);
            this.MapGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MapGridView_CellValueChanged);
            // 
            // order
            // 
            this.order.FillWeight = 10F;
            this.order.HeaderText = "Order: ";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // FYIField
            // 
            this.FYIField.FillWeight = 42.5F;
            this.FYIField.HeaderText = "FYI Destination";
            this.FYIField.Name = "FYIField";
            // 
            // MapLocation
            // 
            this.MapLocation.FillWeight = 42.5F;
            this.MapLocation.HeaderText = "Map From:";
            this.MapLocation.Name = "MapLocation";
            this.MapLocation.ReadOnly = true;
            this.MapLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // map
            // 
            this.map.FillWeight = 10F;
            this.map.HeaderText = "";
            this.map.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.map.Name = "map";
            this.map.TrackVisitedState = false;
            // 
            // IsMapped
            // 
            this.IsMapped.FillWeight = 10F;
            this.IsMapped.HeaderText = "Mapped?";
            this.IsMapped.Name = "IsMapped";
            this.IsMapped.ReadOnly = true;
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(17, 15);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(92, 13);
            this.DirectoryLabel.TabIndex = 5;
            this.DirectoryLabel.Text = "Current Directory: ";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(614, 10);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DirectoryTextbox
            // 
            this.DirectoryTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryTextbox.Location = new System.Drawing.Point(115, 12);
            this.DirectoryTextbox.Name = "DirectoryTextbox";
            this.DirectoryTextbox.Size = new System.Drawing.Size(493, 20);
            this.DirectoryTextbox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.DirectoryTextbox);
            this.Controls.Add(this.MapGridView);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MapGridView;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox DirectoryTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewComboBoxColumn FYIField;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapLocation;
        private System.Windows.Forms.DataGridViewLinkColumn map;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMapped;
    }
}

