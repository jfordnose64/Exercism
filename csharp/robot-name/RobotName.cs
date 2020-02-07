using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private static List<string> robotNames = new List<string>();

    public Robot()
    {
        this.Name = GenerateName();
    }

    public string Name { get; set; }

    public void Reset()
    {
        System.Console.WriteLine("I am getting reset; Beep boop.");
        robotNames.Remove(Name);
        Name = GenerateName();
    }

    private string GenerateName() {
        var sb = new StringBuilder();
        var rnd = new Random();

        do {
            sb.Clear();

            // first two uppercase letters (ASCII)
            sb.Append(Convert.ToChar(rnd.Next(65, 91)));
            sb.Append(Convert.ToChar(rnd.Next(65, 91)));

            string rng = rnd.Next(0, 1000).ToString("D3");

            sb.Append(rng);
            Console.WriteLine(sb.ToString());
        } while (robotNames.Contains(sb.ToString()) == true);

        robotNames.Add(sb.ToString());

        return sb.ToString();
    }
}