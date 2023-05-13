using System;
using System.IO; 
 
 /*
    Journal Class
    Written By:Sheena Hamilton
    Date: May 10, 2023

    Purpose: Creates a journal.

    Attributes:
    _entries : list
    _writingPrompt : WritingPrompt

    Behaviors :
    DisplayJournal() : void
    MakeNewEntry() : void
    SaveJournal() : void
    LoadJournal() : void
 */

 public class Journal
 {
    public List<Entry> _entries = new List<Entry>();
    public WritingPrompt _writingPrompt = new WritingPrompt();
    private string _fileName = "myJournal.csv";

    public void DisplayJournal()
    {
         Console.WriteLine($"\nJournal Entries\n");

         foreach (Entry entry in _entries)
         {
            entry.DisplayEntry();
         }
         
    }

    public void MakeNewEntry()
    {
        Entry newEntry = new Entry();
        string prompt;
        string response;

        do
        {
            prompt = _writingPrompt.GetPrompt();
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.WriteLine($"Enter your response ot type SKIP for a new pompt");
            response = Console.ReadLine();
        } while(response.ToLower() == "skip");

        newEntry._date = DateTime.Now;
        newEntry._prompt = prompt;
        newEntry._response = response;

        _entries.Add(newEntry);

        Console.WriteLine("\n* Entry Recorded *\n");
         
    }

    public void SaveJournal()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
            
        }
        Console.WriteLine("\n* File Saved *\n");
    }

    public void LoadJournal()
    {
        string overwriteFile = "Y";

        if (_entries.Count() > 0)
        {
            Console.Write("\n!! Loading a file will overwrite the existing contents in the program. Do you wish to proceed? Y | N : ");
            overwriteFile = Console.ReadLine();
            if (overwriteFile.ToLower() == "y")
            {
                _entries.Clear();
            }
        }

        if (overwriteFile.ToLower() == "y")
        {
            string[] filelines = System.IO.File.ReadAllLines(_fileName);

            foreach (string line in filelines)
            {
                Entry newEntry = new Entry();

                string[] parts = line.Split("|");

                newEntry._date = DateTime.Parse(parts[0]);
                newEntry._prompt = parts[1];
                newEntry._response = parts[2];
                _entries.Add(newEntry);
            }
            Console.WriteLine("\n* File Loaded *\n");
        }
        else
        {
            Console.WriteLine("\n* File Load Cancelled *\n");
        }
    }
 }