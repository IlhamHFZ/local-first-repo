namespace RepoLocalFirst;

public class Dog
{
	public string Name {get; private set;}
	public int Age {get; private set;}
	
	public Dog(string name, int age)
	{
		Name = name;
		Age = age;
	}
	
	public string SoundDog()
	{
		return $"nama ku {Name}";
	}
}
