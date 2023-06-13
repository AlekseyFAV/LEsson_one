int[] array = { 12, 12, 33, 54, 65, 76, 27, 54, 38 };

int n = array.Length;
int find = 54;
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