public class Rectangle
{
    private int length;
    private int width;
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public int Perimeter()
    {
        return 2 * (length + width);
    }
    public int Area()
    {
        return length * width;
    }


}