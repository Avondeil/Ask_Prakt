Console.Write("Введите код ISBN-10 для проверки правильности контрольной цифры (пример для проверки 5-93286-005-7): ");
string isbn_10 = Console.ReadLine().Replace("-", "");
int sum=0, count = 10;
// Реализуем цикл for
for (int i = 0; i < 10; i++)
{
    sum += Convert.ToInt32(isbn_10[i] == 'X' ? 10 : int.Parse(isbn_10[i].ToString())*count);
    count--;
}

bool isValid = sum % 11 == 0;
Console.WriteLine(isValid ? "Контрольная цифра правильная, код ISBN валидный" : "Контрольная цифра не правильная, код ISBN не валидный");
