
// Soyut bir sınıf olan Animal
using Cs_Basics;

abstract class Animal
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    // Soyut bir metot
    public abstract void MakeSound();

    public string GetName()
    {
        return name;
    }
}

// Köpek sınıfı, Animal sınıfından kalıtım alır
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    // Animal sınıfından miras alınan metodu ezme (Method Overriding)
    public override void MakeSound()
    {
        Console.WriteLine(GetName() + " havlıyor");
    }
}

// Kedi sınıfı, Animal sınıfından kalıtım alır
class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    // Animal sınıfından miras alınan metodu ezme (Method Overriding)
    public override void MakeSound()
    {
        Console.WriteLine(GetName() + " miyavlıyor");
    }
}

// Bir interface tanımlama
interface ISwimmer
{
    void Swim();
}

// Koyun sınıfı, Animal sınıfından kalıtım alır ve ISwimmer arabirimini uygular
class Sheep : Animal, ISwimmer
{
    public Sheep(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine(GetName() + " beeee diyor");
    }

    public void Swim()
    {
        Console.WriteLine(GetName() + " yüzmeye başlıyor");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("Karabas");
        Animal cat = new Cat("Whiskers");
        Animal sheep = new Sheep("Dolly");

        dog.MakeSound(); // Polimorfizm
        cat.MakeSound(); // Polimorfizm
        sheep.MakeSound(); // Polimorfizm

        if (sheep is ISwimmer)
        {
            ((ISwimmer)sheep).Swim(); // Arabirim kullanımı
        }

        char[] array = sheep.GetName().ToCharArray();
        foreach (char character in array)
        {
            Console.WriteLine(character);
        }

        // Sayısı belli liste
        List<string> list = new List<string> { "Muz", "Portakal" };
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        // Array List sayısı değişir
        List<string> arrayList = new List<string>();
        arrayList.Add("Elma");
        arrayList.Add("Armut");
        arrayList.Add("Limon");
        foreach (string item in arrayList)
        {
            Console.WriteLine(item);
        }

        string DateDiff = TimeDifference.StringChallenge("12:30am-12:00pm");
        Console.WriteLine(DateDiff);
    }

}