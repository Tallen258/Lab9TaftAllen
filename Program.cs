List<(string,string,DateTime ,DateTime? endTime)> ToDo;

ToDo = new List<(string, string,DateTime,DateTime? endtime)>();

void todo()
{
    Console.WriteLine("what task would you like to do");
    string ToDoName = Console.ReadLine();
    // Console.WriteLine(ToDoName);20
    Console.WriteLine(" please add a short description about your item.");
    string description = Console.ReadLine();
    // Console.WriteLine(" What year would you like to start.");
    // int year = int.Parse(Console.ReadLine());
    // int a = year;
    // Console.WriteLine(" What month would you like to start.");

    // int month = int.Parse(Console.ReadLine());

    // int y = month;
    // Console.WriteLine(" What date would you like to start.");

    // int day = int.Parse(Console.ReadLine());

    // int z = day;
    // DateTime future = new DateTime(a, y, z);
    // Console.WriteLine(future);

    Console.WriteLine(description);

    DateTime? endtime =null;
    ToDo.Add((ToDoName, description, DateTime.Now, endtime ));
    Console.WriteLine(ToDo[ToDo.Count - 1]);

}

void completeTodo(){
    for (int x=0; x<ToDo.Count;x++){
        Console.WriteLine(x+": "+ToDo[x]);
    }
    Console.WriteLine("what task did you complete 1,2 3,4?");
    int ToDoName = int.Parse (Console.ReadLine());

}
void viewTodo(){

}


void menu()
{
    Console.WriteLine("1: add to to do list");
    Console.WriteLine("2: if you would like to add to complete to do items");
    Console.WriteLine ("3: type 3 to view your todo list");
    string? choice = Console.ReadLine();
    switch (Convert.ToInt32(choice))
    {
        case 1:
        todo ();
            break;
        case 2:
        completeTodo ();
    
            break;
        case 3:
        viewTodo ();
            break;
        default:
            break;
    }
}
bool KeepGoing= true;
while(KeepGoing){

todo();
completeTodo(); 
}
