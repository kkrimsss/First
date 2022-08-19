Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int div = 0;
	while (i > 0){
		div = i % 10;
		i = i / 10;
		sum = sum + div;
	}
Console.WriteLine(sum);
