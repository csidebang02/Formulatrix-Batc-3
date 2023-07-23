public class FooBarGenerator
{
    private Dictionary<int, string> rules;

    public FooBarGenerator()
    {
        rules = new Dictionary<int, string>();
    }

    public void AddCondition(int number, string keyword)
    {
        rules[number] = keyword;
    }

    public bool RemoveCondition(int number)
    {
        return rules.Remove(number);
    }

    public List<string> ListAllConditions()
    {
        List<string> conditionsList = new List<string>();
        foreach (var rule in rules)
        {
            conditionsList.Add($"{rule.Key} = {rule.Value}");
        }
        return conditionsList;
    }

    public string GenerateFooBar(int n)
    {
        string result = "";

        for (int i = 0; i <= n; i++)
        {
            string output = "";

            foreach (var rule in rules)
            {
                if (i % rule.Key == 0)
                    output += rule.Value;
            }

            if (string.IsNullOrEmpty(output))
                output = i.ToString();

            result += output + ", ";
        }
        return result.TrimEnd(',');
    }

    public string CheckSingleNumber(int number)
    {
        string keyword = "";
        foreach (var rule in rules)
        {
            if (number % rule.Key == 0)
            {
                keyword += rule.Value;
            }
        }

        return string.IsNullOrEmpty(keyword) ? number.ToString() : keyword;
    }
}
