using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Полиморфизм: 19 заданий\n");

        DemoAnimals();
        DemoTransport();
        DemoWorkers();
        DemoShapes();
        DemoBankAccounts();
        DemoPlayers();
        DemoDevices();
        DemoInstruments();
        DemoBirds();
        DemoSalaries();
        DemoPayments();
        DemoNotifications();
        DemoDeliveries();
        DemoDiscounts();
        DemoRobots();
        DemoAbstractShapes();
        DemoTransports();
        DemoPayroll();
        DemoProducts();
    }

    private static void DemoAnimals()
    {
        Console.WriteLine("1. Животные");
        List<Animal> animals = new() { new Dog(), new Cat(), new Cow() };
        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.GetType().Name}: {animal.MakeSound()}");
        }
        Console.WriteLine();
    }

    private static void DemoTransport()
    {
        Console.WriteLine("2. Транспорт");
        List<Vehicle> vehicles = new() { new Car(), new Bike(), new Bus() };
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.Move()}");
        }
        Console.WriteLine();
    }

    private static void DemoWorkers()
    {
        Console.WriteLine("3. Работники");
        List<Employee> employees = new() { new Programmer(), new Teacher(), new Doctor() };
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.GetType().Name}: {employee.Work()}");
        }
        Console.WriteLine();
    }

    private static void DemoShapes()
    {
        Console.WriteLine("4. Фигуры");
        List<Shape> shapes = new() { new Rectangle(5, 4), new Circle(3), new Triangle(4, 5) };
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name}: площадь = {shape.GetArea():F2}");
        }
        Console.WriteLine();
    }

    private static void DemoBankAccounts()
    {
        Console.WriteLine("5. Банковские счета");
        List<BankAccount> accounts = new() { new SavingsAccount(1000m), new BusinessAccount(2000m) };
        foreach (var account in accounts)
        {
            Console.WriteLine($"{account.GetType().Name}: проценты = {account.CalculateInterest():C}");
        }
        Console.WriteLine();
    }

    private static void DemoPlayers()
    {
        Console.WriteLine("6. Игроки");
        List<Player> players = new() { new Warrior(), new Archer(), new Mage() };
        foreach (var player in players)
        {
            Console.WriteLine($"{player.GetType().Name}: {player.Attack()}");
        }
        Console.WriteLine();
    }

    private static void DemoDevices()
    {
        Console.WriteLine("7. Устройства");
        List<Device> devices = new() { new Phone(), new Computer(), new Television() };
        foreach (var device in devices)
        {
            Console.WriteLine($"{device.GetType().Name}: {device.TurnOn()}");
        }
        Console.WriteLine();
    }

    private static void DemoInstruments()
    {
        Console.WriteLine("8. Музыкальные инструменты");
        List<Instrument> instruments = new() { new Guitar(), new Piano(), new Drums() };
        foreach (var instrument in instruments)
        {
            Console.WriteLine($"{instrument.GetType().Name}: {instrument.Play()}");
        }
        Console.WriteLine();
    }

    private static void DemoBirds()
    {
        Console.WriteLine("9. Птицы");
        List<Bird> birds = new() { new Eagle(), new Penguin(), new Sparrow() };
        foreach (var bird in birds)
        {
            Console.WriteLine($"{bird.GetType().Name}: {bird.Fly()}");
        }
        Console.WriteLine();
    }

    private static void DemoSalaries()
    {
        Console.WriteLine("10. Сотрудники и зарплата");
        List<StaffEmployee> employees = new() { new Manager(), new Developer(), new Intern() };
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.GetType().Name}: зарплата = {employee.CalculateSalary():C}");
        }
        Console.WriteLine();
    }

    private static void DemoPayments()
    {
        Console.WriteLine("11. Оплата");
        List<Payment> payments = new() { new CashPayment(), new CardPayment(), new CryptoPayment() };
        foreach (var payment in payments)
        {
            Console.WriteLine($"{payment.GetType().Name}: {payment.Pay()}");
        }
        Console.WriteLine();
    }

    private static void DemoNotifications()
    {
        Console.WriteLine("12. Уведомления");
        List<Notification> notifications = new() { new EmailNotification(), new SmsNotification(), new PushNotification() };
        foreach (var notification in notifications)
        {
            Console.WriteLine($"{notification.GetType().Name}: {notification.Send()}");
        }
        Console.WriteLine();
    }

    private static void DemoDeliveries()
    {
        Console.WriteLine("13. Доставка");
        List<Delivery> deliveries = new() { new CourierDelivery(), new PostDelivery(), new ExpressDelivery() };
        foreach (var delivery in deliveries)
        {
            Console.WriteLine($"{delivery.GetType().Name}: {delivery.CalculatePrice():C}");
        }
        Console.WriteLine();
    }

    private static void DemoDiscounts()
    {
        Console.WriteLine("14. Скидки");
        List<Discount> discounts = new() { new StudentDiscount(), new VipDiscount(), new SeasonalDiscount() };
        foreach (var discount in discounts)
        {
            Console.WriteLine($"{discount.GetType().Name}: {discount.CalculateDiscount(1000m):C}");
        }
        Console.WriteLine();
    }

    private static void DemoRobots()
    {
        Console.WriteLine("15. Роботы");
        List<Robot> robots = new() { new CleaningRobot(), new SecurityRobot(), new DeliveryRobot() };
        foreach (var robot in robots)
        {
            Console.WriteLine($"{robot.GetType().Name}: {robot.PerformTask()}");
        }
        Console.WriteLine();
    }

    private static void DemoAbstractShapes()
    {
        Console.WriteLine("16. Геометрические фигуры (abstract)");
        List<AbstractShape> shapes = new()
        {
            new CircleShape(3),
            new RectangleShape(3, 4),
            new SquareShape(5),
            new TriangleShape(3, 4, 5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name}: площадь = {shape.GetArea():F2}, периметр = {shape.GetPerimeter():F2}");
        }
        Console.WriteLine();
    }

    private static void DemoTransports()
    {
        Console.WriteLine("17. Система транспорта (abstract)");
        List<Transport> transports = new() { new CarTransport(), new Train(), new Airplane(), new Ship() };
        foreach (var transport in transports)
        {
            Console.WriteLine($"{transport.GetType().Name}: скорость = {transport.GetSpeed()} км/ч");
        }
        Console.WriteLine();
    }

    private static void DemoPayroll()
    {
        Console.WriteLine("18. Зарплата сотрудников (abstract)");
        List<PayrollEmployee> employees = new() { new ManagerEmployee(), new DeveloperEmployee(), new SalesManager() };
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.GetType().Name}: зарплата = {employee.CalculateSalary():C}");
        }
        Console.WriteLine();
    }

    private static void DemoProducts()
    {
        Console.WriteLine("19. Интернет-магазин");
        List<Product> products = new()
        {
            new Electronics("Ноутбук", 1000m),
            new Food("Яблоки", 50m),
            new Clothing("Футболка", 300m)
        };

        foreach (var product in products)
        {
            Console.WriteLine($"{product.GetType().Name}: {product.Name}, финальная цена = {product.GetFinalPrice():C}");
        }
        Console.WriteLine();
    }
}

