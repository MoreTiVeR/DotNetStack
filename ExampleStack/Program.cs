using System;


namespace DotNetStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> mStack = new MyStack<string>(5);

            #region Create
            Console.WriteLine("----- Create Stack -----");
            mStack.Push("XRP");
            mStack.Push("DOGE");
            mStack.Push("BNB");
            mStack.Push("ADA");
            mStack.Push("KUB");

            Console.WriteLine($"Total element of stack --> {mStack.Count}");
            Console.WriteLine("Read stack..");
            int counter = 0;
            foreach (var ele in mStack)
            {
                counter++;
                Console.WriteLine($"{counter}-->{ele}");
            }

            Console.WriteLine($"Get thr top of stack without remove --> {mStack.Peek()}");
            Console.WriteLine($"Get the top of stack after removed --> {mStack.Pop()}");
            Console.WriteLine($"Current total element --> {mStack.Count}");
            #endregion

            #region Search
            Console.WriteLine("----- Search -----");
            Console.WriteLine($"Searching ETH in stack...the result is {(mStack.Contains("ETH") == true ? $"found." : $"not found.")}");
            Console.WriteLine($"Searching BNB in stack...the result is {(mStack.Contains("BNB") == true ? $"found." : $"not found.")}");
            Console.WriteLine($"Searching XRP in stack...the result is {(mStack.Contains("XRP") == true ? $"found." : $"not found.")}");
            Console.WriteLine($"Searching CAKE in stack...the result is {(mStack.Contains("CAKE") == true ? $"found." : $"not found.")}");
            #endregion

            #region Search with input
            //string searchIput = Console.ReadLine();
            //Console.WriteLine($"Searching ETH in stack...the result is {(mStack.Contains(searchIput) == true ? $"found {searchIput}." : $"{searchIput} is not found.")}");
            #endregion

            #region Clear Stack
            Console.WriteLine("----- Clear Stack -----");
            mStack.Clear();
            Console.WriteLine($"Totle element of stack after clear --> {mStack.Count}");
            #endregion

            Console.ReadLine();
        }

    }
}
