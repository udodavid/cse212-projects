public static class MysteryStack2
{
    private static bool IsFloat(string text)
    {
        return float.TryParse(text, out _);
    }

    public static float EvaluatePostfix(string text)
    {
        var stack = new Stack<float>();

        foreach (var item in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1: Not enough operands.");

                float op2 = stack.Pop();
                float op1 = stack.Pop();
                float res = item switch
                {
                    "+" => op1 + op2,
                    "-" => op1 - op2,
                    "*" => op1 * op2,
                    "/" => op2 == 0 ? throw new ApplicationException("Invalid Case 2: Division by zero.") : op1 / op2,
                    _ => throw new ApplicationException("Unknown operator.")
                };

                stack.Push(res);
            }
            else if (IsFloat(item))
            {
                stack.Push(float.Parse(item));
            }
            else
            {
                throw new ApplicationException("Invalid Case 3: Invalid token.");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4: Too many or too few operands.");

        return stack.Pop();

    }
    
    
}


