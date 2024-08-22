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

                string newContent = EditFile(fileContent);

                //Save Changes
                try{
                     SaveChanges(filePath, newContent);
                     Console.WriteLine("Changes saved successfully!");
                }
                catch(Exception err){
                    Console.WriteLine($"Error saving changes: {err.Message}");
                }
            }
            else{
                Console.WriteLine("File not found!");
            }
    }
    


    //Edit File
    static public string EditFile(string[] fileContent){

        Console.WriteLine("Enter your content: \n");
        string newContent = "";
        string line;

        while((line = Console.ReadLine()) != null){
            if (line.Trim().ToUpper() == "CTRL+Z"){
                break;
            }
            newContent += line + "\n";
            //newContent.Add( line + '\n');
        }
            Console.WriteLine(newContent);

        return newContent;

    }

    static public void SaveChanges(string filePath, string editedContent){


        File.WriteAllText(filePath, editedContent);

    }
}