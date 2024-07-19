using Observer.Observers;
using Observer.Subjects;

class Program
{
    static void Main(string[] args)
    {
        //subject.Attach(observerA);

        //var observerB = new ObserverB();
        //subject.Attach(observerB);

        //subject.SomeBusinessLogic();
        //subject.SomeBusinessLogic();

        //subject.Detach(observerB);

        //subject.SomeBusinessLogic();

        var subject = new Subject();
        var observera = new ObserverA();

        subject.Attach(observera);

        var observerb = new ObserverB();
        subject.Attach(observerb);

        subject.ChangeCurrency(10);

        subject.Detach(observerb);

        subject.ChangeCurrency(100);


    }
}