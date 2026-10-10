// See https://aka.ms/new-console-template for more information

using WithoutComposition;

Car car = new Car("Toyota", 1500, 150, 90);
car.IgniteEngine();
car.AccelerateEngine(10);
car.DeaccelerateEngine(10);
car.ShutDownEngine();

car.TurnOn();
car.Accelerate(100);
car.Brake();
car.TurnOff();

Bus bus = new Bus("HINO", 5500, 500, 90);
bus.IgniteEngine();
bus.AccelerateEngine(10);
bus.DeaccelerateEngine(10);
bus.ShutDownEngine();

bus.TurnOn();
bus.Accelerate(100);
bus.Brake();
bus.TurnOff();
