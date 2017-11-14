using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using InternetShop.Models;
using Microsoft.Extensions.DependencyInjection;

namespace InternetShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ShopContext>();
                    SampleData.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }

    public static class SampleData
    {
        public static void Initialize(ShopContext context)
        {
            context.Items.RemoveRange(context.Items);
            context.SaveChanges();

            if (!context.Items.Any())
            {
                var newItem = new Item()
                {
                    Category = "Phone",
                    Name = "iPhone 6S",
                    Company = "Apple",
                    Price = 600,
                    Count = 15,
                    Img = "https://i2.rozetka.ua/goods/2162160/copy_apple_fkqj2rm_a_599ff4704cb72_images_2162160246.jpg"

                };
                newItem.Comments = new List<Comment>
                        {
                            new Comment{
                                Date = new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            },
                            new Comment{
                                Date =  new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            }
                        };
                newItem.Properties = new List<Property>()
                        {
                            new Property()
                            {
                                Name="Диагональ экрана",
                                Value="5.8"
                            },
                             new Property()
                            {
                                Name="Разрешение дисплея",
                                Value="2960x1440"
                            },
                              new Property()
                            {
                                Name="Поддержка 3G",
                                Value="Есть"
                            }
                        };
                context.Items.Add(newItem);

                newItem = new Item()
                {
                    Category = "Phone",
                    Name = "Samsung Galaxy Note 8",
                    Company = "Samsung",
                    Price = 550,
                    Count = 23,
                    Properties = new List<Property>(),
                    
                    Img = "https://i1.rozetka.ua/goods/2161706/samsung_sm_n950fzkdsek_images_2161706779.jpg"
                };
                newItem.Comments = new List<Comment>
                        {
                            new Comment{
                                Date = new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            },
                            new Comment{
                                Date =  new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            }
                        };
                newItem.Properties = new List<Property>()
                        {
                            new Property()
                            {
                                Name="Диагональ экрана",
                                Value="5.8"
                            },
                             new Property()
                            {
                                Name="Разрешение дисплея",
                                Value="2960x1440"
                            },
                              new Property()
                            {
                                Name="Поддержка 3G",
                                Value="Есть"
                            }
                        };
                context.Items.Add(newItem);


                newItem = new Item()
                {
                    Category = "Phone",
                    Name = "Nokia 6",
                    Company = "Nokia",
                    Price = 500,
                    Count = 5,
                    Properties = new List<Property>(),
                   
                    Img = "https://i2.rozetka.ua/goods/1946786/nokia_6_ds_black_images_1946786438.jpg"
                };
                newItem.Comments = new List<Comment>
                        {
                            new Comment{
                                Date = new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            },
                            new Comment{
                                Date =  new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            }
                        };
                newItem.Properties = new List<Property>()
                        {
                            new Property()
                            {
                                Name="Диагональ экрана",
                                Value="5.8"
                            },
                             new Property()
                            {
                                Name="Разрешение дисплея",
                                Value="2960x1440"
                            },
                              new Property()
                            {
                                Name="Поддержка 3G",
                                Value="Есть"
                            }
                        };
                context.Items.Add(newItem);


                newItem = new Item()
                {
                    Category = "Tablet",
                    Name = "iPad",
                    Company = "Apple",
                    Price = 500,
                    Properties = new List<Property>(),
                    Count = 15,
                    Img = "https://i2.rozetka.ua/goods/1892553/apple_ipad_a1822_mp2f2rk_a_images_1892553981.jpg"
                };
                newItem.Comments = new List<Comment>
                        {
                            new Comment{
                                Date = new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            },
                            new Comment{
                                Date =  new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            }
                        };
                newItem.Properties = new List<Property>()
                        {
                            new Property()
                            {
                                Name="Диагональ экрана",
                                Value="5.8"
                            },
                             new Property()
                            {
                                Name="Разрешение дисплея",
                                Value="2960x1440"
                            },
                              new Property()
                            {
                                Name="Поддержка 3G",
                                Value="Есть"
                            }
                        };
                context.Items.Add(newItem);

                newItem = new Item()
                {
                    Category = "Tablet",
                    Name = "Yogo tablet",
                    Company = "Lenovo",
                    Price = 500,
                    Count = 150,
                    Img = "https://i2.rozetka.ua/goods/1627788/copy_lenovo_za090004ua_574d6f826045d_images_1627788474.jpg"
                };

                newItem.Comments = new List<Comment>
                        {
                            new Comment{
                                Date = new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            },
                            new Comment{
                                Date =  new DateTime().ToLocalTime(),
                                Text = "aaaaaaaaaaaaaaaaaaaaaaa",
                                UserName = "Таня"
                            }
                        };
                newItem.Properties = new List<Property>()
                        {
                            new Property()
                            {
                                Name="Диагональ экрана",
                                Value="5.8"
                            },
                             new Property()
                            {
                                Name="Разрешение дисплея",
                                Value="2960x1440"
                            },
                              new Property()
                            {
                                Name="Поддержка 3G",
                                Value="Есть"
                            }
                        };
                context.Items.Add(newItem);

                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        ItemName = "Phone",
                        Name = "Телефоны",
                        Img = "https://comfy.ua/media/blb/samsung/01_1.jpg"
                    },
                    new Category
                    {
                        ItemName = "Tablet",
                        Name = "Планшеты",
                        Img = "https://comfy.ua/media/blb/samsung/02_1.jpg"
                    }

                );
                context.SaveChanges();
            }

        }
    }
}
