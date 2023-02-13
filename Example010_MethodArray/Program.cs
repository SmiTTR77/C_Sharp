int[] array = { 10, 20, 3, 5, 6, 77, 9, 546, 3, 42, 2, 45 };
int n = array.Length;
int find = 3;

int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}
