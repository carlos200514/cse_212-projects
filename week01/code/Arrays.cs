// Felipe Rojas
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
        // PLAN
        // Step 1: Create a new array of type double with a size equal to the value of length.
        //         This array will hold the multiples that we calculate.
        // Step 2: Use a for loop that starts at index 0 and runs until index length - 1.
        //         Each loop iteration will calculate one multiple.
        // Step 3: For each position in the array, calculate the multiple of the starting number.
        //         The formula will be: number * (index + 1)
        //         We add 1 to the index because the first multiple should be the number itself.
        // Step 4: Store the calculated value into the array at the current index.
        // Step 5: After the loop finishes filling the array, return the array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // PLAN
        // Step 1: Determine the index where the list should be split.
        //         This index will be data.Count - amount.
        //         Everything after this index should move to the front of the list.
        // Step 2: Create a temporary list to store the elements that will move to the front.
        //         Use GetRange() to copy the elements starting at the split index
        //         and take 'amount' elements.
        // Step 3: Remove those elements from their original location in the list
        //         using RemoveRange().
        // Step 4: Insert the saved elements at the beginning of the list
        //         using InsertRange(0, tempList).
        // Step 5: The list is now rotated to the right and no return value is needed
        //         because the original list has been modified.

        int splitIndex = data.Count - amount;

        List<int> temp = data.GetRange(splitIndex, amount);

        data.RemoveRange(splitIndex, amount);

        data.InsertRange(0, temp);
    }
}
