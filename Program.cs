using QueueUsingLinkedList;

Console.WriteLine("Hello World!");
QueueUsingLinkedList.LinkedListQueue linkedListQueue = new LinkedListQueue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Display();// this.top=this.top.next
Console.ReadKey();