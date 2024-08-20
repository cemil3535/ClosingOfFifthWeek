using WeekFiveClosed;



internal class Program
{
    private static void Main(string[] args)
    {
        // Cars list created
        List<Car> cars = new List<Car>();

        bool inValidValue = false;

        while (!inValidValue)
        {
            Console.WriteLine("Araba uretmek istiyor musunuz? (e/h): ");
        string userRespond = Console.ReadLine().ToLower();

        
            if (userRespond != "e" && userRespond != "h")
            {
                Console.WriteLine("Gecersiz bir secim yaptiniz. Lutfen tekrar deneyin");
                inValidValue = false;
            }


            if (userRespond == "h")
            {
                Console.WriteLine("Program Sonlandirildi.");
                break;
            }

          

            else if (userRespond == "e")
            {
           comeHere1:

                // Car object created and user get property
                Car car = new Car();


                Console.Write("Lutfen Seri Numarasini Giriniz: ");
                car.SerialNumber = Console.ReadLine();

                Console.Write("Lutfen Markasini Giriniz: ");
                car.Brand = Console.ReadLine();

                Console.Write("Lutfen Modelini Giriniz: ");
                car.Model = Console.ReadLine();

                Console.Write("Lutfen Rengini Giriniz: ");
                car.Colour = Console.ReadLine();


            //doorsNumbers do control. If incorrect data is entered, an error is thrown.
            comeHere2:
                while (!inValidValue)
                {
                    try
                    {
                        Console.Write("Lutfen Kapi Sayisini Giriniz: ");
                        car.DoorsNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Hatali veri Girdiniz.");
                        goto comeHere2;
                    }
                }

                // Car object add property
                cars.Add(car);

                Console.Write("Baska Bir Araba Uretmek Istiyor Musunuz?(e/h): ");
                 userRespond = Console.ReadLine().ToLower();

                if(userRespond == "e") 
                {
                    goto comeHere1;
                }

                // Whole car list
                else
                {
                    Console.WriteLine("Uretilen Tum Arabalar");
                    foreach (var item in cars) 
                    {
                        Console.WriteLine($"Seri Numarasi: {item.SerialNumber}, Marka: {item.Brand}");
                        
                    }
                    return;
                }
            }
        }
    }
}