//Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
Console.Clear();
static short RomanToArab(string roman = "IV")
        {
            short result = 0;
            var RomToArab = new Dictionary<char, short>
            {{ 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },{ 'C', 100 },{ 'D', 500 },{ 'M', 1000 } };
            for (short i = 0; i < roman.Length - 1; ++i)
            {
                if (RomToArab[roman[i]] < RomToArab[roman[i + 1]]) result -= RomToArab[roman[i]];
                else if (RomToArab[roman[i]] >= RomToArab[roman[i + 1]]) result += RomToArab[roman[i]];
            }
            return result += RomToArab[roman[^1]];
        }
 
Console.WriteLine(RomanToArab("MCMLXXXI"));