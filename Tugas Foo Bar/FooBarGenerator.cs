public class FooBarGenerator
{
private Dictionary<int, string> rules;

public FooBarGenerator(Dictionary <int, string> rules)
{
	this.rules = rules;
}

public string GenerateFooBar(int n)
{
	string result = "";

	for (int i = 0; i <= n; i++)
	{
		string output = "";

		foreach (KeyValuePair<int, string> rule in rules)
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
public string CheckNumber(int number)
    {
        string keyword = "";
        foreach (KeyValuePair<int, string> rule in rules)
        {
            if (number % rule.Key == 0)
            {
                keyword += rule.Value;
            }
        }

        return string.IsNullOrEmpty(keyword) ? number.ToString() : keyword;
    }
}