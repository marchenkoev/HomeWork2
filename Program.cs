// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine(stringNumber[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine(anyNumberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("День недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int DayNumber) {
  if (DayNumber == 6 || DayNumber == 7) {
  Console.WriteLine("(Выходной) -> да");
  }
  else if (DayNumber < 1 || DayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("(Будний день) -> нет");
}

CheckingTheDayOfTheWeek(DayNumber);