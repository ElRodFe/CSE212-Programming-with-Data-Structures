public static class ComplexStack
{

    // Input: (a == 3 or (b == 5 and c == 6)) = True - Braces have a match

    //Input: (students]i].Grade > 80 and students[i].Grade < 90) = False - 2 missing square Brackets

    //Input:(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing)) = False - 1 missing curly bracket
    public static bool DoSomethingComplicated(string line)
    {
        var stack = new Stack<char>();
        foreach (var item in line)
        {
            if (item is '(' or '[' or '{')
            {
                stack.Push(item);
            }
            else if (item is ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}