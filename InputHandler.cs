using System;

public class InputHandler
{
    public Matrix CreateMatrix()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        Matrix matrix = new Matrix(rows, columns);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter value at [{i},{j}]: ");
                double value = double.Parse(Console.ReadLine());
                matrix.SetValue(i, j, value);
            }
        }

        return matrix;
    }

    public Vector CreateVector()
    {
        Console.Write("Enter vector size: ");
        int size = int.Parse(Console.ReadLine());

        Vector vector = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value at [{i}]: ");
            double value = double.Parse(Console.ReadLine());
            vector.SetValue(i, value);
        }

        return vector;
    }
}
