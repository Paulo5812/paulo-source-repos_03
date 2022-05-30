// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ========================================================================
// Ovning 4
// ========================================================================


using System.Collections;

        

        // Create a queue
        // Using Queue class
        // Adding elements in Queue
        // Using Enqueue() method
        // Removing elements in Queue

        Queue my_queue = new Queue();
my_queue.Enqueue("Kalle");
my_queue.Enqueue("Gretta");
my_queue.Enqueue("Stina");
my_queue.Enqueue("Olle");
my_queue.Enqueue(null);

Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);
//Console.WriteLine("Total elements present in my_queue:", my_queue.Count);



// -----------------------------------------------------

   if (my_queue.Contains("Gretta") == true)

{
    Console.WriteLine("Element available...!!");
}
   else
{
    Console.WriteLine("Element not available...!!");
}
// -----------------------------------------------------
// Console.Write("Queue values:");
//my_queue.Dequeue();

Console.WriteLine("(Dequeue1)\t{0}", my_queue.Dequeue());
Console.WriteLine("(Dequeue2)\t{0}", my_queue.Dequeue());

// Console.WriteLine("\nDequeuing '{0}'", my_queue.Dequeue());

// After Dequeue method
Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);

// -----------------------------------------------------
// Remove all the elements from the queue
// my_queue.Clear();
// After Clear method
// Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);
// ========================================================================
// ========================================================================