using AP3;

var group1 = new Group
{
    Name = "Information Technology",
    NumberOfPeople = new List<People>()
    {
        new People
        {
            Imie = "Maciej",
            Nazwisko = "Kasztan"
        },
        new People
        {
            Imie = "Michał",
            Nazwisko = "Lipa"
        },
        new People
        {
            Imie = "Anna",
            Nazwisko = "Sosna"
        }
    },
    Subject = new Subject
    {
        DateAndTimeOfClass = new List<DateTime>(){
                        DateTime.Parse("2022/12/01 10:00"),
                        DateTime.Parse("2022/12/01 15:00"),
                        DateTime.Parse("2022/12/01 12:00"),
                        DateTime.Parse("2022/12/01 14:00"),
                        }
    }
};
var group2 = new Group
{
    Name = "Logistics",
    NumberOfPeople = new List<People>()
    {
        new People
        {
            Imie = "Alicja",
            Nazwisko = "Wiśnia"
        },
        new People
        {
            Imie = "Agata",
            Nazwisko = "Sobota"
        },
        new People
        {
            Imie = "Mateusz",
            Nazwisko = "Guzik"
        }
    },
    Subject = new Subject
    {
        DateAndTimeOfClass = new List<DateTime>(){
                        DateTime.Parse("2022/12/01 10:00"),
                        DateTime.Parse("2022/12/11 10:00"),
                        DateTime.Parse("2022/12/21 10:00"),
                        DateTime.Parse("2022/12/31 10:00"),
                        }
    }
};

group1.Subject.DateAndTimeOfClass.ToList().ForEach(x =>
{
    if (group2.Subject.DateAndTimeOfClass.Any(y => y.CompareTo(x) == 0))
    {
        Console.WriteLine($"There is a collision of class hours: {x.ToString("dd-MM-yyyy hh:mm")}");
    }
});