public class Animal
{
    public virtual string MakeSound() => "Some sound";
}

public class Dog : Animal
{
    public override string MakeSound() => "Гав-гав";
}

public class Cat : Animal
{
    public override string MakeSound() => "Мяу";
}

public class Cow : Animal
{
    public override string MakeSound() => "Му";
}

public class Vehicle
{
    public virtual string Move() => "Транспорт движется";
}

public class Car : Vehicle
{
    public override string Move() => "Автомобиль едет по дороге";
}

public class Bike : Vehicle
{
    public override string Move() => "Велосипед едет по велодорожке";
}

public class Bus : Vehicle
{
    public override string Move() => "Автобус движется по маршруту";
}

public class Employee
{
    public virtual string Work() => "Работает";
}

public class Programmer : Employee
{
    public override string Work() => "Пишет код";
}

public class Teacher : Employee
{
    public override string Work() => "Проводит урок";
}

public class Doctor : Employee
{
    public override string Work() => "Лечит пациентов";
}

public class Shape
{
    public virtual double GetArea() => 0;
}

public class Rectangle : Shape
{
    private readonly double _width;
    private readonly double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea() => _width * _height;
}

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea() => Math.PI * _radius * _radius;
}

public class Triangle : Shape
{
    private readonly double _base;
    private readonly double _height;

    public Triangle(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public override double GetArea() => 0.5 * _base * _height;
}

public class BankAccount
{
    protected decimal Balance { get; set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public virtual decimal CalculateInterest() => 0m;
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(decimal balance) : base(balance) { }

    public override decimal CalculateInterest() => Balance * 0.05m;
}

public class BusinessAccount : BankAccount
{
    public BusinessAccount(decimal balance) : base(balance) { }

