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

                Console.WriteLine(d_num+" converted to binary is "+binary);
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
                    if (first_p == 10)
                    {
                        hex = "A" + hex;
                    }
                    if (first_p == 11)
                    {
                        hex = "B" + hex;
                    }
                    if (first_p == 12)
                    {
                        hex = "C" + hex;
                    }
                    if (first_p == 13)
                    {
                        hex = "D" + hex;
                    }
                    if (first_p == 14)
                    {
                        hex = "E" + hex;
                    }
                    if (first_p == 15)
                    {
                        hex = "F" + hex;
                    }

                }

                if (remain_p < 10)
                {
                    hex = hex + Convert.ToString(remain_p);
                }
                else
                {
                    if (remain_p == 10)
                    {
                        hex = hex + "A";
                    }
                    if (remain_p == 11)
                    {
                        hex = hex + "B";
                    }
                    if (remain_p == 12)
                    {
                        hex = hex + "C";
                    }
                    if (remain_p == 13)
                    {
                        hex = hex + "D";
                    }
                    if (remain_p == 14)
                    {
                        hex = hex + "E";
                    }
                    if (remain_p == 15)
                    {
                        hex = hex + "F";
                    }

                }

                Console.WriteLine(d_num + "converted to hexdecimal is "+hex);
            }

        }
    }
}
