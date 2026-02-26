using System.Collections.Generic;

public class MatrixRepository
{
    private List<Matrix> matrices;

    public MatrixRepository()
    {
        matrices = new List<Matrix>();
    }

    public void Add(Matrix matrix)
    {
        matrices.Add(matrix);
    }

    public Matrix Get(int index)
    {
        return matrices[index];
    }
}
