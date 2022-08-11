Console.WriteLine("Введите день недели");
int n = Convert.ToInt32(Console.ReadLine());
	if (n == 6 || n == 7)
    {
        Console.WriteLine("Да");    
    }
	else if (n < 1 || n > 7)
    {
        Console.WriteLine("У нас всего 7 дней в неделе!");    
    }
	else
    {
        Console.WriteLine("Нет"); 
    } 
		