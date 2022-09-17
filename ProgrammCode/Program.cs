//Написать программу, которая из имеющегося массива строк формирует 
//массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
//Примеры: 
//["не1!о" "2" "world", ":-)") -> ["2" ":.. '] 
//["1234", "1567", "-2", "сотринег асгепсе") -> ["-2") 
//["Ruccie", "оептar1:", "Катал"] -> О 


Console.WriteLine("Введите количество элементов массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string [] array = GetArray(arraySize);
Console.WriteLine($"Ваш массив: [ {String.Join(" | ", array)} ]");

Console.WriteLine($"Получившийся массив из элементов не более 3-х символов: [ {String.Join(" | ", NewArray(array))} ] ");


string [] GetArray (int length)
{
    string [] buildArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива №{i+1}: ");
        buildArray[i] = Console.ReadLine();
    }
    return buildArray;
}

string [] NewArray (string [] array)
{
    
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <=3) 
        {
            n++;
        }
    }
    string [] newArray = new string[n];
    n = 0;
     for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <=3) 
        {
           newArray[n] = array[i];
            n++;
        }
    }
    
    return newArray;
}