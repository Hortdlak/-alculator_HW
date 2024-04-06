
namespace Сalculator_HW
{
    internal class Program
    {
        static void Main(string[] received_data)
        {
            //Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b,
            //введенные из командной строки, и выводящую результат выполнения на экран.

                if (received_data == null || received_data.Length != 3)
                {
                    Console.WriteLine("Необходимо ввести число, затем знак, а после второе число. Количество элементов не должно превышать трех.");
                }
                else
                {
                    Сalculator(received_data);
                }
             
        }

        private static void Сalculator(string[] received_data)
        {
            if (double.TryParse(received_data[0], out double number_1) && (double.TryParse(received_data[2], out double number_2)))
            {
                double result;
                switch (received_data[1]) 
                {
                    case "+":
                        result = number_1 + number_2;
                            break;

                    case "-":
                        result = number_1 - number_2;
                            break;

                    case "*":
                        result = number_1 * number_2;
                            break;

                    case "/":
                        if (number_2==0)
                        {
                            Console.WriteLine("Тут нельзя делить на ноль");
                            return;
                        }
                        else
                        {
                            result = number_1 / number_2;
                                break;
                        }
                        

                    case "%":
                        if (number_2 == 0)
                        {
                            Console.WriteLine("Тут нельзя делить на ноль");
                            return;
                        }
                        else
                        {
                            result = number_1 % number_2;
                            break;
                        }

                    default:
                        Console.WriteLine("Выбран не корректный тип операции");
                        return;

                }
                Console.WriteLine($"Результат {received_data[0]} {received_data[1]} {received_data[2]} = {result}");

            }
            else { Console.WriteLine("Первый и третий элемент должен быть числом"); }
            
        }
    }
}
