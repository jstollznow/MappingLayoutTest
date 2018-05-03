using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingLayoutTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

            DataGridViewRow example = (DataGridViewRow)MapGridView.Rows[0].Clone();
            example.Cells[0].Value = "1";
            //example.Cells[1].Value = "Clients";
            example.Cells[2].Value = "";
            example.Cells[3].Value = "Map";
            example.Cells[4].Value= char.ConvertFromUtf32(0x00002716);
            MapGridView.Rows.Add(example);
            DataGridViewRow example1 = (DataGridViewRow)MapGridView.Rows[0].Clone();
            example1.Cells[0].Value = "2";
            //example1.Cells[1].Value = "Cabinets";
            example1.Cells[2].Value = "";
            example1.Cells[3].Value = "Map";
            example1.Cells[4].Value = char.ConvertFromUtf32(0x00002714);
            MapGridView.Rows.Add(example1);
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

        private void MapGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
