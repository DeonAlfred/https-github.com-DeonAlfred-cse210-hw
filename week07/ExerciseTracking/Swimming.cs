
public class Swimming : Activity
{    
    private int _laps;
    // Creating Constructor  for swimmming running
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

   //Calculating Speed and returning speed and overriding Getspeed from activity class
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    //Calculating Pace and returning Pace per km and overrriding  GetPace from activity class
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
     //Calculating Distance per km and overrriding GetDistance from Activity Class
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }

}
