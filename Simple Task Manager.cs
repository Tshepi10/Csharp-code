using System;

class TaskManager
{
    static string[] tasks = new string[100];

    static int taskCount = 0;

    static void Main()
    {
    Console.WriteLine("Simple Task Manager");

while(true)
    { 
    Console.WriteLine("\n1. Add Task");
    Console.WriteLine("2. Mark Task as Completed");
    Console.WriteLine("3. View Tasks");
    Console.WriteLine("4. Exit");
    Console.WriteLine("Choose option 1-4: ");

string option = Console.ReadLine();


switch (option)
    {
    case "1": 
            AddTask();
            break;
    case "2": 
            MarkTaskCompleted();
            break;
    case "3": 
            ViewTasks();
            break;
    case "4": 
            Exit();
            break;

    default : Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                break;
    }
    }


static void AddTask()
{
    Console.WriteLine("Enter a new task:");
    string newTask = Console.ReadLine();
    
    if(taskCount < tasks.Length)
    {
        tasks[taskCount] = newTask;
        taskCount++;
        Console.WriteLine("Task added successfully.");
    }
    else
    {
        Console.WriteLine("Task limit reached. Cannot add more tasks.");
    }
}


static void ViewTasks()
{
    Console.WriteLine("\nTasks List:");

    for(int i = 0; i <  taskCount; i++)
    {
        if(tasks[i] != null)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
        
    } 

    if(taskCount == 0 || tasks.All(task => task == null))
    {
        Console.WriteLine("No tasks available.");
    }
}


static void MarkTaskCompleted()
{
    ViewTasks();

    Console.Write(" Enter the number of the task to mark as completed: ");
    if(int.TryParse(Console.ReadLine(), out int taskNumber)&& taskNumber > 0 && taskNumber <= taskCount)
    {
        Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as completed.");
        tasks[taskNumber -1] =null; //Marks the task as completed by setting it to null
    }
    else
    {
        Console.WriteLine("Invalid task number. Please enter a valid task number.");
    }
}
static void Exit()
{
    Console.WriteLine("Exiting Task Manager!!");
    string ExitingTaskManager = Console.ReadLine();
}


}//main method
}//class

}//class


        


