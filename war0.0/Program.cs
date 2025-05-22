// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

internal class Program
{
    // Task: Two Sum
    /*
     Given an array of integers and a target sum, return the indices of the two numbers such that they add up to the target.

     ✍️ Signature:
        public static int[] TwoSum(int[] nums, int target)

     🔍 Example:
        Input: nums = [2, 7, 11, 15], target = 9
        Output: [0, 1]

        Input: nums = [3, 2, 4], target = 6
        Output: [1, 2]

        If no 2 matching numbers were found - return an empty int array.

     🧪 Your code will be tested automatically when you run the program.

        Add comments and explenations your your code!

        When you are done - screenshot the results and send it to your instructor, alongside the Program.cs file.

        No GPT or Copilot are allowed.
    */

    public static int[] TwoSum(int[] nums, int target)
    {
        int[] result_arr = new int[2];  //init arr for the result
        Dictionary<int,int> halp_dict = new Dictionary<int,int>(); // creting dictionary key: number, value: index
        for (int i = 0; i < nums.Length; i++)
        {
            // checking in o(1) if the target - nums[i] is in the dic 
            // that mean (target - nums[i]) was in the arr
            //if yes adding the indexes to the result arr and breaking the loop
            if(halp_dict.ContainsKey(target - nums[i])) 
            {
                result_arr[0] = halp_dict[target - nums[i]]; 
                result_arr[1] = i; 
                break;
            }
            else //else inserting to the dic the number and his index
            {
                halp_dict[nums[i]] = i; 
            }
        }
        return result_arr;
    }

    static void Main(string[] args)
    {
        int[] arr = {10, 20,40,88,1,2};

        int[] res = TwoSum(arr, 3);
        foreach (int i in res)
        {
            Console.WriteLine(i);
        }
    }
}

















// namespace War
// {
//     public class Program
//     {
//         // public static void Main(string[] args)
//         // {
//         //     Weapon w1 = new Weapon(3);
//         //     w1.shoot();
//         //     w1.shoot();
//         //     w1.shoot();
//         //     w1.shoot();
//         // }
//     }
// }