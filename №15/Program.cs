
        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        public void task_15()
        {
            Console.WriteLine("ЗАДАЧА №15");
            Console.Write("Введите номер дня недели:");
            int num = Input();
            if (num >=1 && num <=5)
            {
                Console.WriteLine($"{DayWeek(num)}! Это будний день!");
            }
            else if (num == 6 || num == 7)
            {
                Console.WriteLine($"{DayWeek(num)}! Ура! Это выходной день!");
            }
            else
            {
                Console.WriteLine("Введите корректное значение от 1 до 7!");
            }
            BeautuLine();
        }

        static string DayWeek(int num)
        {
            string dayWeek = "";
            if (num == 1)
            {
                dayWeek = "Понедельник";
                return dayWeek;
            }
            else if (num == 2)
            {
                dayWeek = "Вторник";
                return dayWeek;
            }
            else if (num == 3)
            {
                dayWeek = "Среда";
                return dayWeek;
            }
            else if (num == 4)
            {
                dayWeek = "Четверг";
                return dayWeek;
            }
            else if (num == 5)
            {
                dayWeek = "Пятница";
                return dayWeek;
            }
            else if (num == 6)
            {
                dayWeek = "Суббота";
                return dayWeek;
            }
            else if (num == 7)
            {
                dayWeek = "Воскресение";
                return dayWeek;
            }
            else
            {
                dayWeek = "Введитет число от 1 до 7!!!";
                return dayWeek;
            }
        }
    }
}