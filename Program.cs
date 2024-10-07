namespace Polymorphic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar electricCar = new ElectricCar();

            Console.Write("Please Enter charge of car: ");
            double kilometer = double.Parse(Console.ReadLine());


            electricCar.MeasurementCapacityBatry(kilometer);




        }
    }
}