using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadingMNISTDatabase
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			dataGridView1.Rows.Add(10);
			Bayesian_Classifier._MnistTrainingDatabase = new MNIST_Database();
			Bayesian_Classifier._MnistTestingDatabase = new MNIST_Database();
		}

		private void Read_Click(object sender, EventArgs e)
		{
			Bayesian_Classifier._MnistTrainingDatabase.LoadMinstFiles();
			Bayesian_Classifier._MnistTestingDatabase.LoadMinstFiles();
			Bayesian_Classifier.Classify();
			for (int i = 0; i < 10; ++i)
				for (int j = 0; j < 10; ++j)
					dataGridView1.Rows[i].Cells[j].Value = Bayesian_Classifier.ConfutionMatrix[i, j].ToString();
			AccuracyLabel.Text = Bayesian_Classifier.Accuracy.ToString() + "%";
		}

		private void btn_Show_Click(object sender, EventArgs e)
		{
			Bitmap Bmap = new Bitmap(28, 28);
			int End = 28;
			int i = 0, j = 0, k = 0;
			byte PixelValue;
			ImagePattern IP = null;
			if (rdoBtn_TrainingSet.Checked)
				IP = Bayesian_Classifier._MnistTrainingDatabase.m_pImagePatterns[(int)(numericUpDown1.Value - 1)];
			else if (rdoBtn_TestingSet.Checked)
				IP = Bayesian_Classifier._MnistTestingDatabase.m_pImagePatterns[(int)(numericUpDown1.Value - 1)];
			while (i < 28)
			{
				k = 0;
				for (j = i * 28; j < End; j++)
				{
					PixelValue = IP.pPattern[j];
					if (chckBx_Threshold.Checked && PixelValue < 255)
						PixelValue = 0;
					Bmap.SetPixel(k, i, Color.FromArgb(PixelValue, PixelValue, PixelValue));
					k++;
				}
				i++;
				End = (i + 1) * 28;
			}
			label1.Text = IP.nLabel.ToString();
			pictureBox1.Image = (Image)Bmap;
			if (rdoBtn_TestingSet.Checked)
				textBox1.Text = Bayesian_Classifier.TestingClassifiedClass[(int)(numericUpDown1.Value - 1)].ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
