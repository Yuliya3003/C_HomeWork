// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) {
    Console.WriteLine("Третьей цифры нет");
}
while (num > 999) {
    num /= 10;
}
int num2 = num%10;
Console.WriteLine(num2);