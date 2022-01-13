
namespace MRZuIS1
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageToRects test1 = new ImageToRects(@"D:\Sem5\МРЗ\Lab1.2\Images\242.jpeg");
            NeuralNetwork network = new NeuralNetwork(test1.ConvertToRects());
            network.Train();
            RectsToImage image = new RectsToImage(network.GetCompressedRects(), @"D:\Sem5\МРЗ\Lab1.2\CompressedImages\test1o.jpg");
            image.ConstructImage();
        }
    }
}
