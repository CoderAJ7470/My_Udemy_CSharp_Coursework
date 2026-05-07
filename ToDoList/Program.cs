// Sec 3, lesson 80 - the "this" keyword

Console.ReadKey();

class MedicalAppointmentPrint
{
    public void Print(MedicalAppointment medAppointment)
    {
        Console.WriteLine($"Your appointment is scheduled for {medAppointment.GetDate()}");
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    // shorthand for returning data/value from a method
    public DateTime GetDate() => _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    // Overloaded constructor #1 of MedicalAppointment constructor above
    // calls the constructor below in a shorthand format using the "this" keyword to refer to
    // the constructor below, and then passing the pertinent arguments to the method
    // signature below. This reduces code duplication.
    public MedicalAppointment(string patientName): this(patientName, 7)
    {        
    }

    // Overloaded constructor #2
    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    // Overloaded method
    public void Reschedule(DateTime date)
    {
        _date = date;
        var print = new MedicalAppointmentPrint();

        print.Print(this);
    }

    // Overload #1
    public void RescheduleByMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void AddMonthsAndDaysToAppointment(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
}


