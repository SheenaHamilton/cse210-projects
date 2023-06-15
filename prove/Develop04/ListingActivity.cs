using System;

class ListingActivity:Activity
{
    private List<string> _listingQuestions = new List<string>();
    private List<string> _listingAnswers = new List<string>();

    public ListingActivity()
    {
        SetupListingQuestions();
            
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");   

        SetDuration();
        Console.Clear();    
    }

    private void SetupListingQuestions()
    {
        _listingQuestions.Add("Who are people that you appreciate?");
        _listingQuestions.Add("What are personal strengths of yours?");
        _listingQuestions.Add("Who are people that you have helped this week?");
        _listingQuestions.Add("When have you felt the Holy Ghost this month?");
        _listingQuestions.Add("Who are some of your personal heroes?");
    }   
    
    private void DisplayListingQuestion()
    {
        Random randomIndex = new Random();
        int index;
        index = randomIndex.Next(0, _listingQuestions.Count());

        Console.WriteLine($"\n\n{_listingQuestions[index]}");
    }

    public void GuidedListing()
    {
        Console.CursorVisible = false;

        StartActivity();
        DisplayListingQuestion();
        Countdown(10, "Start Listing In ", "Start Writing!");
        SetEndtime();

        Console.CursorVisible = true;
        DateTime currentTime = DateTime.Now;

        //While there is time remaining, repeat the exercise
        while( currentTime < _endTime)
        {
            Console.Write($"Response: ");
            _listingAnswers.Add(Console.ReadLine());

            currentTime = DateTime.Now;
        }

        Console.CursorVisible = false;
        //Show user the end message with a short pause and complete.
        Console.WriteLine($"Total listed items was {_listingAnswers.Count()}");
        DisplayEndMessage();
        Console.CursorVisible = true;
    }
    

}