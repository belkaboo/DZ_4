Console.WriteLine(" Task number (25 27 29) : ");
int task = Convert.ToInt32(Console.ReadLine());

if (task == 25)

{
    Console.Clear();
    Console.WriteLine("Input number: ");
    bool parsedNum = int.TryParse(Console.ReadLine(), out int num1);
    Console.WriteLine("Input exponent: ");
    bool parsedPowNum = int.TryParse(Console.ReadLine(), out int num2);
    if (!parsedNum || !parsedPowNum || num2 <= 0 || num1 < 0)
    {
        Console.WriteLine($" Error! The numbers are incorrect for this task ");
        return;

    }

    int MathPow(int number, int pow)
    {
        int result = number;
        for (int i = 1; i < pow; i++)
        {
            result *= number;
        }
        return result;



    }
    Console.WriteLine($"{num1} ^ {num2} = {MathPow(num1, num2)}");

}

if (task == 27)
{
    Console.Clear();
    Console.WriteLine("Input number: ");
    bool parsedA = int.TryParse(Console.ReadLine(), out int a);
    if (!parsedA)
    {
        Console.WriteLine($" Error! The numbers are incorrect for this task ");
        return;

    }


    int GetSumOfnumbers(int number)
    {
        int sum = 0;
        for (sum = 0; number > 0; number /= 10)
        {
            sum += number % 10;
        }

        return sum;
    }

    Console.WriteLine($"Result = {GetSumOfnumbers(a)}");

}

if (task == 29)
{
    Console.Clear();

    Console.Write("Input size of array: ");
    bool parsedSize = int.TryParse(Console.ReadLine(), out int size1);
    if (!parsedSize)
    {
        Console.WriteLine("Incorrect size");
        return;
    }

    void FillPrintArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Input {i + 1} element of array: ");
            bool parsedNum = int.TryParse(Console.ReadLine(), out int num);
            if (!parsedNum)
            {
                Console.WriteLine("Error! Incorrect number.");
                i -= 1;
            }
            else
            {
                array[i] = num;
            }
        }

        Console.Write("[ "); // колхозное решение
        for (int j = 0; j < array.Length; j++)
        {

            Console.Write($"{array[j]} ");
        }
        Console.Write("]"); // колхозное решение

    }

    FillPrintArray(size1);
}
