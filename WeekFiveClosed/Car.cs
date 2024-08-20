using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFiveClosed
{
    // Car class definition
    public class Car
    {

        //property definition.
        public DateTime ProductDate {  get; private set; }
        public string SerialNumber { get; set; }
        public string Brand {  get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }      
        public int DoorsNumber { get; set; }

        // ProductDate constructor definition
        public Car()
        {
            ProductDate = DateTime.Now;
            

        }

    }
}
