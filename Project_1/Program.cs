//Создание первого массива
string[] Array = {"1234", "1567", "-2", "computer science"};
//Нахождение длинны нового массива
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        count++;
    }
}
//Создание нового массива
string[] NewArray = new string [count];
//Заполнение нового массива
int j = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        NewArray[j] = Array[i];
        j++;
    }
}
//Печать нового массива
for (j = 0; j < NewArray.Length; j++)
{
    System.Console.WriteLine(NewArray[j]);

}