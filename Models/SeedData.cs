using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FInalProjectHomekit.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HomekitDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HomekitDbContext>>()))
            {
                // Look for Categories
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    // 1
                    new Category
                    {
                        CategoryName = "Bridges",
                    },

                    // 2
                    new Category
                    {
                        CategoryName = "Cameras",
                    },

                    // 3
                    new Category
                    {
                        CategoryName = "Lights & Blulbs",
                    },

                    // 4
                    new Category
                    {
                        CategoryName = "Locks",
                    },

                    // 5
                    new Category
                    {
                        CategoryName = "Outlets",
                    },

                    // 6
                    new Category
                    {
                        CategoryName = "Sensors",
                    },

                    // 7
                    new Category
                    {
                        CategoryName = "Switches",
                    },

                    // 8
                    new Category
                    {
                        CategoryName = "Thermostats",
                    }
                );
                context.SaveChanges();


                // Look for Brands
                if (context.Brand.Any())
                {
                    return;   // DB has been seeded
                }

                context.Brand.AddRange(
                    // 1
                    new Brand
                    {
                        BrandName = "August",
                    },

                    // 2
                    new Brand
                    {
                        BrandName = "Belkin",
                    },

                    // 3
                    new Brand
                    {
                        BrandName = "D-Link",
                    },

                    // 4
                    new Brand
                    {
                        BrandName = "ecobee",
                    },

                    // 5
                    new Brand
                    {
                        BrandName = "Eve",
                    },
                    
                    // 6
                    new Brand
                    {
                        BrandName = "FIBARO",
                    },
                    
                    // 7
                    new Brand
                    {
                        BrandName = "Honeywell",
                    },

                    // 8
                    new Brand
                    {
                        BrandName = "iDevices",
                    },

                    // 9
                    new Brand
                    {
                        BrandName = "iHome",
                    },

                    // 10
                    new Brand
                    {
                        BrandName = "Incipio",
                    },

                    // 11
                    new Brand
                    {
                        BrandName = "Leviton",
                    },

                    // 12
                    new Brand
                    {
                        BrandName = "LIFX",
                    },

                    // 13
                    new Brand
                    {
                        BrandName = "Logitech",
                    },

                    // 14
                    new Brand
                    {
                        BrandName = "Lutron",
                    },

                    // 15
                    new Brand
                    {
                        BrandName = "Nanoleaf",
                    },

                    // 16
                    new Brand
                    {
                        BrandName = "Netgear",
                    },

                    // 17
                    new Brand
                    {
                        BrandName = "Philips",
                    },

                    // 18
                    new Brand
                    {
                        BrandName = "Pure Gear",
                    },

                    // 19
                    new Brand
                    {
                        BrandName = "Rachio",
                    },

                    // 20
                    new Brand
                    {
                        BrandName = "Schlage",
                    },

                    // 21
                    new Brand
                    {
                        BrandName = "Sylvania",
                    },

                    // 22
                    new Brand
                    {
                        BrandName = "Yale",
                    }

                );
                context.SaveChanges();
                

                // Look for Products
                 if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    // Bridges
                        new Product{ ProductName = "Philips Hue White and Color Wireless Ambiance Starter Kit A19 E26",
                                     ProductPrice = 149.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(1)
                                    },
                        new Product{ ProductName = "Philips Hue White Starter Kit A19 E26",
                                     ProductPrice = 69.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(1)
                                    },
                        new Product{ ProductName = "Philips Hue White Ambiance A19 Starter Kit",
                                     ProductPrice = 99.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(1)
                                    },
                        new Product{ ProductName = "Wemo Bridge",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(2),
                                    Category = context.Category.Find(1)
                                    },
                        new Product{ ProductName = "Philips HUE HomeKit Upgrade Bridge (for Current HUE Bridge Users)",
                                     ProductPrice = 59.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(1)
                                    },
                        
                    // Cameras
                        new Product{ ProductName = "Logitech Circle 2 Indoor/Outdoor Weatherproof Wired Security Camera",
                                     ProductPrice = 179.95M,
                                        //product image
                                    Brand = context.Brand.Find(),
                                    Category = context.Category.Find(2)
                                    },
                        new Product{ ProductName = "Logitech Circle 2 Window Mount for Circle 2 Wired Security Camera",
                                     ProductPrice = 39.95M,
                                        //product image
                                    Brand = context.Brand.Find(13),
                                    Category = context.Category.Find(2)
                                    },
                        new Product{ ProductName = "D-Link Omna 180 Cam HD Camera",
                                     ProductPrice = 129.95M,
                                        //product image
                                    Brand = context.Brand.Find(3),
                                    Category = context.Category.Find(2)
                                    },
                        new Product{ ProductName = "Arlo Baby 1080p HD Monitoring Camera by NETGEAR",
                                     ProductPrice = 189.95M,
                                        //product image
                                    Brand = context.Brand.Find(16),
                                    Category = context.Category.Find(2)
                                    },

                    // Lights & Blulbs
                        new Product{ ProductName = "Philips Hue White and Color Wireless Ambiance Starter Kit A19 E26",
                                     ProductPrice = 149.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Nanoleaf Canvas Smarter Light Kit",
                                     ProductPrice = 229.95M,
                                        //product image
                                    Brand = context.Brand.Find(15),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Nanoleaf Light Panel Smarter Kits - Rhythm Edition",
                                     ProductPrice = 199.95M,
                                        //product image
                                    Brand = context.Brand.Find(15),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White Starter Kit A19 E26",
                                     ProductPrice = 69.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White Ambiance A19 Starter Kit",
                                     ProductPrice = 99.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Nanoleaf Remote",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(15),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Incipio CommandKit Smart Light Bulb Adapter with Dimming",
                                     ProductPrice = 39.95M,
                                        //product image
                                    Brand = context.Brand.Find(10),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "LIFX Mini White (2700K Warm) A19 E26 Wi-Fi Smart LED Light Bulb",
                                     ProductPrice = 19.95M,
                                        //product image
                                    Brand = context.Brand.Find(12),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue Ambiance White and Color Extension Bulb A19 E26",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White and Color Ambiance LED Flood Light Bulb BR30",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White Ambiance A19 Bulb",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White Ambiance Wireless LED Flood Light BR30",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue Lightstrip Plus",
                                     ProductPrice = 89.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White Extension Bulb A19 E26",
                                     ProductPrice = 14.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "LIFX Mini Color and White A19 E26 Wi-Fi Smart LED Light Bulb",
                                     ProductPrice = 44.95M,
                                        //product image
                                    Brand = context.Brand.Find(12),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue Lightstrip Plus Extension Set (3 ft./1 m)",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue Go",
                                     ProductPrice = 79.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White and Color Ambiance LED Candle Bulb E12/B39",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "LIFX Multicolor A19 E26 Dimmable Wi-Fi Smart LED Light Bulb",
                                     ProductPrice = 59.95M,
                                        //product image
                                    Brand = context.Brand.Find(12),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "LIFX Mini Day & Dusk (White to Amber Spectrum) A19 E26 Wi-Fi Smart LED Light Bulb",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(12),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "LIFX + Infrared Multicolor A19 E26 Dimmable Wi-Fi Smart LED Light Bulb",
                                     ProductPrice = 79.95M,
                                        //product image
                                    Brand = context.Brand.Find(12),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "Philips Hue White Ambiance LED Candle Bulb E12/B39",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(3)
                                    },
                        new Product{ ProductName = "SYLVANIA SMART+ Bluetooth Soft White Filament Bulb A19",
                                     ProductPrice = 34.95M,
                                        //product image
                                    Brand = context.Brand.Find(21),
                                    Category = context.Category.Find(3)
                                    },

                    // Locks
                        new Product{ ProductName = "August Smart Lock Pro + Connect",
                                     ProductPrice = 279.95M,
                                        //product image
                                    Brand = context.Brand.Find(1),
                                    Category = context.Category.Find(4)
                                    },
                        new Product{ ProductName = "Yale Assure Lock SL with iM1",
                                     ProductPrice = 199.95M,
                                        //product image
                                    Brand = context.Brand.Find(22),
                                    Category = context.Category.Find(4)
                                    },
                        new Product{ ProductName = "Schlage Sense Smart Deadbolt with Century Trim",
                                     ProductPrice = 229.95M,
                                        //product image
                                    Brand = context.Brand.Find(20),
                                    Category = context.Category.Find(4)
                                    },
                        new Product{ ProductName = "Schlage Sense Smart Deadbolt with Camelot Trim",
                                     ProductPrice = 229.95M,
                                        //product image
                                    Brand = context.Brand.Find(20),
                                    Category = context.Category.Find(4)
                                    },

                    //Outlets
                        new Product{ ProductName = "Wemo Mini Smart Plug",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(2),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "iDevices Switch",
                                     ProductPrice = 29.95M,
                                        //product image
                                    Brand = context.Brand.Find(8),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "Incipio CommandKit Wireless Smart Outlet With Metering",
                                     ProductPrice = 39.95M,
                                        //product image
                                    Brand = context.Brand.Find(10),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "iDevices Socket",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(8),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "iHome | control iSP6 SmartPlug",
                                     ProductPrice = 39.95M,
                                        //product image
                                    Brand = context.Brand.Find(9),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "iHome | control iSP8 SmartPlug with Remote Control",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(9),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "Eve Energy",
                                     ProductPrice = 39.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(5)
                                    },
                        new Product{ ProductName = "Pure Gear PureSwitch Wireless Smart Plug Apple HomeKit",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(18),
                                    Category = context.Category.Find(5)
                                    },

                    //Sensors
                        new Product{ ProductName = "FIBARO Flood Sensor (HomeKit Enabled)",
                                     ProductPrice = 69.95M,
                                        //product image
                                    Brand = context.Brand.Find(6),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "iHome | control iSS50 5-in-1 Smart Monitor",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(9),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "Eve Aqua Smart Water Controller",
                                     ProductPrice = 99.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "Eve Degree Connected Weather Station",
                                     ProductPrice = 69.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "Eve Room Indoor Air Quality Monitor",
                                     ProductPrice = 99.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "Eve Door & Window Wireless Contact Sensor",
                                     ProductPrice = 39.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "Eve Motion Wireless Motion Sensor",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(6)
                                    },
                        new Product{ ProductName = "Eve Button - Connected Home Remote",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(6)
                                    },

                    //Switches
                        new Product{ ProductName = "Eve Light Switch",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(5),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "Leviton Decora Smart 600W Dimmer",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(11),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "Leviton Decora Smart 15 Amp Switch",
                                     ProductPrice = 44.95M,
                                        //product image
                                    Brand = context.Brand.Find(11),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "Lutron Caséta Wireless In-Wall Light Dimmer with Remote",
                                     ProductPrice = 59.95M,
                                        //product image
                                    Brand = context.Brand.Find(14),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "Lutron Caséta Wireless Smart Lighting Dimmer Switch Starter Kit",
                                         ProductPrice = 99.95M,
                                        //product image
                                    Brand = context.Brand.Find(14),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "Philips Hue tap Switch",
                                     ProductPrice = 49.95M,
                                        //product image
                                    Brand = context.Brand.Find(17),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "iDevices Outdoor Switch",
                                     ProductPrice = 79.95M,
                                        //product image
                                    Brand = context.Brand.Find(8),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "FIBARO Button Multicontroller",
                                     ProductPrice = 59.95M,
                                        //product image
                                    Brand = context.Brand.Find(6),
                                    Category = context.Category.Find(8)
                                    },
                        new Product{ ProductName = "Leviton Decora Smart 1000W Dimmer",
                                     ProductPrice = 54.95M,
                                        //product image
                                    Brand = context.Brand.Find(11),
                                    Category = context.Category.Find(8)
                                    },

                    //Thermostats
                        new Product{ ProductName = "iDevices Thermostat",
                                     ProductPrice = 129.95M,
                                        //product image
                                    Brand = context.Brand.Find(8),
                                    Category = context.Category.Find(9)
                                    },
                        new Product{ ProductName = "ecobee3 lite Smart Thermostat",
                                     ProductPrice = 169.95M,
                                        //product image
                                    Brand = context.Brand.Find(4),
                                    Category = context.Category.Find(9)
                                    },
                        new Product{ ProductName = "Honeywell T5+ Smart Thermostat",
                                     ProductPrice = 149.95M,
                                        //product image
                                    Brand = context.Brand.Find(7),
                                    Category = context.Category.Find(9)
                                    }
                                );
                context.SaveChanges();   
            }
        }
    }
}

