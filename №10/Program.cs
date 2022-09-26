        public void task_10()
        {
            Console.WriteLine("ЗАДАЧА №10");
            Console.WriteLine("Введите трехзначное число: ");
            int num = Input();
            if (num > 99 && num < 1000) 
            { 
            int two = num / 10 % 10;
            Console.WriteLine($"Вторая цифра вашего число: {two}");
            }
            else
            {
                Console.WriteLine("Неправльная размерность числа");
            }

            BeautuLine();
        }