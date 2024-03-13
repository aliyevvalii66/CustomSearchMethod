using CustomSearch;


Console.Write("Arrayın uzunluğunu daxil edin : ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i+1})Eded daxil edin : ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("");
Console.WriteLine("------------------------------------------------");
array.CustomSort(); //Array sort olunur
string sortArray = "";
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1) sortArray += $"{array[i].ToString()}";
    else sortArray += $"{array[i].ToString()} , ";
}
Console.WriteLine(sortArray);


Console.Write("Arrayda axtarmaq istediyiniz ededi daxil edin : ");
int searchNumber = int.Parse(Console.ReadLine());
int result = BinarySearch(array , 0,array.Length -1  , searchNumber); //Search methodundan qayidan deyer resula menimsedilir
Console.WriteLine("");
Console.WriteLine("------------------------------------------------");

if (result != -1) Console.WriteLine($"Ededin indexi ---> {result}");
else Console.WriteLine($"{searchNumber} ededi daxil edilen arrayda tapilmadi.");


static int BinarySearch(int[] numbers, int firstIndex, int lastIndex, int searchNumber)
{   
    if (firstIndex > lastIndex) return -1;

    int middleIndex = (firstIndex + lastIndex) / 2;

    if (numbers[middleIndex] > searchNumber)
    {
        return BinarySearch(numbers, firstIndex, middleIndex - 1, searchNumber);
    }
    else if (numbers[middleIndex] < searchNumber)
    {
        return BinarySearch(numbers, middleIndex + 1, lastIndex, searchNumber);
    }
    else
    {
        return middleIndex;
    }
}



Console.ReadKey();
