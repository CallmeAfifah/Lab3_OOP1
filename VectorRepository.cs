using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors;

    public VectorRepository()
    {
        vectors = new List<Vector>();
    }

    public void Add(Vector vector)
    {
        vectors.Add(vector);
    }

    public Vector Get(int index)
    {
        return vectors[index];
    }
}
