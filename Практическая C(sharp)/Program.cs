
double number1 = 0;
double number2 = 0;
bool checker = true;
int Variable = 0;
            

            Console.WriteLine("Добро пожаловать в калькулятор");

            do
            {
                Console.WriteLine("1.Сложить 2 числа \n 2.Вычесть первое из второго \n 3.Перемножить два числа \n 4.Разделить первое на второе \n 5.Возвести в степень N первое число \n 6.Найти квадратный корень из числа \n 7.Найти 1 процент от числа \n 8.Найти факториал из числа \n 9.Выйти из программы");
    // Console.WriteLine - вывела все варианты действий

                Variable = Convert.ToInt32(Console.ReadLine());

                switch (Variable)
                {
                    case 1:
                        Console.WriteLine("Введите первое число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", number1 + number2);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", number2 - number1);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", number2 * number1);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", number1 / number2);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 5:
                        Console.WriteLine("Введите число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень числа");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", Math.Pow(number1, number2));
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 6:
                        Console.WriteLine("Введите число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", Math.Sqrt(number1));
                        Console.WriteLine("Ведите другую операцию");
                        break;
                   
        
                        case 7:
                        Console.WriteLine("Введите число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: " + (number1 / 100));
                        Console.WriteLine("Ведите другую операцию");

                        break;


                    case 8:
                   Console.WriteLine("Введите число");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        double factorial = 1;
                        for (int i = 1; i <= number1; i++)
                        {
                            factorial *= i;
                        }
                        Console.Write("Результат: ");
                        Console.WriteLine(factorial);
                        Console.WriteLine("Ведите другую операцию");
                        break;


                    case 9:
                        checker = false;

                        break;
                    default: Console.WriteLine("Ошибка, введите другую операцию"); 
                        break;
                   

                }
            } while (checker);
Console.WriteLine("Спасибо за использование Бета версии, оставьте отзыв в виде оценки от 2 до 5");
int grage;
grage = Convert.ToInt32(Console.ReadLine());
if (grage != 5)
{   do
    {
        Console.WriteLine("Вы наверняка ошиблись, введите другую оценку");

        grage = Convert.ToInt32(Console.ReadLine());
    }
    while (grage != 5);
}

Console.WriteLine("Спасибо за такой высокий отзыв)");




