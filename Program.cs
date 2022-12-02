string[] arrayString = {"Вася","Кира","моль","2","ха","0","ухо","горло","нос","вилка","бутерброт"};
int sizeWord = 3;

int count = SizeArray(arrayString, sizeWord);
string[] arrayWold = new string[count];
// заполним массив значениями
FillArray(arrayString, arrayWold);
Console.WriteLine("Массив на входе");
PrintArray(arrayString);
Console.WriteLine("Массив на выходе");
PrintArray(arrayWold);

// Функции
int SizeArray(string[] array,int max)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    return count;
}

void FillArray(string[] arrayIn, string[] arrayOut)
{
    int count = 0;
    for(int i = 0; i < arrayIn.Length; i++)
    {
        if(arrayIn[i].Length <= 3)
        {
            arrayOut[count] = arrayIn[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1)
            Console.Write($"\"{array[i]}\", ");
        else
            Console.Write($"\"{array[i]}\"]");
    }
    Console.WriteLine();
}
