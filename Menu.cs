 static class Menu{
    public static void displayMenu(){
      
      Console.WriteLine("Text Editor - Menu:");
      Console.WriteLine("1. Open file");
      //Console.WriteLine("2. Save changes");
      Console.WriteLine("2. Exit");
      readUserInput();
    }


    public static void readUserInput(){

        Console.Write("\nEnter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice){
           case 1:
                Console.Write("Enter the file path: ");
                FileHandler.OpenFile();
                break;
           case 2:
                Console.Write("Exiting program...");
                break;
        
        }
    }

     public static void HandleFileEditing()
    {
        Console.WriteLine("Press 1 to edit, or 2 to exit");
        int choice = Convert.ToInt32(Console.ReadLine());
         switch(choice){
           case 1:
                Console.Write("Enter the file path: ");
                FileHandler.OpenFile();
                break;
           case 2:
                Console.Write("Exiting program...");
                break;
        
        }
    }
}