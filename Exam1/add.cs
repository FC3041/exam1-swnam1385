namespace Exam1;


public class Q1_Add
{
    public static int Add(int a , int b)
    {
        return a + b;
    }
}


public class Q4Person
{
    public string Name{ get; set; }
    public int Age{ get; set; }
    public Q4Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

//public class Type1
//{
//    public int Count { get; set; }
//}
//
//public class Type2
//{
//    public int Count { get; set; }
//}


public static class Basics
{
    public static void Q2MultiplyAndReset(ref int v, ref int f)
    {
        v *= f;
        f = 1;
    }
}


public static class BExpn
{
    public static void Q5TryCatchFinally(bool shouldThrow, List<string> log)
    {
        try
        {
            log.Add("Try");
            if (shouldThrow)
            {
                throw new Exception("An error occurred.");
            }

            log.Add("AfterTry");
        }
        catch
        {
            log.Add("Catch");
        }
        finally
        {
            log.Add("Finally");
        }
    }
}

public interface IShape
{
    double GetArea();
    double GetPerimeter();
}
public class Q7Circle:IShape
{
    public double Radius { get; set;}

    public Q7Circle(double radius)
    {
        Radius = radius;}
    public double GetArea(){
        return Math.PI * Radius * Radius;}
    public double GetPerimeter()
    {
        return 2*Math.PI * Radius;
    }
}

public class Q7Rectangle:IShape
{
    public double Width { get; set;}
    public double Height { get; set;}

    public Q7Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public double GetArea()
    {
        return Width *Height;
    }

    public double GetPerimeter()
    {
        return 2*(Width + Height);
    }
}

public static class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double totalArea = 0.0;

        foreach (var shape in shapes)
        {
            totalArea += shape.GetArea();
        }

        return totalArea;
    }
}

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {

        if (x == null && y == null)
        {
            return 0;
        }
        if (x == null)
        {
            return -1;
        } 
        if (y == null)
        {
            return 1;
        } 
        if (x.Length < y.Length)
        {
            return -1;
        }
        if (x.Length > y.Length)
        {
            return 1;
        }
        return string.Compare(x, y, StringComparison.Ordinal);
    }
}


public class Q8ComparableString
{
    public string Value { get; set;}

    public Q8ComparableString(string value)
    {
        Value = value;
    }


    public static bool operator <(Q8ComparableString left, Q8ComparableString right)
    {
        return Compare(left, right) < 0;
    }

    public static bool operator >(Q8ComparableString left, Q8ComparableString right)
    {
        return Compare(left, right) > 0;
    }

    public static bool operator ==(Q8ComparableString left, Q8ComparableString right)
    {
        return Compare(left, right) == 0;
    }

    public static bool operator !=(Q8ComparableString left, Q8ComparableString right)
    {
        return Compare(left, right) != 0;
    }

    private static int Compare(Q8ComparableString left, Q8ComparableString right)
    {
        if (left?.Value == null && right?.Value == null) 
        return 0;
        if (left?.Value == null) 
        return -1;
        if (right?.Value == null) 
        return 1;
        if (left.Value.Length != right.Value.Length)
        {
            return left.Value.Length.CompareTo(right.Value.Length);
        }

        return string.Compare(left.Value, right.Value, StringComparison.Ordinal);
    }
    public override bool Equals(object obj)
    {
  return obj is Q8ComparableString other && this == other;
    }

    public override int GetHashCode()
    {return Value?.GetHashCode() ?? 0;}
}
