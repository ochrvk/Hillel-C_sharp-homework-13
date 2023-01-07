class Furniture
{
    internal Furniture()
    {
        id = Guid.NewGuid();
        name = "";
        type = "";
        material = "";
    }

    protected Guid id;
    internal string name;
    private string type;
    private int price;

    protected string material;
    protected int legs;

    internal string Type
    {
        get { return type; }
        set
        {
            if (value == "chair" || value == "sofa")
            {
                type = value;
            }
            else
            {
                throw new Exception("wrong value!");
            }
        }
    }

    internal int Price
    {
        get { return price; }
        set
        {
            if (value > 500 && value < 2000)
            {
                price = value;
            }
            else
            {
                throw new Exception("wrong price!");
            }
        }
    }

    public void ShowMyID()
    {
        Console.WriteLine($"Your furniture id is: {id}");
    }

    public override string ToString()
    {
        return $"Name: {name}\nType: {type}\nPrice: {price}";
    }
}

class Chair : Furniture
{
    public Chair()
    {
        base.Type = "chair";
        material = "";
    }

    private int weight;

    internal new string Type
    {
        get { return base.Type; }
    }

    public string Material
    {
        get { return material; }
        set
        {
            if (value == "wood" || value == "iron")
            {
                material = value;
            }
            else
            {
                throw new Exception("Wrong material!");
            }
        }
    }

    public int Legs
    {
        get { return legs; }
        set
        {
            if (value >= 2 && value <= 6)
            {
                legs = value;
            }
            else
            {
                throw new Exception("Worng value");
            }
        }
    }

    public int Weight
    {
        get { return weight; }
        set
        {
            if (value > 10 && value < 100)
            {
                weight = value;
            }
            else
            {
                throw new Exception("wrong weight");
            }
        }
    }

    public new void ShowMyID()
    {
        Console.WriteLine($"Your chair id is {id}");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nWeight: {weight}\nMaterial: {material}\n" +
            $"Table leg: {legs}";
    }
}

class Sofa : Furniture
{
    public Sofa()
    {
        base.Type = "sofa";
        material = "";
    }

    private int varanty;

    internal new string Type
    {
        get { return base.Type; }
    }

    public int Legs
    {
        get { return legs; }
        set
        {
            if (value >= 4 && value <= 6)
            {
                legs = value;
            }
            else
            {
                throw new Exception("wrong value!");
            }
        }
    }

    public string Material
    {
        get { return material; }
        set
        {
            if (value == "leather" || value == "leatherette")
            {
                material = value;
            }
            else
            {
                throw new Exception("wrong material!");
            }
        }
    }

    public int Varanty
    {
        get { return varanty; }
        set
        {
            if (value > 1 && value < 18)
            {
                varanty = value;
            }
            else
            {
                throw new Exception("Wrong value!");
            }
        }
    }

    public new void ShowMyID()
    {
        Console.WriteLine($"Your sofa id is {id}");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nLegs count: {legs}\nMaterial: {material}" +
            $"\nVaranty: {varanty}";
    }
}


class Techics
{
    public Techics()
    {
        id = Guid.NewGuid();
        name = "";
        type = "";
    }

    protected Guid id;
    internal string name;
    private string type;
    private int price;

    public string Type
    {
        get { return type; }
        set
        {
            if (value == "laptop" || value == "headphones")
            {
                type = value;
            }
            else
            {
                throw new Exception("wrong type!");
            }
        }
    }

    public int Price
    {
        get { return price; }
        set
        {
            if (value > 0 && value < 2000)
            {
                price = value;
            }
            else
            {
                throw new Exception("wrong value!");
            }
        }
    }

    public void ShowMyID()
    {
        Console.WriteLine($"Your technics id is: {id}");
    }

    public override string ToString()
    {
        return $"Name: {name}\nType: {type}\nPrice: {price}";
    }
}

class Laptop : Techics
{
    public Laptop()
    {
        base.Type = "laptop";
    }

    private int ramAmount;

    private int year;

