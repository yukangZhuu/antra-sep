namespace Assignment_03;

public class Color
{
    public int Red { get;  set; }
    public int Green { get;  set; }
    public int Blue { get;  set; }
    public int Alpha { get;  set; }

    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }
    
    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }

    public double GetGrayscale()
    {
        return (Red + Green + Blue) / 3.0;
    }
}