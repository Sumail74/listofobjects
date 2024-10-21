using System;
using System.Collections.Generic;
public class GameObject
{
    public string Name { get; set; }
    public int Health { get; set; }

    public GameObject(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Health: {Health}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold GameObjects
        List<GameObject> gameObjects = new List<GameObject>();

        // Create instances of GameObject and add them to the list
        gameObjects.Add(new GameObject("Hunter", 100));
        gameObjects.Add(new GameObject("Lion", 90));
        gameObjects.Add(new GameObject("Deer", 60));
        gameObjects.Add(new GameObject("Cheetah" , 80 ));
        gameObjects.Add(new GameObject("Snake", 60));

        // Display the contents of the list
        foreach (var obj in gameObjects)
        {
            Console.WriteLine(obj);
        }
    }
}
