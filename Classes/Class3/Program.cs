
public class TaskScheduler
{
    private SortedDictionary<int, Queue<string>> taskQueue;

    public TaskScheduler()
    {
        taskQueue = new SortedDictionary<int, Queue<string>>();
    }

    public void AddTask(string taskName, int priority)
    {
        if (!taskQueue.ContainsKey(priority))
        {
            taskQueue[priority] = new Queue<string>();
        }
        taskQueue[priority].Enqueue(taskName);
    }

    public void ExecuteTask()
    {
        if (taskQueue.Count == 0)
        {
            Console.WriteLine("No tasks to execute.");
            return;
        }

        var highestPriority = taskQueue.Keys.Min();
        var taskName = taskQueue[highestPriority].Dequeue();
        Console.WriteLine($"Executing task: {taskName} with priority {highestPriority}");

        if (taskQueue[highestPriority].Count == 0)
        {
            taskQueue.Remove(highestPriority);
        }
    }

    public void ShowTasks()
    {
        if (taskQueue.Count == 0)
        {
            Console.WriteLine("No tasks in the queue.");
            return;
        }

        Console.WriteLine("Tasks in the queue:");
        foreach (var kvp in taskQueue)
        {
            foreach (var task in kvp.Value)
            {
                Console.WriteLine($"- {task} (Priority: {kvp.Key})");
            }
        }
    }

    public static void Main(string[] args)
    {
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTask("Task 1", 3);
        scheduler.AddTask("Task 2", 1);
        scheduler.AddTask("Task 3", 2);

        scheduler.ShowTasks();

        scheduler.ExecuteTask();
        scheduler.ExecuteTask();
        scheduler.ShowTasks();
    }
}
