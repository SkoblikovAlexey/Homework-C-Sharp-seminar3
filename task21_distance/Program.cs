// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int[3];
int[] B = new int[3];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

double calculation(int[] dot1, int[] dot2)
{
    double distance = Math.Sqrt(Math.Pow(dot1[0] - dot2[0], 2) +
                   Math.Pow(dot1[1] - dot2[1], 2) + Math.Pow(dot1[2] - dot2[2], 2));
    return distance;
}

Console.WriteLine("Введите три координаты(x, y, z) точки А");
FillArray(A);
Console.WriteLine();
Console.WriteLine("Введите три координаты(x, y, z) точки В");
FillArray(B);
Console.WriteLine();

Console.WriteLine(calculation(A, B));