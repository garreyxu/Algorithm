using System;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            CombinationSum3 cs = new CombinationSum3();

            var result = cs.GetCombinationSum3(3, 9);
            
            
            foreach (var items in result)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("-------------------------------------------------");
            }
            Console.ReadLine();
        }
        
    }
}
