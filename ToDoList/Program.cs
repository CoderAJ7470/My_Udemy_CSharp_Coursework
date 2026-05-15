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

    // Overloaded constructor #1
    // Instead of doing public MedicalAppointment(string patientName): this(patientName, 7)
    // like we did previously to call the constructor below in shorthand, we can have an optional
    // parameter for the daysFromNow
    public MedicalAppointment(string patientName, int daysFromNow = 7)
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


