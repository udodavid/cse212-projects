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

        // PLAN:
        // 1. Create a new array of doubles with size = length.
        // 2. Use a for loop to fill the array.
        // 3. For each index i from 0 to length-1:
        //      - Set array[i] = number * (i + 1)
        // 4. Return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); // Multiply number by index+1 to get the i-th multiple
        }

        return []; // replace this return statement with your own
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

        // PLAN:
        // 1. Determine the part to move to the front: the last 'amount' elements.
        //    - Use GetRange(startIndex, count) to get this slice.
        //    - startIndex = data.Count - amount
        // 2. Determine the part to remain after the moved part: the first 'data.Count - amount' elements.
        // 3. Clear the original list (or reassign in the correct order using Clear + AddRange).
        // 4. Add the moved part first, then the remaining part.
        // 5. The original list is modified in-place as required.

        int count = data.Count;
        if (count == 0 || amount == 0 || amount == count)
            return; // No rotation needed

        List<int> endSlice = data.GetRange(count - amount, amount);
        List<int> startSlice = data.GetRange(0, count - amount);

        data.Clear(); // Clear original list

        data.AddRange(endSlice);   // Add rotated last part first
        data.AddRange(startSlice); // Then add the original first part
    }
}
