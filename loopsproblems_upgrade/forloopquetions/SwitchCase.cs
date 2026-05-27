using System;

public class SwitchCase
{
    public enum color
    {
        red,
        green,
        blue
    }

    public void switchCase()
    {
        color c = color.blue;

        switch (c)
        {
            case color.red:
                Console.WriteLine(color.red);
                break;

            case color.green:
                Console.WriteLine(color.green);
                break;

            case color.blue:
                Console.WriteLine(color.blue);
                break;
        }
        }
    }
