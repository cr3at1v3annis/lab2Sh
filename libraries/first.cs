public class Pupil
{
    public void Read() => Reads();
    protected virtual void Reads()
    {
        Console.WriteLine("Pupil can read!");
    }
    public void Write() => Writes();
    protected virtual void Writes()
    {
        Console.WriteLine("Pupil can write!");
    }
    public void Study() => Studies();
    protected virtual void Studies()
    {
        Console.WriteLine("Pupil can study!");
    }
    public void Relax() => Relaxes();
    protected virtual void Relaxes()
    {
        Console.WriteLine("Pupil can relax!");
    }
}

public class ExcellentPupil: Pupil
{
    public void Read() => Reads();
    protected override void Reads()
    {
        Console.WriteLine("Pupil can read excellently!");
    }
    public void Write() => Writes();
    protected override void Writes()
    {
        Console.WriteLine("Pupil can write excellently!");
    }
    public void Study() => Studies();
    protected override void Studies()
    {
        Console.WriteLine("Pupil can study excellently!");
    }
    public void Relax() => Relaxes();
    protected override void Relaxes()
    {
        Console.WriteLine("Pupil can relax excellently!");
    }
}

public class GoodPupil: Pupil
{
    public void Read() => Reads();
    protected override void Reads()
    {
        Console.WriteLine("Pupil can read well!");
    }
    public void Write() => Writes();
    protected override void Writes()
    {
        Console.WriteLine("Pupil can write well!");
    }
    public void Study() => Studies();
    protected override void Studies()
    {
        Console.WriteLine("Pupil can study well!");
    }
    public void Relax() => Relaxes();
    protected override void Relaxes()
    {
        Console.WriteLine("Pupil can relax well!");
    }
}

public class BadPupil: Pupil
{
    public void Read() => Reads();
    protected override void Reads()
    {
        Console.WriteLine("Pupil can read badly!");
    }
    public void Write() => Writes();
    protected override void Writes()
    {
        Console.WriteLine("Pupil can write badly!");
    }
    public void Study() => Studies();
    protected override void Studies()
    {
        Console.WriteLine("Pupil can study badly!");
    }
    public void Relax() => Relaxes();
    protected override void Relaxes()
    {
        Console.WriteLine("Pupil can relax badly!");
    }
}

public class ClassRoom
{
    private Pupil[] pupils;
    private bool flag = true;
    public ClassRoom(Pupil a, Pupil b, Pupil c, Pupil d)
    {
        pupils = new Pupil[4] {a, b, c, d};
    }
    public ClassRoom(Pupil a, Pupil b, Pupil c)
    {
        pupils = new Pupil[3] {a, b, c};
        Console.WriteLine("Add new pupil!");
        flag = false;
    }

    public ClassRoom(Pupil a, Pupil b)
    {
        pupils = new Pupil[2] {a, b};
        Console.WriteLine("Add two pupils!");
        flag = false;
    }
    public void Print()
    {
        if (flag)
        {
            for (int i = 0; i < pupils.Length; ++i)
            {
                pupils[i].Read();
                pupils[i].Study();
                pupils[i].Write();
                pupils[i].Relax();
            }
        } else {
            Console.WriteLine("Fix the bug.");
        }
    }
}