    public override decimal CalculateInterest() => Balance * 0.08m;
}

public class Player
{
    public virtual string Attack() => "Атакует";
}

public class Warrior : Player
{
    public override string Attack() => "Воин наносит удар мечом";
}

public class Archer : Player
{
    public override string Attack() => "Лучник стреляет из лука";
}

public class Mage : Player
{
    public override string Attack() => "Маг кастует заклинание";
}

public class Device
{
    public virtual string TurnOn() => "Устройство включено";
}

public class Phone : Device
{
    public override string TurnOn() => "Телефон включён";
}

public class Computer : Device
{
    public override string TurnOn() => "Компьютер запустился";
}

public class Television : Device
{
    public override string TurnOn() => "Телевизор включён";
}

public class Instrument
{
    public virtual string Play() => "Звучит инструмент";
}

public class Guitar : Instrument
{
    public override string Play() => "Гитара звучит";
}

public class Piano : Instrument
{
    public override string Play() => "Пианино играет мелодию";
}

public class Drums : Instrument
{
    public override string Play() => "Барабаны громко бьют";
}

public class Bird
{
    public virtual string Fly() => "Птица летит";
}

public class Eagle : Bird
{
    public override string Fly() => "Орел парит в небе";
}

public class Penguin : Bird
{
    public override string Fly() => "Пингвин не умеет летать";
}

public class Sparrow : Bird
{
    public override string Fly() => "Воробей быстро летает";
}

public class StaffEmployee
{
    public virtual decimal CalculateSalary() => 0m;
}

public class Manager : StaffEmployee
{
    public override decimal CalculateSalary() => 50000m;
}

public class Developer : StaffEmployee
{
    public override decimal CalculateSalary() => 75000m;
}

public class Intern : StaffEmployee
{
    public override decimal CalculateSalary() => 25000m;
}

public abstract class Payment
{
    public abstract string Pay();
}

public class CashPayment : Payment
{
    public override string Pay() => "Оплата наличными";
}

public class CardPayment : Payment
{
    public override string Pay() => "Оплата картой";
}

public class CryptoPayment : Payment
{
    public override string Pay() => "Оплата криптовалютой";
}

public class Notification
{
    public virtual string Send() => "Уведомление отправлено";
}

public class EmailNotification : Notification
{
    public override string Send() => "Email отправлен";
}

public class SmsNotification : Notification
{
    public override string Send() => "SMS отправлено";
}

public class PushNotification : Notification
{
    public override string Send() => "Push-уведомление отправлено";
}

public class Delivery
{
    public virtual decimal CalculatePrice() => 0m;
}

public class CourierDelivery : Delivery
{
    public override decimal CalculatePrice() => 150m;
}

public class PostDelivery : Delivery
{
    public override decimal CalculatePrice() => 80m;
}

public class ExpressDelivery : Delivery
{
    public override decimal CalculatePrice() => 250m;
}

public class Discount
{
    public virtual decimal CalculateDiscount(decimal price) => 0m;
}

public class StudentDiscount : Discount
{
    public override decimal CalculateDiscount(decimal price) => price * 0.10m;
}

public class VipDiscount : Discount
{
    public override decimal CalculateDiscount(decimal price) => price * 0.20m;
}

public class SeasonalDiscount : Discount
{
    public override decimal CalculateDiscount(decimal price) => price * 0.15m;
}

public class Robot
{
    public virtual string PerformTask() => "Выполняет задачу";
}

public class CleaningRobot : Robot
{
    public override string PerformTask() => "Убирает помещение";
}

public class SecurityRobot : Robot
{
    public override string PerformTask() => "Охраняет территорию";
}

public class DeliveryRobot : Robot
{
    public override string PerformTask() => "Доставляет посылки";
}

public abstract class AbstractShape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

public class CircleShape : AbstractShape
{
    private readonly double _radius;

    public CircleShape(double radius)
    {
        _radius = radius;
    }

    public override double GetArea() => Math.PI * _radius * _radius;
    public override double GetPerimeter() => 2 * Math.PI * _radius;
}

public class RectangleShape : AbstractShape
{
    private readonly double _width;
    private readonly double _height;

    public RectangleShape(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea() => _width * _height;
    public override double GetPerimeter() => 2 * (_width + _height);
}

public class SquareShape : AbstractShape
{
    private readonly double _side;

    public SquareShape(double side)
    {
        _side = side;
    }

    public override double GetArea() => _side * _side;
    public override double GetPerimeter() => 4 * _side;
}

public class TriangleShape : AbstractShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public TriangleShape(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override double GetArea()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public override double GetPerimeter() => _a + _b + _c;
}

public abstract class Transport
{
    public abstract double GetSpeed();
}

public class CarTransport : Transport
{
    public override double GetSpeed() => 120;
}

public class Train : Transport
{
    public override double GetSpeed() => 180;
}

public class Airplane : Transport
{
    public override double GetSpeed() => 900;
}

public class Ship : Transport
{
    public override double GetSpeed() => 60;
}

public abstract class PayrollEmployee
{
    public abstract decimal CalculateSalary();
}

public class ManagerEmployee : PayrollEmployee
{
    public override decimal CalculateSalary() => 60000m;
}

public class DeveloperEmployee : PayrollEmployee
{
    public override decimal CalculateSalary() => 80000m;
}

public class SalesManager : PayrollEmployee
{
    public override decimal CalculateSalary() => 70000m;
}

public class Product
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual decimal GetFinalPrice() => Price;
}

public class Electronics : Product
{
    public Electronics(string name, decimal price) : base(name, price) { }

    public override decimal GetFinalPrice() => Price * 1.15m;
}

public class Food : Product
{
    public Food(string name, decimal price) : base(name, price) { }

    public override decimal GetFinalPrice() => Price * 1.05m;
}

public class Clothing : Product
{
    public Clothing(string name, decimal price) : base(name, price) { }

    public override decimal GetFinalPrice() => Price * 1.10m;
}
