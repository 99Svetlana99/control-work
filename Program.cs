// Способ с использованием классовых методов 
// string[] mas = { "Россия", "Казань", "три", "3" };
// string[] result = Array.FindAll(mas, word => word.Length <= 3);

// Ручной способ
string[] mas = { "Россия", "Казань", "три", "3" };
int arrayPoints = 0;


for (int i = 0; i < mas.Length; i++)
{
    if (mas[i].Length <= 3)
    {
        arrayPoints++;
    };
}

string[] result = new string[arrayPoints];

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i].Length <= 3)
    {
        for (int j = 0; j < result.Length; j++)
        {
            if (result[j] == null)
            {
                result[j] = mas[i];
                break;
            };
        }
    };
}

for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}
