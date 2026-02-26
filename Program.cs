using System;

class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();

        MatrixRepository matrixRepo = new MatrixRepository();
        VectorRepository vectorRepo = new VectorRepository();

        Console.WriteLine("Matrix 1:");
        Matrix m1 = inputHandler.CreateMatrix();
        matrixRepo.Add(m1);

        Console.WriteLine("Matrix 2:");
        Matrix m2 = inputHandler.CreateMatrix();
        matrixRepo.Add(m2);

        MatrixCalculator matrixCalculator = new MatrixCalculator();
        Matrix matrixResult = matrixCalculator.Add(m1, m2);

        Console.WriteLine("\nMatrix Addition Result:");
        DisplayMatrix(matrixResult);

        Console.WriteLine("\nVector 1:");
        Vector v1 = inputHandler.CreateVector();
        vectorRepo.Add(v1);

        Console.WriteLine("Vector 2:");
        Vector v2 = inputHandler.CreateVector();
        vectorRepo.Add(v2);

        VectorCalculator vectorCalculator = new VectorCalculator();
        Vector vectorResult = vectorCalculator.Add(v1, v2);

        Console.WriteLine("\nVector Addition Result:");
        DisplayVector(vectorResult);

        Console.ReadLine();
    }

    static void DisplayMatrix(Matrix matrix)
    {
        if (matrix == null) return;

        for (int i = 0; i < matrix.GetRowCount(); i++)
        {
            for (int j = 0; j < matrix.GetColumnCount(); j++)
            {
                Console.Write(matrix.GetValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static void DisplayVector(Vector vector)
    {
        if (vector == null) return;

        for (int i = 0; i < vector.GetSize(); i++)
        {
            Console.Write(vector.GetValue(i) + " ");
        }
        Console.WriteLine();
    }
}
