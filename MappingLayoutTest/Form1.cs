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
            DataGridViewRow example = (DataGridViewRow)MapGridView.Rows[0].Clone();
            example.Cells[0].Value = "1";
            example.Cells[1].Value = "Clients";
            example.Cells[2].Value = "People";
            example.Cells[3].Value = "Map";
            MapGridView.Rows.Add(example);
            DataGridViewRow example1 = (DataGridViewRow)MapGridView.Rows[0].Clone();
            example1.Cells[0].Value = "2";
            example1.Cells[1].Value = "Cabinets";
            example1.Cells[2].Value = "Files";
            example1.Cells[3].Value = "Map";
            MapGridView.Rows.Add(example1);
        }
    }
}
