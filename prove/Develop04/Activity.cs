using System;

class Activity
{

    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    protected DateTime _startTime;
    protected DateTime _endTime;

     public string GetName() 
     {
        return _activityName;
     }
     public void SetName(string name) 
     {
        _activityName =  name;
     }
  
     public string GetDescription() 
     {
          return _activityDescription;
     }
     public void SetDescription(string description) 
     {
          _activityDescription =  description;
     }
  
     public int GetDuration() 
     {
          return _activityDuration;
     }

     public void SetDuration() 
     {
          //Asks user for length of activity and sets the class attribute for duration.
          int duration = 0;
          Console.Write("\nHow long, in seconds would you like for your session?: ");
          duration = int.Parse(Console.ReadLine());

         _activityDuration =  duration;
     }
   

     public void StartActivity()
     {
          Console.WriteLine($"Welcome to the {GetName()}");
          Console.WriteLine($"\n\n{GetDescription()}");
          Thread.Sleep(4000);

          //Play the spinner to prepare the user to begin
          WaitSpinner(5, "Ready ", "...Begin!");
     }

     public void SetEndtime()
     {
          //Set the start time after the welcome message so all the time is spent on the activity itself 
          //for the end time add the duration to the start time to get the proposed end time.
          _startTime = DateTime.Now;
          _endTime = _startTime.AddSeconds(GetDuration());

     }   

     public void DisplayEndMessage() 
     {
          DateTime currentTime = DateTime.Now;
          TimeSpan totalTimeActivity;
          totalTimeActivity = (currentTime - _startTime);

          Console.WriteLine($"\n\nActivity Complete. Great job on the {GetName()}. You spent {totalTimeActivity.ToString(@"mm")} minutes and {totalTimeActivity.ToString(@"ss")} seconds doing the activity.");

          WaitSpinner(5);
     }
   
     public void WaitSpinner(int time, string beginPrompt = "", string endPrompt = "") 
     {

          //I don't want the spinner using the main endtime, it doesn't need to exist outside of this 
          //context
          DateTime startTime = DateTime.Now;
          DateTime endTime = startTime.AddSeconds(time);

          DateTime currentTime = DateTime.Now;

          Console.Write(beginPrompt); 
          while( currentTime < endTime)
          {
               Console.Write("--");
               Thread.Sleep(500);
               Console.Write("\b\b"); 
               Console.Write("\\ ");
               Thread.Sleep(500);
               Console.Write("\b\b"); 
               Console.Write("| ");
               Thread.Sleep(500);
               Console.Write("\b\b"); 
               Console.Write("/ ");
               Thread.Sleep(500);
               Console.Write("\b\b"); 
               currentTime = DateTime.Now;

          }
          Console.Write($"{endPrompt}\n"); 
          Thread.Sleep(500);

     } 
     
     public void Countdown(int time,string startPrompt, string endPrompt) 
     {

          //I don't want the countdown using the main endtime, it doesn't need to exist outside of this 
          //context
          Console.Write(startPrompt);

          for(int i = time; i > 0; i--)
          {

               Console.Write($"{i}");
               Thread.Sleep(1000);

               for (int charIndex = 1; charIndex < i.ToString().Length; charIndex++) 
               {
                    Console.Write("\b \b");
               }
               
               Console.Write("\b");
          }

          Console.WriteLine($"{endPrompt}\n"); 
          Thread.Sleep(500);
     }
}