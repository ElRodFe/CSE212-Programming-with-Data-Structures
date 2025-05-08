public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //Create a new array for holding all multiples
        var array = new double[length];

        //Loop: while "i" is not equal to the length of the array will keep looping
        for (int i = 0; i < length; i++)
        {
            //Multiply the given number by "i" (at first i=1, the second time i=2 and so on)
            var multiple = number * i;

            //Add the resulting multiple to the array
            array[i] = multiple;
        }

        return array;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //Get the length of the list
        int count = data.Count;

        //Get the required amount of data from the list
        var end = data.GetRange(count - amount, amount);

        //Remove those required nombers from the end list
        data.RemoveRange(count - amount, amount);

        //Add those removed numbers to the begining of the list
        data.InsertRange(0, end);
    }
}
