using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurinoVehicleInventory
{
    public class Truck : Vehicle
    {
        private int _wheels = 4;
        public override int Wheels
        { 
            get { return _wheels; } 
        }
        

        public override int MaxPassengers
        {
            get { return 3; }
        }

        public override string GetDescription()
        {
            return $"Truck License Plate :{LicensePlate} VIN: {VIN} Wheels:{_wheels} " +
                $"Passengers: {MaxPassengers}.";
        }

        public override string ToString()
        {
            return $"Truck License Plate :{LicensePlate} VIN: {VIN}";
        }

    }
}
