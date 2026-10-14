
public class Running : Activity
{
    private double _distance;
    // Creating Constructor  for class running
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }
    //overriding distance getter from Activity class
    public override double GetDistance()
    {
        return _distance;
    }
    //overriding  Getspeed  getter from  Activity class
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
