using TestPatterns.AbstractFactory;
using TestPatterns.AbstractFactory.Factories;
using TestPatterns.Adapter;
using TestPatterns.ChainOfResponsibility;
using TestPatterns.Composite;
using TestPatterns.Facade;
using TestPatterns.FactoryMethod;
using TestPatterns.Observer;
using TestPatterns.Singleton;
using TestPatterns.State;

namespace TestPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //singleton
            App a = new App();
            a.Launch("123456");
            Console.WriteLine(a.connectionApp.Config);

            a.connectionApp = Connection.GetConnection("543210");
            Console.WriteLine(a.connectionApp.Config);

            //Abstract Factory
            var CombatPlane = new CombatUnit(new PlaneFactory());
            CombatPlane.Move();
            CombatPlane.Hit();

            var CombatPeople = new CombatUnit(new SoldierFactory());
            CombatPeople.Move();
            CombatPeople.Hit();

            //Factory Method

            string MessageText = "032312 - number of delivery";

            MessageSender sender = new SmsMessageSender("8984749824");
            Message SmsMessage = sender.Send(MessageText);

            sender = new EmailMessageSender("1231be@inbox.com");
            Message EmailMessage = sender.Send(MessageText);

            // adapter

            var imageDrawer = new ImageDrawer();
            PaperPrinter paperPrinter = new PaperPrinter();
            imageDrawer.DrawWith(paperPrinter);

            CanvasPainter canvasPainter = new CanvasPainter();
            IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
            imageDrawer.DrawWith(imagePrinter);

            // composite

            Component rootFolder = new Folder("Root");
            Component myFile = new Composite.File("MyFile.txt");
            Folder documentsFolder = new Folder("MyDocuments");

            rootFolder.Add(myFile);
            rootFolder.Add(documentsFolder);
            rootFolder.Display();

            //facade

            facadeEx facade = new facadeEx(new SystemOne(), new SystemTwo(), new SystemThree());

            facade.OperationOne();
            facade.OperationTwo();

            // Chain of Resp

            Receiver receiver = new Receiver(true, true, true);

            NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
            NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
            NotificationHandler smsNotificationHandler = new SmsNotificationHandler();

            emailNotificationHandler.Successor = smsNotificationHandler;
            smsNotificationHandler.Successor = voiceNotificationHandler;

            emailNotificationHandler.Handle(receiver);

            // State

            Elevator elevator = new Elevator(new GroundElevatorState());

            elevator.Up(); 
            elevator.Down(); 
            elevator.Down();

            // observer

            Stock stock = new Stock();

            var bank = new Bank(stock);
            var broker = new Broker(stock);

            stock.Market();

            broker.StopTrade();

            stock.Market();
        }
    }
}
