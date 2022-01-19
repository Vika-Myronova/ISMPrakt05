using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrayMethodsLibrary;

namespace WinFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFillArray_Click(object sender, EventArgs e)
        {
            int arrayLength = Convert.ToInt32(numericUpDownCount.Value);
            int[] array = ArrayMethods.CreateRandomArray(arrayLength);
            dataGridViewArray.ColumnCount = arrayLength;
            dataGridViewArray.RowCount = 1;
            for (int i = 0; i < arrayLength; i++)
            {
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
                dataGridViewArray[i, 0].Value = array[i];

                labelSumNeg.Visible = true;
                labelMaxEven.Visible = true;
                labelDob.Visible = true;
                labelIndexOfMax.Visible = true;
                labelMaxAbs.Visible = true;
                labelSumIndex.Visible = true;
                labelCountOfOdd.Visible = true;

                labelResultSumNeg.Text = ArrayMethods.SumOfNegElements(array).ToString();
                labelResultMax1.Text = ArrayMethods.MaxAmongEven(array).ToString();
                labelResultDob.Text = ArrayMethods.DobOfElementsWithEvenIndex(array).ToString();
                labelResultIndexMax.Text = ArrayMethods.IndexOfMaxElement(array).ToString();
                labelResultMaxAbs.Text = ArrayMethods.MaxAbsElement(array).ToString();
                labelResultSumIndex.Text = ArrayMethods.IndexSum(array).ToString();
                labelResultCount.Text = ArrayMethods.CountOfOddElements(array).ToString();
            }
        }
    }
}
