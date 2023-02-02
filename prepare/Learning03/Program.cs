using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}

class Fraction()
{
    private int top;
    
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;

    }

    public Fraction(int wholeNumber)
    {
        top = wholeNumber;

        bottom = 1;
        

    }

    public Fraction(int topNum, int bottomNum)
    {
        top = topNum;

        bottom = bottomNum;
    }

    public GetFractionString()
    {
       string text = $'{top}/{bottom}';
       
       return text;

    }

    public GetDecimalValue()
    {
        return (double)top / (double)bottom;

    }
    


}