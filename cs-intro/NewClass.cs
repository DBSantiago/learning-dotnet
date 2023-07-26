namespace cs_intro;

public class NewClass
{
    public string Name { get; set; }
    public int Number { get; set; }
    public int Id { get; private set; }

    public NewClass(string name, int number)
    {
        this.Name = name;
        this.Number = number;
        this.Id = 0;
    }
}