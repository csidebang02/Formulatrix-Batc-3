public class FooBarGenerator
{
    private Dictionary<int, string> rules;

    public FooBarGenerator(Dictionary<int, string> rules)
    {
        this.rules = rules;
    }

    public string GenerateFooBar(int n)
    {
        string result = "";

        for (int i = 0; i <= n; i++)
        {
            string output = CheckNumber(i);

            result += output + ", ";
        }

        return result.TrimEnd(',');
    }

    public string CheckNumber(int number)
    {
        if (rules.ContainsKey(number))
        {
            return rules[number];
        }
        else
        {
            return number.ToString();
        }
    }
}