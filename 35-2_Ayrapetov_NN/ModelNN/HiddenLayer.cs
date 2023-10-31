namespace _35_2_Ayrapetov_NN.ModelNN
{
    class HiddenLayer : Layer
    {
        public HiddenLayer(int non, int nopn, NeuroType nt, string name) : base(non, nopn, nt, name) { }
        
        public override void Recognize(Network net, Layer nextLayer)
        {
            double[] hidden_out = new double[Neurons.Length];
            for (int i = 0; i < Neurons.Length; i++)
                hidden_out[i] = Neurons[i].Output;
            nextLayer.Data= hidden_out;
        }
        public override double[] BackwardPass(double[] gr_sums)
        {
            double[] gr_sum = new double[numOfPrevNeurons];
            return gr_sum;
        }
    }
}
