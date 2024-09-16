using System;
using Newtonsoft.Json;

class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        // Create an instance of the Person class
        var person = new Person
        {
            Name = "Alice",
            Age = 30
        };

        // Serialize the Person object to a JSON string
        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);

        // Deserialize the JSON string back to a Person object
        var deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine("Deserialized Person:");
        Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
    }
}