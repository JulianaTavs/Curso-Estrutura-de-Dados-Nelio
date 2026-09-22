static string FormatDate(int day, int month, int year)
{
    return string.Format("{0:D2}/{1:D2}/{2:D4}", day, month, year);
}

Console.WriteLine(FormatDate(21, 7, 2010));
