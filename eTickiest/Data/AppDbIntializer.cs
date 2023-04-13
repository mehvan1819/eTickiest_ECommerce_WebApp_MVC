using eTickiest.Data.Enums;
using eTickiest.Models;

namespace eTickiest.Data
{
    public class AppDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinemas
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema() 
                        { 
                            Name = "CinePlex",
                            Logo = "https://www.archdaily.com/872754/how-architecture-speaks-through-cinema",
                            Description = "best cineplex"
                        },
                        new Cinema()
                        {
                            Name = "CinemaHual",
                            Logo = "https://images.pexels.com/photos/7991158/pexels-photo-7991158.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "Bigest Cinema Haul in India"
                        },
                        new Cinema()
                        {
                            Name = "BestCinema",
                            Logo = "https://images.pexels.com/photos/7991579/pexels-photo-7991579.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "Gretest Cinema our Contry India"
                        },
                        new Cinema()
                        {
                            Name = "BestTheator",
                            Logo = "https://www.archdaily.com/872754/how-architecture-speaks-through-cinema",
                            Description = "best BestTheator"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Sahid Kapoor",
                            Bio = "He is So Handsome And He is Choclate Boy!!",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bd/Shahid%2C_Alia%2C_and_Katrina_at_IIFA_2017_%28cropped%29.jpg"
                        },
                        new Actor()
                        {
                            FullName="Sharukh Khan",
                            Bio = "He is So Handsome And He is So hot!!",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6e/Shah_Rukh_Khan_graces_the_launch_of_the_new_Santro.jpg"
                        },
                        new Actor()
                        {
                            FullName="Salaman Khan",
                            Bio = "He is Handsome!!",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Nmacc-2023-0331-Salman_Khan.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Sooraj Barjatya",
                            Bio = "He is best Producer!!",
                            ProfilePictureUrl = "https://upload-wikimedia-org.translate.goog/wikipedia/commons/0/07/Sooraj_Barjatya.jpg?_x_tr_sl=en&_x_tr_tl=hi&_x_tr_hl=hi&_x_tr_pto=tc"
                        },
                        new Producer()
                        {
                            FullName="Sooraj Barjatya",
                            Bio = "He is best Producer!!",
                            ProfilePictureUrl = "https://upload-wikimedia-org.translate.goog/wikipedia/commons/0/07/Sooraj_Barjatya.jpg?_x_tr_sl=en&_x_tr_tl=hi&_x_tr_hl=hi&_x_tr_pto=tc"
                        },
                        new Producer()
                        {
                            FullName="Sooraj Barjatya",
                            Bio = "He is best Producer!!",
                            ProfilePictureUrl = "https://upload-wikimedia-org.translate.goog/wikipedia/commons/0/07/Sooraj_Barjatya.jpg?_x_tr_sl=en&_x_tr_tl=hi&_x_tr_hl=hi&_x_tr_pto=tc"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Vivah",
                            Price = 70.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Romantic,
                            ImageUrl = "https://www.google.com/search?q=vivah&rlz=1C1CHBF_enIN1050IN1050&sxsrf=APwXEdfV9cVXhmRHAY_4l0gNOi8322HMjw%3A1681383423348&ei=_983ZNTZFLPu4-EPppix6Ag&gs_ssp=eJzj4tTP1TdIMa8wTTFg9GItyyxLzAAAMD4FWQ&oq=&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQARgEMgcIIxDqAhAnMgcIIxDqAhAnMgcIIxDqAhAnMgcIIxDqAhAnMgcILhDqAhAnMgcIIxDqAhAnMgcIIxDqAhAnMgcIIxDqAhAnMgcIIxDqAhAnMgcIIxDqAhAnMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBMg0IABCPARDqAhC0AhgBOgoIABBHENYEELADOgcIIxCxAhAnOgcILhCKBRBDOgcIABCKBRBDOgcIABCABBAKSgQIQRgAUKwEWNAPYJ4faAJwAXgEgAG-AYgBqgiSAQMwLjaYAQCgAQGwARTIAQjAAQHaAQYIARABGAo&sclient=gws-wiz-serp#imgrc=Cgc6onBdvoX_fM%253A",
                            Description = "Poonam, an orphan, is engaged to Prem, who is from a wealthy family. However, two days before her wedding, she suffers from first degree burns after her house catches fire."
                        },
                        new Movie()
                        {
                            Name = "Kabhi Khushi kabhi Gam!!",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.FamilyBased,
                            ImageUrl = "https://en-m-wikipedia-org.translate.goog/wiki/Kabhi_Khushi_Kabhie_Gham...?_x_tr_sl=en&_x_tr_tl=hi&_x_tr_hl=hi&_x_tr_pto=tc",
                            Description = "Rahul, the adopted older son of a rich couple, is banished by his father when he chooses to marry a middle-class woman. Years later, his younger brother, Rohan, sets out to find him."
                        },
                        new Movie()
                        {
                            Name = "Ham sath sath hain!!",
                            Price = 60.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.FamilyBased,
                            ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcS2CoqNkCnIpvZ8E5nQG47cy7Qu-WCiJ5y5o4Ql5s0jh36_YuY1",
                            Description = "Ramkishan and Mamta lead a happy life with their three sons. But when their daughter faces a tragedy, Mamta gets instigated by her close friends, and she embitters her heart towards her stepson Vivek."
                        },
                        new Movie()
                        {
                            Name = "Hum Apake hain Kon?",
                            Price = 40.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.FamilyBased,
                            ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTUuhvQZcDOzKI8AMsXU6JZDTA_wCcSUdI-ut4nlxQoaprKVaR-",
                            Description = "When Prem meets his brother Rajesh's sister-in-law, Nisha, the two fall in love. However, fate has other plans for the lovers when Nisha's sister unexpectedly dies and she is expected to marry Rajesh."
                        },
                        new Movie()
                        {
                            Name = "kush kush hota hain!!",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.FamilyBased,
                            ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSTnj4sN-Z7wjceRoMS5kwfrh8ki7IrQca_d4guFiP0gMq-t7QC",
                            Description = "After reading the letter her mother had written for her before she died, Anjali decides to bring together her widowed father, Rahul, with his true love who is also named Anjali."
                        }
                    }); ;
                    context.SaveChanges();
                }
            }
            
        }
    }
}
