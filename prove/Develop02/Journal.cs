using System.IO;
using System.Runtime.CompilerServices;

public class Journal{
    public List<string> _entries = new List<string>();
    public Entry _myEntry = new Entry();
    public string _file = "";
    public Journal(){

    }

    public void AddEntry(){
        _entries.Add($"{_myEntry._date} - {_myEntry._promptText} > {_myEntry._entryText}");
    }

    public void ShowEntries(){
        foreach(string entry in _entries){
            Console.WriteLine(entry);
            
        }
    }

    public void SaveToFile(){
        
        using (StreamWriter outputFile = new StreamWriter(_file, append:true)){
            foreach(string entry in _entries){
                outputFile.WriteLine(entry);
            }
        }

    }

    public void ReadFromFile(){
        string[] lines = System.IO.File.ReadAllLines(_file);

        foreach(string line in lines){
            string[] content = line.Split("/n");
            foreach(string item in content){
                _entries.Add(item);
            }
        }
    }
}