
namespace WinFormProject
{
    partial class Form1
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
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.buttonFillArray = new System.Windows.Forms.Button();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelN = new System.Windows.Forms.Label();
            this.labelCountOfOdd = new System.Windows.Forms.Label();
            this.labelSumNeg = new System.Windows.Forms.Label();
            this.labelMaxEven = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelSumIndex = new System.Windows.Forms.Label();
            this.labelIndexOfMax = new System.Windows.Forms.Label();
            this.labelMaxAbs = new System.Windows.Forms.Label();
            this.labelResultSumNeg = new System.Windows.Forms.Label();
            this.labelResultMax1 = new System.Windows.Forms.Label();
            this.labelResultDob = new System.Windows.Forms.Label();
            this.labelResultIndexMax = new System.Windows.Forms.Label();
            this.labelResultMaxAbs = new System.Windows.Forms.Label();
            this.labelResultSumIndex = new System.Windows.Forms.Label();
            this.labelResultCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersWidth = 51;
            this.dataGridViewArray.RowTemplate.Height = 24;
            this.dataGridViewArray.Size = new System.Drawing.Size(956, 77);
            this.dataGridViewArray.TabIndex = 0;
            // 
            // buttonFillArray
            // 
            this.buttonFillArray.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFillArray.Location = new System.Drawing.Point(12, 76);
            this.buttonFillArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFillArray.Name = "buttonFillArray";
            this.buttonFillArray.Size = new System.Drawing.Size(202, 45);
            this.buttonFillArray.TabIndex = 1;
            this.buttonFillArray.Text = "Заповнити масив";
            this.buttonFillArray.UseVisualStyleBackColor = false;
            this.buttonFillArray.Click += new System.EventHandler(this.buttonFillArray_Click);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(281, 33);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(72, 28);
            this.numericUpDownCount.TabIndex = 2;
            this.numericUpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(12, 35);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(263, 21);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "Кількість елементів масиву";
            // 
            // labelCountOfOdd
            // 
            this.labelCountOfOdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountOfOdd.AutoSize = true;
            this.labelCountOfOdd.BackColor = System.Drawing.Color.PeachPuff;
            this.labelCountOfOdd.Location = new System.Drawing.Point(578, 371);
            this.labelCountOfOdd.Name = "labelCountOfOdd";
            this.labelCountOfOdd.Size = new System.Drawing.Size(259, 21);
            this.labelCountOfOdd.TabIndex = 4;
            this.labelCountOfOdd.Text = "Кількість непарних елементів";
            this.labelCountOfOdd.Visible = false;
            // 
            // labelSumNeg
            // 
            this.labelSumNeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumNeg.AutoSize = true;
            this.labelSumNeg.BackColor = System.Drawing.Color.PeachPuff;
            this.labelSumNeg.Location = new System.Drawing.Point(8, 290);
            this.labelSumNeg.Name = "labelSumNeg";
            this.labelSumNeg.Size = new System.Drawing.Size(222, 21);
            this.labelSumNeg.TabIndex = 5;
            this.labelSumNeg.Text = "Сума від\'ємних елементів";
            this.labelSumNeg.Visible = false;
            // 
            // labelMaxEven
            // 
            this.labelMaxEven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxEven.AutoSize = true;
            this.labelMaxEven.BackColor = System.Drawing.Color.PeachPuff;
            this.labelMaxEven.Location = new System.Drawing.Point(8, 332);
            this.labelMaxEven.Name = "labelMaxEven";
            this.labelMaxEven.Size = new System.Drawing.Size(327, 21);
            this.labelMaxEven.TabIndex = 6;
            this.labelMaxEven.Text = "Максимальне серед парних елементів";
            this.labelMaxEven.Visible = false;
            // 
            // labelDob
            // 
            this.labelDob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDob.AutoSize = true;
            this.labelDob.BackColor = System.Drawing.Color.PeachPuff;
            this.labelDob.Location = new System.Drawing.Point(8, 372);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(346, 21);
            this.labelDob.TabIndex = 7;
            this.labelDob.Text = "Добуток елементів з парними індексами";
            this.labelDob.Visible = false;
            // 
            // labelSumIndex
            // 
            this.labelSumIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumIndex.AutoSize = true;
            this.labelSumIndex.BackColor = System.Drawing.Color.PeachPuff;
            this.labelSumIndex.Location = new System.Drawing.Point(578, 330);
            this.labelSumIndex.Name = "labelSumIndex";
            this.labelSumIndex.Size = new System.Drawing.Size(293, 21);
            this.labelSumIndex.TabIndex = 8;
            this.labelSumIndex.Text = "Сума індексів додатних елементів";
            this.labelSumIndex.Visible = false;
            // 
            // labelIndexOfMax
            // 
            this.labelIndexOfMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIndexOfMax.AutoSize = true;
            this.labelIndexOfMax.BackColor = System.Drawing.Color.PeachPuff;
            this.labelIndexOfMax.Location = new System.Drawing.Point(8, 413);
            this.labelIndexOfMax.Name = "labelIndexOfMax";
            this.labelIndexOfMax.Size = new System.Drawing.Size(279, 21);
            this.labelIndexOfMax.TabIndex = 9;
            this.labelIndexOfMax.Text = "Індекс максимального елемента";
            this.labelIndexOfMax.Visible = false;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.BackColor = System.Drawing.Color.PeachPuff;
            this.labelMaxAbs.Location = new System.Drawing.Point(578, 290);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(308, 21);
            this.labelMaxAbs.TabIndex = 10;
            this.labelMaxAbs.Text = "Максимальний за модулем елемент";
            this.labelMaxAbs.Visible = false;
            // 
            // labelResultSumNeg
            // 
            this.labelResultSumNeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultSumNeg.AutoSize = true;
            this.labelResultSumNeg.Location = new System.Drawing.Point(363, 290);
            this.labelResultSumNeg.Name = "labelResultSumNeg";
            this.labelResultSumNeg.Size = new System.Drawing.Size(0, 21);
            this.labelResultSumNeg.TabIndex = 11;
            // 
            // labelResultMax1
            // 
            this.labelResultMax1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultMax1.AutoSize = true;
            this.labelResultMax1.Location = new System.Drawing.Point(363, 332);
            this.labelResultMax1.Name = "labelResultMax1";
            this.labelResultMax1.Size = new System.Drawing.Size(0, 21);
            this.labelResultMax1.TabIndex = 12;
            // 
            // labelResultDob
            // 
            this.labelResultDob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultDob.AutoSize = true;
            this.labelResultDob.Location = new System.Drawing.Point(363, 372);
            this.labelResultDob.Name = "labelResultDob";
            this.labelResultDob.Size = new System.Drawing.Size(0, 21);
            this.labelResultDob.TabIndex = 13;
            // 
            // labelResultIndexMax
            // 
            this.labelResultIndexMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultIndexMax.AutoSize = true;
            this.labelResultIndexMax.Location = new System.Drawing.Point(363, 413);
            this.labelResultIndexMax.Name = "labelResultIndexMax";
            this.labelResultIndexMax.Size = new System.Drawing.Size(0, 21);
            this.labelResultIndexMax.TabIndex = 14;
            // 
            // labelResultMaxAbs
            // 
            this.labelResultMaxAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultMaxAbs.AutoSize = true;
            this.labelResultMaxAbs.Location = new System.Drawing.Point(892, 290);
            this.labelResultMaxAbs.Name = "labelResultMaxAbs";
            this.labelResultMaxAbs.Size = new System.Drawing.Size(0, 21);
            this.labelResultMaxAbs.TabIndex = 15;
            // 
            // labelResultSumIndex
            // 
            this.labelResultSumIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultSumIndex.AutoSize = true;
            this.labelResultSumIndex.Location = new System.Drawing.Point(892, 330);
            this.labelResultSumIndex.Name = "labelResultSumIndex";
            this.labelResultSumIndex.Size = new System.Drawing.Size(0, 21);
            this.labelResultSumIndex.TabIndex = 16;
            // 
            // labelResultCount
            // 
            this.labelResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultCount.AutoSize = true;
            this.labelResultCount.Location = new System.Drawing.Point(892, 372);
            this.labelResultCount.Name = "labelResultCount";
            this.labelResultCount.Size = new System.Drawing.Size(0, 21);
            this.labelResultCount.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1033, 481);
            this.Controls.Add(this.labelResultCount);
            this.Controls.Add(this.labelResultSumIndex);
            this.Controls.Add(this.labelResultMaxAbs);
            this.Controls.Add(this.labelResultIndexMax);
            this.Controls.Add(this.labelResultDob);
            this.Controls.Add(this.labelResultMax1);
            this.Controls.Add(this.labelResultSumNeg);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.labelIndexOfMax);
            this.Controls.Add(this.labelSumIndex);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelMaxEven);
            this.Controls.Add(this.labelSumNeg);
            this.Controls.Add(this.labelCountOfOdd);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.buttonFillArray);
            this.Controls.Add(this.dataGridViewArray);
            this.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button buttonFillArray;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelCountOfOdd;
        private System.Windows.Forms.Label labelSumNeg;
        private System.Windows.Forms.Label labelMaxEven;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelSumIndex;
        private System.Windows.Forms.Label labelIndexOfMax;
        private System.Windows.Forms.Label labelMaxAbs;
        private System.Windows.Forms.Label labelResultSumNeg;
        private System.Windows.Forms.Label labelResultMax1;
        private System.Windows.Forms.Label labelResultDob;
        private System.Windows.Forms.Label labelResultIndexMax;
        private System.Windows.Forms.Label labelResultMaxAbs;
        private System.Windows.Forms.Label labelResultSumIndex;
        private System.Windows.Forms.Label labelResultCount;
    }
}

