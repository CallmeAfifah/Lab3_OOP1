public class Matrix
{
    private Row[] rows;
    private int rowCount;
    private int columnCount;

    public Matrix(int rowCount, int columnCount)
    {
        this.rowCount = rowCount;
        this.columnCount = columnCount;

        rows = new Row[rowCount];

        for (int i = 0; i < rowCount; i++)
        {
            rows[i] = new Row(columnCount);
        }
    }

    public void SetValue(int row, int column, double value)
    {
        rows[row].SetValue(column, value);
    }

    public double GetValue(int row, int column)
    {
        return rows[row].GetValue(column);
    }

    public int GetRowCount()
    {
        return rowCount;
    }

    public int GetColumnCount()
    {
        return columnCount;
    }
}
