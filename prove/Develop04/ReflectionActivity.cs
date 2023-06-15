using System;

class ReflectionActivity:Activity
{
    private List<string> _reflectionPrompt = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();

    public ReflectionActivity()
    {
            //initial setup. populate both member lists
            SetupReflectionList();
            SetupReflectionQuestions();
            
            //Set the name of the activity and description
            SetName("Reflection Activity");
            SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
            //Prompt for duration and clear the console for the activity
            SetDuration();
            Console.Clear();
    }

    private void SetupReflectionList()
    {
        //populate the reflection prompt
        _reflectionPrompt.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompt.Add("Think of a time when you did something really difficult.");
        _reflectionPrompt.Add("Think of a time when you helped someone in need.");
        _reflectionPrompt.Add("Think of a time when you did something truly selfless.");
    }
    
    private void SetupReflectionQuestions()
    {
        //Populate the Reflection questions
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }   
    
    private void DisplayReflection()
    {
        //Get a random index based on the _reflectionprompt list.
        Random randomIndex = new Random();
        int index;
        index = randomIndex.Next(0, _reflectionPrompt.Count());

        //Display the Reflection Prompt
        Console.WriteLine($"\n\n>>>>> {_reflectionPrompt[index]} <<<<<");
        Thread.Sleep(8000);
    }

    public void GuidedReflection()
    {
        Console.CursorVisible = false;

        //Run the start activity sequence (welcome message) and display the reflection prompt tp the user
        StartActivity();
        DisplayReflection();
        SetEndtime();

        //Set the current datetime to keep track of the end time.
        DateTime currentTime = DateTime.Now;
        int questionIndex = 0;

        //While there is time remaining, repeat the exercise
        //Only if there are reflection questions left. Otherwise end.
         while( currentTime < _endTime && questionIndex < _reflectionQuestions.Count())
        {
            Console.WriteLine($"\n\n{_reflectionQuestions[questionIndex]}");
            WaitSpinner(10,"Reflect...", "\b\b\b\b\b\b\b\b\b\b\b\b\bDone         ");

            questionIndex += 1;
            currentTime = DateTime.Now;
        }

        //Show user the end message with a short pause and complete.
        DisplayEndMessage();
        Console.CursorVisible = true;
    }
    

}