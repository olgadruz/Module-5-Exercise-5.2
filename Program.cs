namespace TemperaturesComparison;

class Program
{
    static void Main(string[] args)

    {
        double previous = 0;
        bool increasing = false;
        bool decreasing = false;
        int temp_readed = 0;
        double sum = 0;
        double[] temperatures = new double[5];
        for (; temp_readed < 5;)
        {
            string inp = Console.ReadLine();
            string[] splited = inp.Split(" ");
            int inp_size = splited.Length;
            double current_temperature = Convert.ToDouble(splited[inp_size - 1]);

            if (current_temperature < -30 || current_temperature > 130)
            {
                Console.WriteLine("Temperature " + current_temperature + " is invalid, Please enter a valid temperature between -30 and 130");
                continue;
            }
            temperatures[temp_readed] = current_temperature;
            temp_readed++;
            if (temp_readed > 1)
            {
                if (previous < current_temperature)
                {
                    increasing = true;
                }
                if (previous > current_temperature)
                {
                    decreasing = true;
                }

            }
            previous = current_temperature;
            sum = current_temperature + sum;

        }
        if (increasing && decreasing)
        {
            Console.WriteLine("It's a mixed bag");
        }
        else if (increasing)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (decreasing)
        {
            Console.WriteLine("Getting cooler");
        }
        Console.Write("5-day Temperature [");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(temperatures[i]);
            if (i < 4)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        Console.WriteLine("Average Temperature is " + sum / 5 + " degrees");
    }
}
