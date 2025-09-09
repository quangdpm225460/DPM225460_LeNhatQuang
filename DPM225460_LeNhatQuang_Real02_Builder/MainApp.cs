﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225460_LeNhatQuang_Real02_Builder
{
    class MainApp
    {
        public static void Main()
        {
            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();
            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}
