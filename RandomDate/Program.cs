Random random = new Random();
int daysInMonth;
// Случайный месяц от 1 до 12
int month = random.Next(1, 13);
// Случайный год между 2000 и 2024
int year = random.Next(2000, 2025);

switch (month)
{
    case 2:
        daysInMonth = DateTime.IsLeapYear(year) ? 29 : 28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        daysInMonth = 30;
        break;
    default:
        daysInMonth = 31;
        break;
}

int day = random.Next(1, daysInMonth + 1);
Console.WriteLine($"Случайная дата: {day}.{month}.{year}");