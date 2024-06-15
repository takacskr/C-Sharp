int[,,] array3D = new int[2, 2, 2] {
    {
        // first 2D slice
        { 1, 2 },
        { 3, 4 }
    },
    {
        // second 2D slice
        { 5, 6 },
        { 7, 8 }
    }
};

for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            System.Console.Write($"{array3D[i, j, k]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

/*
    Think of it like a cube of integers, where each dimension has a length.
    You can access an element in the array using three indices, like this: myArray[x, y, z]
    Referring to the values
    Console.WriteLine(array3D[0, 0, 0]); // Outputs: 1
    Console.WriteLine(array3D[0, 0, 1]); // Outputs: 2
    Console.WriteLine(array3D[0, 1, 0]); // Outputs: 3
    Console.WriteLine(array3D[0, 1, 1]); // Outputs: 4
    Console.WriteLine(array3D[1, 0, 0]); // Outputs: 5
    Console.WriteLine(array3D[1, 0, 1]); // Outputs: 6
    Console.WriteLine(array3D[1, 1, 0]); // Outputs: 7
    Console.WriteLine(array3D[1, 1, 1]); // Outputs: 8
*/