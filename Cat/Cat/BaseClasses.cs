using System;

/// <summary>
/// описание тика
/// </summary>
public class Tick
{
    private double value;
    public double Value
    {
        get { return value; }
        set { value = value; }
    }

    private double volume;
    public double Volume
    {
        get { return volume; }
        set { volume = value; }
    }

    private DateTime datetime;
    public DateTime DateTime
    {
        get { return datetime; }
        set { datetime = value; }
    }

    public Tick()
    {
    }
}

public class Bar
{
    private double open;
    public double Open
    {
        get { return open; }
        set { open = value; }
    }

    private double low;
    public double Low
    {
        get { return low; }
        set { low = value; }
    }

    private double high;
    public double High
    {
        get { return high; }
        set { high = value; }
    }

    private double close;
    public double Close
    {
        get { return close; }
        set { close = value; }
    }

    private double volume;

    public double Volume
    {
        get { return volume; }
        set { volume = value; }
    }


    private DateTime datetime;

    public DateTime DateTime
    {
        get { return datetime; }
        set { datetime = value; }
    }

    public Bar()
    {
    }
}