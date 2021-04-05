using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonSquare
{
    public partial class Form1 : Form
    {        
        List<Point> PointsList = new List<Point>();        

        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(tbxInput, "Формат: 1) x,y 2) x;y 3) x y ");

            lbResultText.Hide();
            lbResultValue.Hide();
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            string point = tbxInput.Text;

            var coordinates = tbxInput.Text.Split(new[] { ',', ';', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            if (coordinates.Length == 2)
            {
                Point newPoint = new Point(coordinates[0], coordinates[1]);
                PointsList.Add(newPoint);
                tbxPoints.Text += PointsList.Count + ". (" + coordinates[0] + ";" + coordinates[1] + ")" + "\r\n";
            }

            tbxInput.Clear();
        }

        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == Convert.ToChar(",") | e.KeyChar == Convert.ToChar(";") | e.KeyChar == Convert.ToChar(" ") | e.KeyChar == Convert.ToChar("-") | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PointsList.Clear();
            tbxPoints.Clear();
            tbxInput.Clear();

            lbResultText.Hide();
            lbResultValue.Hide();
            lbResultValue.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double result = Calculator.GetPoligonSquare(PointsList);

            lbResultText.Show();
            lbResultValue.Show();
                        
            lbResultValue.Text = result.ToString();           

        }
    }
}