    public string Windows
    {
        get
        {
            if (year > 2017)
            {
                return "win11";
            }
            else
            {
                return "win7/8/10";
            }
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value > 2004 && value < 2022)
            {
                year = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public int RamAmount
    {
        get { return ramAmount; }
        set
        {
            //there no laptops with RAM less than 4 and higher than 128 in my imaginary store
            if (value > 4 && value < 128)
            {
                ramAmount = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public new void ShowMyID()
    {
        Console.WriteLine($"Your laptop id is: {id}");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nRAM: {ramAmount}\nYear: {year}\nWindows: {Windows}";
    }
}

class Headphones : Techics
{
    public Headphones()
    {
        base.Type = "headphones";
        connectionType = "";
    }

    private string connectionType;
    private int cableLengh;

    public bool BuiltInSoundCard
    {
        get
        {
            if (connectionType == "usb")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public string ConnectionType
    {
        get { return connectionType; }
        set
        {
            if (value == "usb" || value == "mini jack")
            {
                connectionType = value;
            }
            else
            {
                throw new Exception("Incorrect type!");
            }
        }
    }

    public int CableLengh
    {
        get { return cableLengh; }
        set
        {
            if (value > 0 && value < 3)
            {
                cableLengh = 3;
            }
            else
            {
                throw new Exception("Incorrect length");
            }
        }

    }

    public new void ShowMyID()
    {
        Console.WriteLine($"Your headphones id is: {id}");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nConnection type: {connectionType}\n" +
            $"Cable lengh: {cableLengh}\nBuilt in sound card: {BuiltInSoundCard}";
    }
}


class Program
{
    static void FillChair(Chair chair)
    {
        Console.Write("Please type chair model name: ");
        chair.name = Console.ReadLine();

        Console.Write("Please enter material type: ");
        while (true)
        {
            try
            {
                chair.Material = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                chair.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type weight: ");
        while (true)
        {
            try
            {
                chair.Weight = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type chair-legs count: ");
        while (true)
        {
            try
            {
                chair.Legs = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void FillSofa(Sofa sofa)
    {
        Console.Write("Please type sofa model name: ");
        sofa.name = Console.ReadLine();

        Console.Write("Please enter material type: ");
        while (true)
        {
            try
            {
                sofa.Material = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                sofa.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type varanty: ");
        while (true)
        {
            try
            {
                sofa.Varanty = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type sofa-legs count: ");
        while (true)
        {
            try
            {
                sofa.Legs = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void FillLaptop(Laptop laptop)
    {
        Console.Write("Please type model name: ");
        laptop.name = Console.ReadLine();

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                laptop.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type RAM amount: ");
        while (true)
        {
            try
            {
                laptop.RamAmount = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type year of production: ");
        while (true)
        {
            try
            {
                laptop.Year = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void FillHeadphones(Headphones headphones)
    {
        Console.Write("Please type model name: ");
        headphones.name = Console.ReadLine();

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                headphones.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type connection type: ");
        while (true)
        {
            try
            {
                headphones.ConnectionType = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type cable lenght: ");
        while (true)
        {
            try
            {
                headphones.CableLengh = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void Main(string[] args)
    {
        //Input start
        Console.ForegroundColor = ConsoleColor.Blue;

        Laptop laptop = new Laptop();
        FillLaptop(laptop);
        Console.Clear();

        Headphones headphones = new Headphones();
        FillHeadphones(headphones);
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;

        Chair chair = new Chair();
        FillChair(chair);
        Console.Clear();

        Sofa sofa = new Sofa();
        FillSofa(sofa);
        Console.Clear();
        //Input end

        //Output start
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(laptop.ToString());
        laptop.ShowMyID();

        Console.WriteLine();

        Console.WriteLine(headphones.ToString());
        headphones.ShowMyID();

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine(chair.ToString());
        chair.ShowMyID();

        Console.WriteLine();

        Console.WriteLine(sofa.ToString());
        sofa.ShowMyID();
        //Output end
    }
}
