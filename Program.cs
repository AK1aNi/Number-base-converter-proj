namespace Number_base_converter_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your denary number: ");
            int d_num = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("What base do you want to convert it to: ");
            int base_n = Convert.ToInt32(Console.ReadLine());

            string binary = "";
            if (base_n == 2)
            {
                while (d_num > 0)
                {
                    binary = Convert.ToString(d_num % 2) + binary;
                    d_num = d_num / 2;
                }

                Console.WriteLine(binary);
            }
            string hex = "";
            if (base_n == 16)
            {
                int first_p = d_num / 16;
                int remain_p = d_num % 16;

                if (first_p < 10)
                {
                    hex = Convert.ToString(first_p) + hex;
                }
                else
                {
                    hex = Convert.ToString(Convert.ToChar(first_p + 55)) + hex;

                }

                if (remain_p < 10)
                {
                    hex = hex + Convert.ToString(remain_p);
                }
                else
                {
                    hex = hex + Convert.ToString(Convert.ToChar(remain_p + 55));
                }

                Console.WriteLine(hex);
            }


           

        }
    }
}
