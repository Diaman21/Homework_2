        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        public void task_13()
        {
            Console.WriteLine("ЗАДАЧА №13");
            Console.WriteLine("Введите любое число: ");
            int num = Math.Abs(Input());

            string numTxt = Convert.ToString(num);
            if (numTxt.Length > 2)
            {
                Console.WriteLine($"Третья цифра: {numTxt[2]}");
            }
            else
            {
                Console.WriteLine("Третьей цифры нет!");
            }
            BeautuLine();
        }