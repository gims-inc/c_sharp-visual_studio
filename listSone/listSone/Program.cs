using System;
using System.Collections;
using System.Collections.Generic;

namespace listSone
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("List<T> demo");
            // creating an instance which accepts strings
            List<string> foods = new List<string>();
            // adding some items one by one with Add()
            foods.Add("bread");
            foods.Add("butter");
            foods.Add("chocolate");
            // adding a simple string array with AddRange()
            string[] subList1 = {"orange", "apple", "strawberry", "grapes","kiwi", "banana"};
            foods.AddRange(subList1);
            // adding another List<string> with AddRange()
            List<string> anotherFoodList = new List<string>();
            anotherFoodList.Add("yoghurt");
            anotherFoodList.Add("tomato");
            anotherFoodList.Add("roast beef");
            anotherFoodList.Add("vanilla cake");
            foods.AddRange(anotherFoodList);
            // removing "orange" with Remove()
            foods.Remove("orange");
            // removing the 5th (index = 4) item ("strawberry") with RemoveAt()
            foods.RemoveAt(4);
            // removing a range (4-7: all fruits) with RemoveRange(int index,int count)

            foods.RemoveRange(3, 4);
            // sorting the list
            foods.Sort();
            // printing the sorted foods
            foreach (string item in foods)
            {
                Console.Write("| " + item + " ");
            }
            Console.WriteLine("|");
            // removing all items from foods
            foods.Clear();
            // printing the current item count in foods
            Console.WriteLine("The list now has {0} items.", foods.Count);
        }
    }




}
