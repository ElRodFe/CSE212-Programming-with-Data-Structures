﻿public static class MysteryStack2
{
    private static bool IsFloat(string text)
    {
        return float.TryParse(text, out _);
    }

    public static float Run(string text)
    {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' '))
        {
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+")
                {
                    res = op1 + op2;
                }
                else if (item == "-")
                {
                    res = op1 - op2;
                }
                else if (item == "*")
                {
                    res = op1 * op2;
                }
                else
                {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item))
            {
                stack.Push(float.Parse(item));
            }
            else if (item == "")
            {
            }
            else
            {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}

// INPUTS = OUTPUTS
// 5 3 7 + *  = 50
// 6 2 + 5 3 - /  = 4

//Invalid case 1 = If there are not 2 numbers when an operator appears in the stack
//Invalid case 2 = If division by 0 occurs
//Invalid case 3 = input is not a number or operator
//Invalid case 4 = if there is not 1 number in the stack at the end (maybe two numbers like "2, 6" or)