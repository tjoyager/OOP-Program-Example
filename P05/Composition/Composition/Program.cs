// See https://aka.ms/new-console-template for more information

using Composition;

Engine engineMobil = new Engine(1500, 121);
Car car = new Car("Toyota", 1500, engineMobil);

// Method internal tidak diperlukan untuk diekspos oleh kelas Car
//car.IgniteEngine();
//car.AccelerateEngine(10);
//car.DeaccelerateEngine(10);
//car.ShutDownEngine();

car.TurnOn();
car.Accelerate(100);
car.Brake();
car.TurnOff();

Engine engineBus = new Engine(5500, 550);
Bus bus = new Bus("HINO", 90, engineBus);

// Method internal tidak diperlukan untuk diekspos oleh kelas Bus
//bus.IgniteEngine();
//bus.AccelerateEngine(10);
//bus.DeaccelerateEngine(10);
//bus.ShutDownEngine();

bus.TurnOn();
bus.Accelerate(100);
bus.Brake();
bus.TurnOff();
