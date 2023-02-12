int[] array = {11, 25, 13, 44, 35, 13, 71, 28};
int n = array.Length;
int find = 13;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
};
