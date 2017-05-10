using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Windows.Forms;
using System.IO;

namespace ReadingMNISTDatabase
{
	class Bayesian_Classifier
	{
		public static MNIST_Database _MnistTrainingDatabase;
		public static MNIST_Database _MnistTestingDatabase;
		const int NumberOfClasses = 10;
		const int NumberOfFeatures = 28 * 28;
		const int TrainingSamples = 60000;
		static double[,] TrainingFeatures = new double[TrainingSamples, NumberOfFeatures];
		static int[] TrainingLabeledClass = new int[TrainingSamples];
		static double[,] Mean = new double[NumberOfClasses, NumberOfFeatures];
		static int[] NumberOfTrainingLabeledSamples = new int[NumberOfClasses];
		static double[,] Covariance = new double[NumberOfClasses, NumberOfFeatures];
		const int TestingSamples = 10000;
		static double[,] TestingFeatures = new double[TestingSamples, NumberOfFeatures];
		static int[] TestingLabeledClass = new int[TestingSamples];
		public static int[] TestingClassifiedClass = new int[TestingSamples];
		public static int[,] ConfutionMatrix = new int[NumberOfFeatures, NumberOfFeatures];
		public static double Accuracy;

		public static void Classify()
		{
			Initialize();
			TrainModel();
			TestModel();
		}

		static void Initialize()
		{
			for (int i = 0; i < NumberOfClasses; ++i)
			{
				NumberOfTrainingLabeledSamples[i] = 0;
				for (int j = 0; j < NumberOfFeatures; ++j)
				{
					Mean[i, j] = 0;
					Covariance[i, j] = 0;
				}
			}
			for (int i = 0; i < NumberOfFeatures; ++i)
				for (int j = 0; j < NumberOfFeatures; ++j)
					ConfutionMatrix[i, j] = 0;
		}

		static void TrainModel()
		{
			ReadTraining();
			GetMeans();
			GetCovariance();
		}

		static void ReadTraining()
		{
			for (int i = 0; i < TrainingSamples; ++i)
			{
				ImagePattern IP = Bayesian_Classifier._MnistTrainingDatabase.m_pImagePatterns[i];
				int LabeledClass = IP.nLabel;
				TrainingLabeledClass[i] = LabeledClass;
				++NumberOfTrainingLabeledSamples[LabeledClass];
				for (int j = 0; j < NumberOfFeatures; ++j)
					if (IP.pPattern[j] == 255)
						TrainingFeatures[i, j] = 1;
					else
						TrainingFeatures[i, j] = 0;
			}
		}

		static void GetMeans()
		{
			for (int i = 0; i < TrainingSamples; ++i)
				for (int j = 0; j < NumberOfFeatures; ++j)
					Mean[TrainingLabeledClass[i], j] += TrainingFeatures[i, j];
			for (int i = 0; i < NumberOfClasses; ++i)
				for (int j = 0; j < NumberOfFeatures; ++j)
					Mean[i, j] /= (double)NumberOfTrainingLabeledSamples[i];
		}

		static void GetCovariance()
		{
			double[,] TrainingSum = new double[NumberOfClasses, NumberOfFeatures];
			for (int i = 0; i < NumberOfClasses; ++i)
				for (int j = 0; j < NumberOfFeatures; ++j)
					TrainingSum[i, j] = 0;
			for (int i = 0; i < TrainingSamples; ++i)
				for (int j = 0; j < NumberOfFeatures; ++j)
					TrainingSum[TrainingLabeledClass[i], j] += (TrainingFeatures[i, j] - Mean[TrainingLabeledClass[i], j]) * (TrainingFeatures[i, j] - Mean[TrainingLabeledClass[i], j]);
			for (int i = 0; i < NumberOfClasses; ++i)
				for (int j = 0; j < NumberOfFeatures; ++j)
					Covariance[i, j] = TrainingSum[i, j] / NumberOfTrainingLabeledSamples[i];
		}

		static void TestModel()
		{
			ReadTesting();
			for (int i = 0; i < TestingSamples; ++i)
				TestingClassifiedClass[i] = TestSample(i);
			GetConfutionMatrix();
			CalculateAccuracy();
		}

		static void ReadTesting()
		{
			for (int i = 0; i < TestingSamples; ++i)
			{
				ImagePattern IP = Bayesian_Classifier._MnistTestingDatabase.m_pImagePatterns[i];
				int LabeledClass = IP.nLabel;
				TestingLabeledClass[i] = LabeledClass;
				++NumberOfTrainingLabeledSamples[LabeledClass];
				for (int j = 0; j < NumberOfFeatures; ++j)
					if (IP.pPattern[j] == 255)
						TestingFeatures[i, j] = 1;
					else
						TestingFeatures[i, j] = 0;
			}
		}

		static double BayesianEquation(double Mean, double Covariance, double Feature)
		{
			return Math.Exp(-0.5 * Math.Pow((Feature - Mean), 2) / Covariance) / Math.Sqrt(2 * Math.PI * Covariance);
		}

		static int TestSample(int Index)
		{
			double MaxScore = double.MinValue;
			int ClassifiedClass = 0;
			for (int i = 0; i < NumberOfClasses; ++i)
			{
				double[] Arr = new double[NumberOfFeatures];
				double Score = 1;
				for (int j = 0; j < NumberOfFeatures; ++j)
				{
					if (Covariance[i, j] == 0)
						continue;
					if (Score == 0)
						Score = BayesianEquation(Mean[i, j], Covariance[i, j], TestingFeatures[Index, j]);
					else
						Score *= BayesianEquation(Mean[i, j], Covariance[i, j], TestingFeatures[Index, j]);
				}
				if (Score > MaxScore)
				{
					MaxScore = Score;
					ClassifiedClass = i;
				}
			}
			return ClassifiedClass;
		}

		static void GetConfutionMatrix()
		{
			for (int i = 0; i < TestingSamples; ++i)
				++ConfutionMatrix[TestingLabeledClass[i], TestingClassifiedClass[i]];
		}

		static void CalculateAccuracy()
		{
			int Sum = 0;
			for (int i = 0; i < NumberOfClasses; ++i)
				Sum += ConfutionMatrix[i, i];
			Accuracy = (double)Sum * 100 / TestingSamples;
		}
	}
}
