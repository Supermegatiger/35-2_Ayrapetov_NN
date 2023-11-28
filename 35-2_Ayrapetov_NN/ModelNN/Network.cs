using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_2_Ayrapetov_NN.ModelNN
{
    class Network
    {
        //Массив для хранения вектора выходного сигнала нейросети
        public double[] Fact = new double[10];

        //Все слои нейросети
        private InputLayer input_layer = null;
        private HiddenLayer hidden_layer1 = new HiddenLayer(70, 15, NeuroType.Hidden, nameof(hidden_layer1));
        private HiddenLayer hidden_layer2 = new HiddenLayer(31, 70, NeuroType.Hidden, nameof(hidden_layer2));
        private OutputLayer output_layer = new OutputLayer(10, 31, NeuroType.Output, nameof(output_layer));

        // Среднее значение энергии ошибки эпохи обучения
        private double e_error_avg;

        //Свойства
        public double E_error_avg
        {
            get { return e_error_avg; }
            set { e_error_avg = value; }
        }

        //Конструктор
        public Network(NetworkMode nm)
        {
            input_layer = new InputLayer(nm);
        }

        //Прямой проход сигнала по нейросети
        public void ForwardPass(Network net, double[] net_input)
        {
            net.hidden_layer1.Data = net_input;
            net.hidden_layer1.Recognize(null, net.hidden_layer2);
            net.hidden_layer2.Recognize(null, net.output_layer);
            net.output_layer.Recognize(net, null);
        }
    }
}
