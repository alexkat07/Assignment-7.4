namespace Assignment_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class ParkingSystem
    {
        int bigSpace;
        int midSpace;
        int smallSpace;

        public ParkingSystem(int big, int medium, int small)
        {
            this.bigSpace = big;
            this.midSpace = medium;
            this.smallSpace = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 3:
                    if (this.smallSpace != 0)
                    {
                        this.smallSpace--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (this.midSpace != 0)
                    {
                        this.midSpace--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 1:
                    if (this.bigSpace != 0)
                    {
                        this.bigSpace--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }
    }
}
