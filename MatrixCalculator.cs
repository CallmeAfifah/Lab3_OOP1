public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator()
    {
        validator = new DimensionValidator();
    }

    public Matrix Add(Matrix m1, Matrix m2)
    {
        if (!validator.ValidateMatrix(m1, m2))
        {
            System.Console.WriteLine("Matrix dimensions do not match!");
            return null;
        }

        Matrix result = new Matrix(m1.GetRowCount(), m1.GetColumnCount());

        for (int i = 0; i < m1.GetRowCount(); i++)
        {
            for (int j = 0; j < m1.GetColumnCount(); j++)
            {
                double sum = m1.GetValue(i, j) + m2.GetValue(i, j);
                result.SetValue(i, j, sum);
            }
        }

        return result;
    }
}
