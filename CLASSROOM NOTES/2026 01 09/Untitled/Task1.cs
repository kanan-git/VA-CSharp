// TASK: array qebul etsin, sort edib qaytarsin
#region Sort_v1
// static int[] Sort(int[] array)
// {
//     int ArrayLength = array.Length;
//     int[] SortedArray = new int[ArrayLength];
//     while(true)
//     {
//         bool IsSorted = true;
//         for(int i=0; i<ArrayLength; i++)
//         {
//             if(i == ArrayLength-1)
//             {
//                 // continue;
//                 SortedArray[i] = array[i];
//                 break;
//             }
//             else
//             {
//                 if(array[i] > array[i+1])
//                 {
//                     IsSorted = false;
//                     int TempInt = array[i];
//                     array[i] = array[i+1];
//                     array[i+1] = TempInt;
//                     SortedArray[i] = array[i];
//                 }
//                 else
//                 {
//                     SortedArray[i] = array[i];
//                 };
//             };
//         };
//         if(IsSorted)
//         {
//             return SortedArray;
//         }
//         else
//         {
//             array = SortedArray;
//         };
//     };
// };
// int[] arr1 = {5, 99, 0, 3, 2, 6, 8, 7, 9, 100, 10, 4};
// int[] arr2 = Sort(arr1);
// Console.WriteLine("RESULT:\n----------------------");
// foreach(int element in arr2)
// {
//     Console.Write(element + ", ");
// };
#endregion

#region Sort_v2
static void Sort(int[] arr)
{
    for(int j=0; j<arr.Length; j++)
    {
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[j] < arr[i])
            {
                int number = arr[j];
                arr[j] = arr[i];
                arr[i] = number;
            };
        };
    };
    
    foreach(int number in arr)
    {
        Console.Write(number + " ");
    };
};
Sort(new int[] {5, 99, 0, 3, 2, 6, 8, 7, 9, 100, 10, 4});
#endregion
