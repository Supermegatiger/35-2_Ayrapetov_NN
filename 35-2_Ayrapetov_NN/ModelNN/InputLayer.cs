using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_2_Ayrapetov_NN.ModelNN
{
    class InputLayer
    {
        private Random random = new Random();
        //private (double[], int)[] trainSet = new (double[], int)[100]; //100 - кол-во примеров
        private (double[], int)[] trainSet; //100 - кол-во примеров

        public (double[], int)[] TrainSet { get => trainSet; }

        public InputLayer(NetworkMode nm)
        {
            switch (nm)
            {
                case NetworkMode.Train:
                    string path = AppDomain.CurrentDomain.BaseDirectory + "trainData.txt";
                    string[] dataSetStr = File.ReadAllLines(path);
                    string[] dataElem;
                    double[] inputs;
                    trainSet = new (double[], int)[dataSetStr.Length];
                    for (int i = 0; i < dataSetStr.Length; i++)
                    {
                        dataElem = dataSetStr[i].Split(' ');
                        inputs = new double[dataElem.Length - 1];
                        for (int j = 1; j < dataElem.Length; j++)
                        {
                            inputs[j-1] = int.Parse(dataElem[j],
                                System.Globalization.CultureInfo.InvariantCulture);
                        }
                        trainSet[i] = (inputs, int.Parse(dataElem[0],
                                System.Globalization.CultureInfo.InvariantCulture));
                    }
                    //Здесс написать код считывания обучающего множества
                    //из файла и формирование массива TrainSet

                    // Перетасовка методом Фишера-Йетса
                    for (int i = trainSet.Length-1; i > 0; i--)
                    {
                        int j = random.Next(i + 1);
                        var temp = trainSet[i];
                        trainSet[i] = trainSet[j];
                        trainSet[j] = temp;
                    }

                    break;
                case NetworkMode.Test:
                    break;
                case NetworkMode.Recognize:
                    break;
            }
        }
    }
}
