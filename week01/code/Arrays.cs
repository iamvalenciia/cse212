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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create an empty array to store the multiples.
        double[] numbers = new double[length];

        // 2. Create a loop. For each integer index,
        // multiply 'number' by index to get the corresponding multiple. 
        for (int index = 1; index <= length; ++index)
        {
        double multiple = index * number;
        numbers[index -1] = multiple;
        Console.WriteLine(multiple);
        }

        // Step 3: Return the array of multiples
        Console.WriteLine(numbers);
        return numbers;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Calculate how many rotations are actually needed
        int rotations = amount % data.Count;

        // 2.  If no rotation is needed, return Nothing
        if (rotations == 0)
        {
            return;
        }

        // 3.  Use GetRange to split the list into two parts
        // The part to move to the front
        List<int> partToMove = data.GetRange(data.Count - rotations, rotations);

        // The remaining part of the list
        List<int> remainingPart = data.GetRange(0, data.Count - rotations);

        // 4. Clear the original list and add the parts back in the rotated order
        data.Clear();
        data.AddRange(partToMove); 
        data.AddRange(remainingPart); 


    }
}
