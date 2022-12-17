// Майборода А.А. Вар 3 - Высокий уровень
var number = Console.ReadLine();
number = number.PadLeft((number.Length % 4 == 0 ? 0 : 4 - number.Length % 4) + number.Length, '0');

for (var groupIndex = 0; groupIndex < number.Length / 4; groupIndex++)
{
    if (groupIndex == 0) continue;

    var charStartIndex = groupIndex * 4 + 3;
    double groupResult = 0;
    for (var charIndex = charStartIndex; charIndex > charStartIndex - 4; charIndex--)
    {
        groupResult += Math.Pow(2, (charStartIndex - charIndex) % 4) * int.Parse(number[charIndex].ToString());
    }

    if (groupResult >= 10)
    {
        var symbolToWrite = groupResult switch
        {
            10 => 'A',
            11 => 'B',
            12 => 'C',
            13 => 'D',
            14 => 'E',
            15 => 'F',
            _ => ' '
        };

        Console.Write(symbolToWrite);
    }
    else Console.Write(groupResult);
}