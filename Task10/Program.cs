// task10
Console.Clear();
int a = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Сгенерированное число {a}");
a = (a/10)%10;
Console.WriteLine(a);