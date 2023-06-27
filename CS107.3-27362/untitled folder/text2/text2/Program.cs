static void main(string[] args)
{
    int[] num = { 122, 45, 65, 56, 49, 326, 15, 45, 945, 153 };

    int smallest = num[0];
    int biggest = num[0];

    for (int i = 0; i < num.Length; i++)
    {
        if (smallest > num[i])
        {
            smallest = num[i];
        }
        if (biggest < num[i])
        {
            biggest = num[i];
        }
    }
    console.WriteLine("smallest" + smallest);
    console.WriteLine("biggest" + biggest);
}

