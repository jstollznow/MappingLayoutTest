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
            this.mapDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.map = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MapGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MapGridView
            // 
            this.MapGridView.AllowUserToResizeRows = false;
            this.MapGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MapGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.mapDestination,
            this.MapLocation,
            this.map});
            this.MapGridView.Location = new System.Drawing.Point(12, 45);
            this.MapGridView.MultiSelect = false;
            this.MapGridView.Name = "MapGridView";
            this.MapGridView.ReadOnly = true;
            this.MapGridView.RowHeadersVisible = false;
            this.MapGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MapGridView.Size = new System.Drawing.Size(677, 393);
            this.MapGridView.TabIndex = 0;
            // 
            // order
            // 
            this.order.FillWeight = 10F;
            this.order.HeaderText = "Order: ";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // mapDestination
            // 
            this.mapDestination.FillWeight = 42.5F;
            this.mapDestination.HeaderText = "Map To: ";
            this.mapDestination.Name = "mapDestination";
            this.mapDestination.ReadOnly = true;
            this.mapDestination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.map.FillWeight = 5F;
            this.map.HeaderText = "";
            this.map.Name = "map";
            this.map.ReadOnly = true;
            this.map.TrackVisitedState = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.MapGridView);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MapGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapLocation;
        private System.Windows.Forms.DataGridViewLinkColumn map;
    }
}

