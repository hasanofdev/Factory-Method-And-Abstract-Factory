using System;

namespace FurnitureFactory;

#region Products
public abstract class Chair
{
    public abstract void HasLegs();
    public abstract void SitOn();
}

public class VictorianChair : Chair
{
    public override void HasLegs() => Console.WriteLine(true);
    public override void SitOn() => Console.WriteLine($"Sit on {this.GetType().Name}");
}

public class ModernChair : Chair
{
    public override void HasLegs() => Console.WriteLine(false);
    public override void SitOn() => Console.WriteLine($"Sit on {this.GetType().Name}");
}

public class ArtDecoChair : Chair
{
    public override void HasLegs() => Console.WriteLine(true);
    public override void SitOn() => Console.WriteLine($"Sit on {this.GetType().Name}");
}


public abstract class CoffeeTable
{
    public abstract void IsRound();
    public abstract void PlaceOn();

}

public class VictorianCoffeeTable : CoffeeTable
{
    public override void IsRound() => Console.WriteLine(false);
    public override void PlaceOn() => Console.WriteLine($"Placed on {this.GetType().Name}");
}

public class ModernCoffeeTable : CoffeeTable
{
    public override void IsRound() => Console.WriteLine(true);
    public override void PlaceOn() => Console.WriteLine($"Placed on {this.GetType().Name}");
}


public class ArtDecoCoffeeTable : CoffeeTable
{
    public override void IsRound() => Console.WriteLine(false);
    public override void PlaceOn() => Console.WriteLine($"Placed on {this.GetType().Name}");
}

public abstract class Sofa
{
    public abstract void HasLegs();
    public abstract void SitOn();
}

public class VictorianSofa : Sofa
{
    public override void HasLegs() => Console.WriteLine(true);
    public override void SitOn() => Console.WriteLine($"Sat on {this.GetType().Name}");

}

public class ModernSofa : Sofa
{
    public override void HasLegs() => Console.WriteLine(false);
    public override void SitOn() => Console.WriteLine($"Sat on {this.GetType().Name}");

}

public class ArtDecoSofa : Sofa
{
    public override void HasLegs() => Console.WriteLine(true);
    public override void SitOn() => Console.WriteLine($"Sat on {this.GetType().Name}");

}


#endregion


#region Creators
public abstract class FurnitureFactory
{
    public abstract Chair CreateChair();
    public abstract Sofa CreateSofa();
    public abstract CoffeeTable CreateCoffeeTable();
}

public class VictorianFurnitureFactory : FurnitureFactory
{
    public override Chair CreateChair() => new VictorianChair();

    public override CoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

    public override Sofa CreateSofa() => new VictorianSofa();
}

public class ModernFurnitureFactory : FurnitureFactory
{
    public override Chair CreateChair() => new ModernChair();

    public override CoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    public override Sofa CreateSofa() => new ModernSofa();
}

public class ArtDecoFurnitureFactory : FurnitureFactory
{
    public override Chair CreateChair() => new ArtDecoChair();

    public override CoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

    public override Sofa CreateSofa() => new ArtDecoSofa();
}

#endregion

public class Program
{
    static void Main()
    {
        FurnitureFactory factory = new VictorianFurnitureFactory();
        factory.CreateChair().SitOn();

        factory = new ModernFurnitureFactory();
        factory.CreateChair().SitOn();

        factory = new ArtDecoFurnitureFactory();
        factory.CreateChair().SitOn();
    }
}