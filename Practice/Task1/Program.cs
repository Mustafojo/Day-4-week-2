var cal = new Calculator();
cal.FirstNum = 10;
cal.SecondNum = 20;
System.Console.WriteLine($"{cal.Sum()} {cal.Subtract()} {cal.Multiplication()} {cal.Division()}");



class Calculator
{
    public int  FirstNum;
    public int SecondNum;

    public int Program()
    {
        for (;;);
    }
    public string Sum()
    {
       return $"{FirstNum + SecondNum}";
    }
    public string Subtract()
    {
       return $"{FirstNum - SecondNum}";
    }
    public string Multiplication()
    {
       return $"{FirstNum * SecondNum}";
    }
    public string Division()
    {
       return $"{FirstNum / SecondNum}";
    }

    }

