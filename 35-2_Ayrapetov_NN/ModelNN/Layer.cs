using System;
using System.IO;

namespace _35_2_Ayrapetov_NN.ModelNN
{
    abstract class Layer
    {
        // поля
        protected string name_Layer; // наименование слоя
        string pathDirWeights; // путь к директории весов
        string pathFileWeights; // путь к файлу весов
        protected int numOfNeurons; // число нейронов
        protected int numOfPrevNeurons; // число нейронов на пред слое
        protected const double learningRate = 0.5; // скорость обучения
        protected const double momentum = 0.05; // настройка метода оптимизации
        protected double[,] lastDeltaWeights; // последнее изменение весов
        private Neuron[] neurons;

        // свойства
        public Neuron[] Neurons
        {
            get { return neurons; }
            set { neurons = value; }
        }

        public double[] Data
        {
            set
            {
                foreach (var neuron in Neurons)
                {
                    neuron.Inputs = value;
                    neuron.Activator();
                }
            }
        }
        protected Layer(int non, int nopn, NeuroType nt, string nm_Layer)
        {
            numOfNeurons = non;
            numOfPrevNeurons = nopn;
            Neurons = new Neuron[non];
            name_Layer = nm_Layer;
            pathDirWeights = AppDomain.CurrentDomain.BaseDirectory + "memory\\";
            pathFileWeights = pathDirWeights + name_Layer + "memory.csv"; 

            double[,] Weights; // временный массив синаптических весов текущего слоя

            if (File.Exists(pathFileWeights)){
                Weights = WeightInitialize(MemoryMode.GET, pathFileWeights);
            }
            else
            {
                Directory.CreateDirectory(pathFileWeights);
                Weights = WeightInitialize(MemoryMode.INIT, pathFileWeights);

            }

            lastDeltaWeights = new double[non, nopn + 1];
            for (int i = 0; i < non; i++)
            {
                double[] tmp_weights = new double[nopn+1];
                for (int j = 0; j < nopn+1; j++)
                {
                    tmp_weights[j] = Weights[i, j];
                }
                Neurons[i] = new Neuron(tmp_weights, nt);
            }
        }

        abstract public void Recognize(Network net, Layer nextLayer);
        abstract public double[] BackwardPass(double[] stuff);

        public double[,] WeightInitialize(MemoryMode mm, string path)
        {
            char[] delim = new char[] { ';', ' ' }; // разделители слов
            string tmpStr; // временная строка для чтения
            string[] tmpStrWeights; // временный массив строк
            double[,] weigths = new double[numOfNeurons, numOfPrevNeurons + 1];

            switch (mm)
            {
                case MemoryMode.GET:
                    tmpStrWeights = File.ReadAllLines(path);
                    string[] memory_element;
                    for(int i = 0; i < numOfNeurons; i++)
                    {
                        memory_element = tmpStrWeights[i].Split(delim);
                        for (int j = 0; j < numOfPrevNeurons+1; j++)
                        {
                            weigths[i, j] = double.Parse(memory_element[j].Replace(',', '.'),
                                System.Globalization.CultureInfo.InvariantCulture);
                        }
                    }
                    break;
                case MemoryMode.SET:
                    tmpStrWeights = new string[numOfNeurons];

                    for (int i = 0; i < numOfNeurons; i++)
                    {
                        tmpStr = Neurons[i].Weights[0].ToString();
                        // тут дописать
                    }
                    break;
                case MemoryMode.INIT:
                    Random rand = new Random();

                    // инициализация весов:
                    // 1. веса инициализируются случайными величинами
                    // 2. мат ожидание всех весов нейрона должно равняться 0
                    // 3. среднее квадратическое значение должно равняться 1
                    // 

                    for (int i = 0; i < numOfNeurons; i++)
                    {
                        // вычисления происходят здесь (дописать код инициализации весов)

                        for (int j = 0; j < numOfPrevNeurons+1; j++)
                        {
                            tmpStr += delim[0] + weigths[i, j].ToString();
                        }
                        tmpStrWeights[i] = tmpStr;

                    }
                    File.WriteAllLines(path, tmpStrWeights);

                    break;
                default:
                    break;
            }
            return weigths;
        }
    }
}
