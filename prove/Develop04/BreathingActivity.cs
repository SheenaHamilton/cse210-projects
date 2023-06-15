using System;

class BreathingActivity:Activity
{
    private int _breathLength;

    public BreathingActivity()
    {
            //Setup. Keep breath length, allows people to have shorter or faster breathing.
            setBreathLength(7);

            //Setup Name and description of the activity
            SetName("Breathing Activity");
            SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            
            //Prompt and set the duration of the activity and clear the console in preparation.
            SetDuration();
            Console.Clear();
    }

    public void setBreathLength(int breathingPause) 
    {
        _breathLength = breathingPause;
    }

    public void GuidedBreathing()
    {
        Console.CursorVisible = false;

        //Start the activity with the welcome message and description
        StartActivity();
        SetEndtime();
        
        //Get the current time to track when the session is over.
        DateTime currentTime = DateTime.Now;
      
        //While there is time remaining, repeat the exercise.
        while( currentTime < _endTime)
        {
            Breath("In", ">");
            Breath("Out", "\b \b"); 
            currentTime = DateTime.Now;
        }

        //Show user the end message with a short pause and complete.
        DisplayEndMessage();
        Console.CursorVisible = true;
        
    }

    private void Breath(string inOut, string charInOut)
    {
        //Breath in message Internal methods. 
        string prompt = $"Breath {inOut} ";
        
        //sets the right amount of characters for the breath out length
        if (inOut.ToLower() == "out")
        {
            string charOut = new string('<', _breathLength);
            prompt = $"{prompt}{charOut}";
        }
        
        Console.Write($"\n{prompt}");

        //loops and pauses for 1 second for every second the breath length is
        for(int x = 0; x < _breathLength; x++)
        {
            Thread.Sleep(1000);
            Console.Write(charInOut);
        }
    }
    
}