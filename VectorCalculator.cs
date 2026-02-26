public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator()
    {
        validator = new DimensionValidator();
    }

    public Vector Add(Vector v1, Vector v2)
    {
        if (!validator.ValidateVector(v1, v2))
        {
            System.Console.WriteLine("Vector dimensions do not match!");
            return null;
        }

        Vector result = new Vector(v1.GetSize());

        for (int i = 0; i < v1.GetSize(); i++)
        {
            double sum = v1.GetValue(i) + v2.GetValue(i);
            result.SetValue(i, sum);
        }

        return result;
    }
}
