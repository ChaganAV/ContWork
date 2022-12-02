string[] arrayString = {"Вася","Кира","моль","2","ха","0","ухо","горло","нос","вилка","бутерброт"};
int sizeWord = 3;

int count = SizeArray(arrayString, sizeWord);
string[] arrayWold = new string[count];


// Функции
int SizeArray(string[] array,int max)
{
    int count = 0;
    for(int i=0; i <= array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    return count;
}


