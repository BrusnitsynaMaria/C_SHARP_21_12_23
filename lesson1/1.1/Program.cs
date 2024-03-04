Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

// String a1 = Console.ReadLine()!;
// String b1 = Console.ReadLine()!;
// int a = Convert.ToInt32(a1);
// int b = Convert.ToInt32(b1);

if(a == b * b) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}