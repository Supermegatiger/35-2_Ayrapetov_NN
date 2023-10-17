using static System.Math;


namespace _35_2_Ayrapetov_NN.ModelNN{

    class Neuron{
        // поля
        private NeuroType type;
        private double[] inputs;
        private double[] weights;
        private double derivative;

        private double output;

        // свойства 
        public double[] Inputs
        {
            get { return inputs; }
            set { inputs = value; }
        }

        public double[] Weights
        {
            get { return weights; }
            set { weights = value; }
        }

        public double Derivative
        {
            get { return derivative; }
        }

        public double Output
        {
            get { return output; }
        }

        // конструктор

        public Neuron(double[] ws, NeuroType t){
            type = t;
            weights = ws;
        }

        public void Activator(){
            // первый элемент weights - b (порог)
            double sum = weights[0];
            for (int i = 0; i < inputs.Length; i++){
                sum += inputs[i] * weights[i+1];
            }

            switch (type)
            {
                case NeuroType.Output:
                    output = Exp(sum);
                    break;
                case NeuroType.Hidden:
                    output = th(sum);
                    derivative = derivator(sum);
                    break;
                default:
                    break;
            }
        }

        // функция активации (гиперболический тангенс)
        private double th(double x){
            return x;
        }

        // вычисление производной
        private double derivator(double x){
            return x;
        }
    }
}
