﻿using System;

namespace Array_Based_Stack_Class_Library
{
  // This Class handles the logic of the application. Each method either performs an operation but do not display results. It is the View Model.cs which handles the View or the Display of each Menu available in the Program.cs of the Application
  public class MyCustomStack
  {
    // I made this a static int to avoid the error in line 12 which says "A field initializer cannot reference the non-static field, method, or property 'CustomStack.maxStackCount' [Array Based Stack Class Library]". I also passed a value of 1000 so I could have a default number of item containers in the array. 
    static int maxStackCount = 1000;
    // I have initially set the value of the top of the stack to -1 so that the minimum index will be zero in the first execution of the Push method.
    int topOfTheStack = -1;
    // Initializing the array.
    string[] stackArray = new string[maxStackCount];

    // Call the Push method to add a data on top of the stack
    public void Push(string data)
    {
      if (topOfTheStack >= maxStackCount)
      {
        Console.WriteLine("The stack exceeded the maximum item count.");
      }
      else
      {
        stackArray[++topOfTheStack] = data;
        Console.WriteLine($"You have added {stackArray[topOfTheStack]}'s notebook.");
      }
    }

    // Call the PrintAll method to print all the items in the Stack
    public void PrintAll()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty.");
      }
      else
      {
        Console.WriteLine("Here are the remaining notebooks in the stack:");
        for (int index = topOfTheStack; index >= 0; index--)
        {
          Console.WriteLine($"{index + 1} = {stackArray[index]}");
        }
      }
    }

    // Call the Pop method to delete the current top item of the stack.
    public void Pop()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // Stack underflow
      }
      else
      {
        Console.WriteLine($"{stackArray[topOfTheStack]}'s notebook is removed from the stack.");
        topOfTheStack--;
      }
    }

    // Call the Peek method to print the current item on top of the stack.
    public void Peek()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // Stack underflow
      }
      else
      {
        Console.WriteLine($"{stackArray[topOfTheStack]}'s notebook is on top of the stack.");
      }
    }

    public void PeekAndPop()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // Stack underflow
      }
      else
      {
        Console.WriteLine($"{stackArray[topOfTheStack]}'s notebook is being checked.");
        this.Pop();
        this.PrintAll();
      }
    }

    public void ClearStack()
    {
      topOfTheStack = -1;
      Console.WriteLine("You have emptied the stack.");
    }
  }
}
