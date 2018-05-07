using System;
using System.IO;
using System.Windows.Forms;

namespace MappingLayoutTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int CheckFolderLevels(string filePath)
        {

            DirectoryInfo root = new DirectoryInfo(filePath);
            //root.GetDirectories("*.*", SearchOption.AllDirectories);

            return 0;
        }

        private void AddDefaultRow()
        {
            MapGridView.Rows.Add(MapGridView.Rows.Count+1, null, DirectoryTextbox.Text, "", char.ConvertFromUtf32(0x00002716));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MapGridView.DefaultCellStyle.SelectionBackColor = MapGridView.DefaultCellStyle.BackColor;
            MapGridView.DefaultCellStyle.SelectionForeColor = MapGridView.DefaultCellStyle.ForeColor;

            ComboBox FYImapping = new ComboBox();
            FYImapping.Items.Add("Client");
            FYImapping.Items.Add("Cabinet");
            FYImapping.Items.Add("Project");
            FYImapping.Items.Add("Work Type");

            ((DataGridViewComboBoxColumn)MapGridView.Columns[1]).DataSource = FYImapping.Items;

            
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            //select directory
            FolderBrowserDialog SelectDirectory = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.UserProfile,
                Description = "Please select the folder containing the documents to upload: ",
                ShowNewFolderButton = false
            };

            if (SelectDirectory.ShowDialog() == DialogResult.OK)
            {
                DirectoryTextbox.Text = SelectDirectory.SelectedPath;
                CheckFolderLevels(SelectDirectory.SelectedPath);
                AddDefaultRow();
                MapGridView.Rows[0].Cells[4].Value = char.ConvertFromUtf32(0x00002716);

                AddDefaultRow();
                MapGridView.Rows[1].Cells[4].Value = char.ConvertFromUtf32(0x00002716);

                AddDefaultRow();
                MapGridView.Rows[2].Cells[4].Value = char.ConvertFromUtf32(0x00002716);
            }
        }

        private void MapGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.ColumnIndex==3)
            {
                FolderBrowserDialog SelectDirectory = new FolderBrowserDialog
                {
                    RootFolder = Environment.SpecialFolder.UserProfile,
                    Description = "Please select the folder containing the documents to upload: ",
                    ShowNewFolderButton = false
                };

                if (SelectDirectory.ShowDialog() == DialogResult.OK)
                {
                    senderGrid.Rows[e.RowIndex].Cells[2].Value = SelectDirectory.SelectedPath;
                }
            }
            
        }

        private void MapGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Rows.Count!=0)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.ColumnIndex == 1)
                {
                    if (!(senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == ""))
                    {
                        senderGrid.Rows[e.RowIndex].Cells[4].Value = char.ConvertFromUtf32(0x00002714);
                    }
                }
            }
            
        }
    }
}
