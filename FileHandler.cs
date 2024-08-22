using System;

static class FileHandler{

    //Open file

    static public void OpenFile(){

        string filePath = Console.ReadLine();

            if(File.Exists(filePath)){
                Console.WriteLine("File opened successfully!");
                string[] fileContent = File.ReadAllLines(filePath);

                foreach(string line in fileContent){
                    Console.WriteLine(line);
                }

                EditFile(fileContent);
            }
            else{
                Console.WriteLine("File not found!");
            }
    }
    


    //Edit File
    static public List<string> EditFile(string[] fileContent){

        Console.WriteLine("Enter your content: \n");
        List<string> newContent = new List<string>();
        string line;

        while((line = Console.ReadLine()) != null){
            if (line.Trim().ToUpper() == "CTRL+Z"){
                break;
            }
            newContent = fileContent.ToList();
            newContent.Add( line + '\n');
        }

        return newContent;

    }
}