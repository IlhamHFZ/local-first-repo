public class Dog
{
	public string Username {get; private set;}
	public int Weight {get; private set;}
	
	public Dog(string username, int weight)
	{
		Username = username;
		Weight = weight;
	}
	
	public string SoundDog()
	{
		return $"nama ku {Usernam}";
	}
}
