using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            bool run = true;
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            Console.WriteLine("\nThe count is now: {0}" , theList.Count);
            Console.WriteLine("\nThe capacity is now: {0}" + theList.Capacity);
            bool loopCase = true;
            while (loopCase)
            {
                Console.Clear();
                Console.WriteLine("Write +string to add to list and -string to remove");
                Console.WriteLine("Write e to return to the main menu");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        foreach (string element in theList)
                        {
                            Console.WriteLine("New element: " + element + "was added to the List\n");
                        }
                        
                        break;     
                   
                
                                             
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine("The element: " + theList + "was removed from the List");
                        break;
                    case 'e':
                        loopCase = false;
                        Console.WriteLine("You riched the main menu");
                        break;
                    default:
                        Console.WriteLine("Only use +  to add or - to remove from list or e to return to the main menu");
                        break;
                }
            } 
    }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> TestOueue = new Queue<string>();
            bool loopCase = true;
            while (loopCase)
            {
                
                Console.WriteLine("There is " + TestOueue.Count + " items in que");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {

                    case '+':
                        TestOueue.Enqueue(value);
                        Console.WriteLine("Next in que is: " + TestOueue.Peek());
                        break;
                    case '-':
                        TestOueue.Dequeue();
                        Console.WriteLine("Next in que is: " + TestOueue.Peek());
                        break;
                    default:
                        loopCase = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            /*Stack<string> ReverseText = new Stack<string>();
            bool loopCase = true;
            while (loopCase)
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {

                    case '+':
                        ReverseText.Push(value);
                        Console.WriteLine("The next value to pop is: " + ReverseText.Peek());
                        break;
                    case '-':
                        ReverseText.Pop();
                        Console.WriteLine("The next value to pop is: " + ReverseText.Peek());
                        break;
                    case '0':
                        loopCase = false;
                        break;
                    default:
                        loopCase = false;
                        break;
                }
            }
        }*/
            Stack<string> testStack = new Stack<string>();
            do
            {
                Console.WriteLine("\n Press 1 to Push," +
             "\n Press 2 to Pop,\n Press 3 to Reverse a String\n press 0 to quit ");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                if (input == '0')
                {
                    break;
                }

                switch (input)
                {
                    case '1':
                        Console.WriteLine("Please provide input:");
                        string name = Console.ReadLine();
                        testStack.Push(name);
                        foreach (var item in testStack)
                        {
                            Console.WriteLine("Names in the stack are " + item);
                        }
                        Console.WriteLine("Count in the stack: " + testStack.Count);
                        break;
                    case '2':
                        if (testStack.Count > 0)
                        {
                            Console.WriteLine("Implementing Last In First Out");
                            Console.WriteLine("Name removed from the stack is " + testStack.Pop());
                            foreach (var item in testStack)
                            {
                                Console.WriteLine("Names in the stack are " + item);
                            }
                            Console.WriteLine("Count in the stack :" + testStack.Count);
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty,name cannot be deleted");
                        }
                        break;
                    case '3':
                        Console.WriteLine("Enter some input value");
                        string inputString = Console.ReadLine();
                        Stack<string> inputStack = new Stack<string>();
                        for (int i = 0; i < inputString.Length; i++)
                            inputStack.Push(inputString.Substring(i, 1));
                        string resultstring = string.Empty;
                        for (int i = 0; i < inputString.Length; i++)
                            resultstring += inputStack.Pop();
                        Console.WriteLine("Reversed string is " + resultstring);
                        break;


                }


            } while (true);
            Console.Clear();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
            Console.WriteLine("Please enter some input");
            string input = Console.ReadLine();

            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
            { '<', '>' }
                      };

            Stack<char> brackets = new Stack<char>();
            //string result;
            try
            {
                // Iterate through each character in the input string
                foreach (char c in input)
                {
                    // check if the character is one of the 'opening' brackets
                    if (bracketPairs.Keys.Contains(c))
                    {
                        // if yes, push to stack
                        brackets.Push(c);
                    }
                    else {
                        // check if the character is one of the 'closing' brackets
                        if (bracketPairs.Values.Contains(c))
                        {
                            // check if the closing bracket matches the 'latest' 'opening' bracket
                            if (c == bracketPairs[brackets.First()])
                            {
                                brackets.Pop();
                            }
                            else
                            {
                                brackets.Push('c');
                                // if not, its an unbalanced string
                                //  Console.WriteLine("Its an unbalanced string");
                            }
                        }
                        else
                            // continue looking
                            continue;
                    }

                }

            }
            catch
            {
                // an exception will be caught in case a closing bracket is found, 
                // before any opening bracket.
                // that implies, the string is not balanced.

                //  Console.WriteLine("Closing bracket is found first");
                brackets.Push('c');


            }

            // Ensure all brackets are closed

            if (brackets.Count() == 0)
            {

                Console.WriteLine("String is Balanced");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("String is not Balanced");
                Console.ReadLine();

            }
            Console.Clear();
        }




    }


}
