using autoparts.Models;

namespace autoparts.Data
{
    public static class DbInitializer
    {
        public static void ResetAdminBalance(ApplicationDbContext context)
        {
            var admin = context.Users.FirstOrDefault(u => u.Username == "admin");
            if (admin != null)
            {
                admin.Balance = 0;
                context.SaveChanges();
            }
        }

        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (!context.Users.Any())
            {
                var users = new User[]
                {
                    new User
                    {
                        Username = "admin",
                        Password = "admin",
                        Email = "admin@autoparts.com",
                        Role = "Admin"
                    },
                    new User
                    {
                        Username = "user",
                        Password = "password",
                        Email = "user@autoparts.com",
                        Role = "User"
                    }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                var products = new Product[]
                {
                    new Product 
                    { 
                        Name = "Масляный фильтр MANN W 914/2",
                        Price = 499.99M,
                        Description = "Высококачественный масляный фильтр для легковых автомобилей",
                        ImageUrl = "/images/oil-filter.jpg",
                        Category = "Фильтры",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Тормозные колодки Brembo P 85 020",
                        Price = 2999.99M,
                        Description = "Передние тормозные колодки для спортивного вождения",
                        ImageUrl = "/images/brake-pads.jpg",
                        Category = "Тормозная система",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Аккумулятор BOSCH S4 60Ah",
                        Price = 7499.99M,
                        Description = "Надежный аккумулятор с увеличенным сроком службы",
                        ImageUrl = "/images/battery.jpg",
                        Category = "Электрика",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Свечи зажигания NGK Laser Platinum",
                        Price = 799.99M,
                        Description = "Платиновые свечи зажигания с увеличенным ресурсом",
                        ImageUrl = "/images/spark-plugs.jpg",
                        Category = "Система зажигания",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Амортизаторы KYB Excel-G",
                        Price = 3499.99M,
                        Description = "Газовые амортизаторы для комфортной езды",
                        ImageUrl = "/images/shock-absorbers.jpg",
                        Category = "Подвеска",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Ремень ГРМ Gates PowerGrip",
                        Price = 1299.99M,
                        Description = "Усиленный ремень ГРМ с увеличенным ресурсом",
                        ImageUrl = "/images/timing-belt.jpg",
                        Category = "Двигатель",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Воздушный фильтр K&N 33-2865",
                        Price = 1899.99M,
                        Description = "Спортивный воздушный фильтр нулевого сопротивления",
                        ImageUrl = "/images/air-filter.jpg",
                        Category = "Фильтры",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Радиатор охлаждения Nissens",
                        Price = 8999.99M,
                        Description = "Алюминиевый радиатор с повышенной теплоотдачей",
                        ImageUrl = "/images/radiator.jpg",
                        Category = "Система охлаждения",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Комплект сцепления LUK RepSet",
                        Price = 12999.99M,
                        Description = "Полный комплект сцепления с выжимным подшипником",
                        ImageUrl = "/images/clutch-kit.jpg",
                        Category = "Трансмиссия",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Стойки стабилизатора Lemforder",
                        Price = 899.99M,
                        Description = "Усиленные стойки стабилизатора для лучшей управляемости",
                        ImageUrl = "/images/stabilizer-links.jpg",
                        Category = "Подвеска",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Топливный насос Bosch",
                        Price = 4999.99M,
                        Description = "Электрический топливный насос высокой производительности",
                        ImageUrl = "/images/fuel-pump.jpg",
                        Category = "Топливная система",
                        InStock = true
                    },
                    new Product 
                    { 
                        Name = "Катушка зажигания Denso",
                        Price = 2499.99M,
                        Description = "Высоковольтная катушка зажигания с улучшенными характеристиками",
                        ImageUrl = "/images/ignition-coil.jpg",
                        Category = "Система зажигания",
                        InStock = true
                    }
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
} 