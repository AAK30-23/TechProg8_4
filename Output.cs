using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TechProg8_4
{
    public class Output
    {
        public static DataGridView dataGridView;

        public static void DisplayFilteredMatrix(List<string[]> filteredMatrix, TabControl tabControl)
        {
            int k = filteredMatrix[0].Length;

            if (tabControl.TabPages.Count == 2)
            {
                TabPage tabPage = new TabPage("Output");
                dataGridView = new DataGridView();
                dataGridView.Dock = DockStyle.Fill;
                tabPage.Controls.Add(dataGridView);
                tabControl.TabPages.Add(tabPage);
            }

            if (dataGridView.Columns.Count == 0)
            {
                for (int i = 0; i < k; i++)
                {
                    dataGridView.Columns.Add($"Col{i}", $"Col{i}");
                }
            }

            dataGridView.Rows.Clear();

            foreach (string[] row in filteredMatrix)
            {
                dataGridView.Rows.Add(row);
            }
        }

        public static DataGridView dataGridView1;

        public static void CompareAndDisplay(List<string[]> origMatrix, List<string[]> filteredMatrix, TabControl tabControl)
        {
            int rows = origMatrix.Count;
            int cols = origMatrix[0].Length;

            TabPage tabPage = tabControl.TabPages.Cast<TabPage>().FirstOrDefault(tp => tp.Text == "Output2");

            if (tabPage == null)
            {
                tabPage = new TabPage("Output2");
                dataGridView1 = new DataGridView
                {
                    Dock = DockStyle.Fill
                };
                tabPage.Controls.Add(dataGridView1);
                tabControl.TabPages.Add(tabPage);

                for (int i = 0; i < cols; i++)
                {
                    dataGridView1.Columns.Add($"Col{i}", $"Col{i}");
                }
            }
            else
            {
                dataGridView1 = (DataGridView)tabPage.Controls[0];
                dataGridView1.Rows.Clear(); 
            }

            // Сравниваем матрицы
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < cols; j++)
                {
                    bool valuesMatch = origMatrix[i][j] == filteredMatrix[i][j];
                    string result = valuesMatch ? "False" : "True";

                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell
                    {
                        Value = result
                    };
                    row.Cells.Add(cell);
                }

                dataGridView1.Rows.Add(row);
            }
        }

    }
}
