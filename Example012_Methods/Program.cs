// Методы

// Вид 1. Ничего НЕ ПРИНИМАЮТ, и ничего НЕ ВОЗВРАЩАЮТ
/*
void Method1()
{
	Console.WriteLine("Created by SmiTTR77");
}

Method1();
*/

// Вид 2. Что-то ПРИНИМАЮТ, и ничего НЕ ВОЗВРАЩАЮТ
/*
void Method2(string msg)
{
	Console.WriteLine(msg);
}
Method2("Text mesage");
*/
/*
void Method21(string msg, int count)
{
	int i = 0;
	while (i < count)
	{
		Console.WriteLine(msg);
		i++;
	}
}
Method21("Text, any text", 5);
// или
Method21(msg: "Text, any text", count: 4);
// или
Method21(count: 3, msg: "Text, any text");
*/

// Вид 3. Ничего НЕ ПРИНИМАЮТ, и что-то ВОЗВРАЩАЮТ
/*
int Method3()
{
	return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Вид 4. Что-то ПРИНИМАЮТ, и что-то ВОЗВРАЩАЮТ
/*
string Method4(int count, string text)
{
	int i = 0;
	string result = String.Empty;
	while (i < count)
	{
		result = result + text;
		i++;
	}
	return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);
*/
//Или с циклом for
/*
string Method41(int count, string text)
{
	string result = String.Empty;
	for (int i = 0; i < count; i++)
	{
		result = result + text;
	}
	return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);
*/

//Таблица умножения
/*
for (int i = 2; i <= 10; i+)
{
	for (int j = 2; j <= 10; j++)
	{
		Console.WriteLine($"{i} x {j} = {i * j}");
	}
	Console.WriteLine();
}
*/

// Task1. 
//===== Работа с текстом

// Дан текст. В тексте нужно* все пробелы• заменить черточками,
// маленькие буквы "к" заменить большими "K"
// а большие "С" заменить маленькими "с"

// Ясна ли задача?
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
			+ "ежели бы вас послали вместо нашего милого Винценгероде, "
			+ "вы бы взяли приступом согласие прусского короля."
			+ "Вы так красноречивы. Вы дадите мне чаю?";
*/
// string s = "qwerty"
//			   012343
//обращение к строке:
// s[3] //  = r
/*
string Replace(string text, char oldValue, char newValue)
{
	string result = String.Empty;
	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if (text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/

// Task2.
// Функции в программировании
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

/*
void PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}


void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[minPosition]) minPosition = j;
		}
		int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
}
int[] arr = { 2, 5, 3, 7, 8, 2, 1, 1, 6 };

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/


// HomeWork

void PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}


void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int maxPosition = array.Length - 1;

		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] > array[maxPosition]) maxPosition = j;
		}

		int temporary = array[i];
		array[i] = array[maxPosition];
		array[maxPosition] = temporary;
	}
}
int[] arr = { 2, 5, 3, 7, 8, 2, 1, 1, 6 };

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);