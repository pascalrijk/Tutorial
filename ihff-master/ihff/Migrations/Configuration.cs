namespace ihff.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using ihff.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ihff.Models.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ihff.Models.DBContext context)
        {
            context.Movies.AddOrUpdate(
                   new Movie
                   {
                       Id = 1,
                       Name = "Primer",
                       Description = "Four friends/fledgling entrepreneurs, knowing that there's something bigger and more innovative than the different error-checking devices they've built, wrestle over their new invention.",
                       Image = "primer.jpg",
                       Price = 7.50M,
                       Runtime = 77,
                       Type = "movie",
                       Year = 2004,
                       Trailer = ""
                   },
                   new Movie
                   {
                       Id = 2,
                       Name = "Solaris",
                       Description = "A psychologist is sent to a station orbiting a distant planet in order to discover what has caused the crew to go insane.",
                       Image = "solaris.jpg",
                       Price = 7.50M,
                       Runtime = 167,
                       Type = "movie",
                       Year = 1972,
                       Trailer = ""
                   },
                   new Movie
                   {
                       Id = 3,
                       Name = "eXistenZ",
                       Description = "A game designer on the run from assassins must play her latest virtual reality creation with a marketing trainee to determine if the game has been damaged.",
                       Image = "existenz.jpg",
                       Price = 7.50M,
                       Runtime = 97,
                       Type = "movie",
                       Year = 1999,
                       Trailer = ""
                   },
                   new Movie { Id = 4, Name = "Paprika", Description = "When a machine that allows therapists to enter their patients' dreams is stolen, all hell breaks loose. Only a young female therapist can stop it: Paprika.", Image = "paprika.jpg", Price = 7.50M, Runtime = 90, Type = "movie", Year = 2006, Trailer = "" },
                   new Movie { Id = 5, Name = "THX 1138", Description = "Set in the 25th century, the story centers around a man and a woman who rebel against their rigidly controlled society.", Image = "thx_1138.jpg", Price = 7.50M, Runtime = 86, Type = "movie", Year = 1971, Trailer = "" },
                   new Movie { Id = 6, Name = "Wall-E", Description = "In the distant future, a small waste collecting robot inadvertently embarks on a space journey that will ultimately decide the fate of mankind.", Image = "wall_e.jpg", Price = 7.50M, Runtime = 98, Type = "movie", Year = 2008, Trailer = "" },
                   new Movie { Id = 7, Name = "Brazil", Description = "A bureaucrat in a retro-future world tries to correct an administrative error and himself becomes an enemy of the state.", Image = "brazil.jpg", Price = 7.50M, Runtime = 132, Type = "movie", Year = 1985, Trailer = "" },
                   new Movie { Id = 8, Name = "2001: A Space Odyssey", Description = "Humanity finds a mysterious, obviously artificial, object buried beneath the Lunar surface and, with the intelligent computer H.A.L. 9000, sets off on a quest.", Image = "a_space_odyssey.jpg", Price = 7.50M, Runtime = 149, Type = "movie", Year = 2004, Trailer = "" },
                   new Movie { Id = 9, Name = "Interstellar", Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", Image = "interstellar.jpg", Price = 7.50M, Runtime = 169, Type = "movie", Year = 2014, Trailer = "" },
                   new Movie { Id = 10, Name = "Ghost in the Shell", Description = "A female cyborg cop and her partner hunt a mysterious and powerful hacker called the Puppet Master.", Image = "ghost_in_the_shell.jpg", Price = 7.50M, Runtime = 83, Type = "movie", Year = 1995, Trailer = "" },
                   new Movie { Id = 11, Name = "Computer Chess", Description = "A 1980s-set story centered around a man vs. machine chess tournament.", Image = "computer_chess.jpg", Price = 7.50M, Runtime = 92, Type = "movie", Year = 2013, Trailer = "" },
                   new Movie { Id = 12, Name = "TPB AFK: The Pirate Bay Away from Keyboard", Description = "An intellectual freedoms documentary based around the interpersonal triumphs, and defeats of the three main characters against the largest industry in the known universe. The media industry.", Image = "the_pirate_bay.jpg", Price = 7.50M, Runtime = 85, Type = "movie", Year = 2013, Trailer = "" },
                   new Movie { Id = 13, Name = "The Rise and Rise of Bitcoin", Description = "A computer programmer becomes fascinated with the digital currency Bitcoin, and through his involvement in the Bitcoin community, we learn about the impending global impact of this amazing new technology.", Image = "rise_of_bitcoin.jpg", Price = 7.50M, Runtime = 96, Type = "movie", Year = 2014, Trailer = "" },
                   new Movie { Id = 14, Name = "The Internet's Own Boy: The Story of Aaron Swartz", Description = "The story of programming prodigy and information activist Aaron Swartz, who took his own life at the age of 26.", Image = "aarin_swartz.jpg", Price = 7.50M, Runtime = 105, Type = "movie", Year = 2014, Trailer = "" },
                   new Movie { Id = 15, Name = "Her", Description = "A lonely writer develops an unlikely relationship with his newly purchased operating system that's designed to meet his every need.", Image = "her.jpg", Price = 7.50M, Runtime = 126, Type = "movie", Year = 2013, Trailer = "" },
                   new Movie { Id = 16, Name = "Gravity", Description = "A medical engineer and an astronaut work together to survive after a catastrophe destroys their shuttle and leaves them adrift in orbit.", Image = "gravity.jpg", Price = 7.50M, Runtime = 91, Type = "movie", Year = 2013, Trailer = "" },
                   new Movie { Id = 17, Name = "Ex Machina", Description = "A young programmer is selected to participate in a ground- breaking experiment in artificial intelligence by evaluating the human qualities of a breath-taking female A.I.", Image = "ex_machina.jpg", Price = 7.50M, Runtime = 108, Type = "movie", Year = 2015, Trailer = "" },
                   new Movie { Id = 18, Name = "Chappie", Description = "In the near future, crime is patrolled by a mechanized police force. When one police droid, Chappie, is stolen and given new programming, he becomes the first robot with the ability to think and feel for himself.", Image = "chappie.jpg", Price = 7.50M, Runtime = 120, Type = "movie", Year = 2015, Trailer = "" },
                   new Movie { Id = 19, Name = "A.I. Artificial Intelligence", Description = "A highly advanced robotic boy longs to become \"real\" so that he can regain the love of his human mother.", Image = "artificial_intelligence.jpg", Price = 7.50M, Runtime = 146, Type = "movie", Year = 2001, Trailer = "" },
                   new Movie { Id = 20, Name = "Minority Report", Description = "In a future where a special police unit is able to arrest murderers before they commit their crimes, an officer from that unit is himself accused of a future murder.", Image = "minority_report.jpg", Price = 7.50M, Runtime = 145, Type = "movie", Year = 2002, Trailer = "" },
                   new Movie { Id = 21, Name = "The Triumph of the Nerds: The Rise of Accidental Empires", Description = "Three part documentary that shows the insight look at the history of computers, from its rise in the 1970s to the beginning of the Dot-com boom of the late 1990s.", Image = "triumph_of_nerds.jpg", Price = 7.50M, Runtime = 150, Type = "movie", Year = 1996, Trailer = "" },
                   new Movie { Id = 22, Name = "Robot & Frank", Description = "Set in the near future, an ex-jewel thief receives a gift from his son: a robot butler programmed to look after him. But soon the two companions try their luck as a heist team", Image = "robot_and_frank.jpg", Price = 7.50M, Runtime = 89, Type = "movie", Year = 2012, Trailer = "" },
                   new Movie { Id = 23, Name = "Moon", Description = "Astronaut Sam Bell has a quintessentially personal encounter toward the end of his three-year stint on the Moon, where he, working alongside his computer, GERTY, sends back to Earth parcels of a resource that has helped diminish our planet's power problems.", Image = "moon.jpg", Price = 7.50M, Runtime = 97, Type = "movie", Year = 2009, Trailer = "" }
            );

            context.Locations.AddOrUpdate(
                new Location { Id = 1, Name = "Philharmonie Haarlem", Address = "Lange Begijnestraat 11", PostalCode = "2011 HH", City = "Haarlem" },
                new Location { Id = 2, Name = "Toneelschuur", Address = "Lange Begijnestraat 9", PostalCode = "2011 HH", City = "Haarlem" },
                new Location { Id = 3, Name = "Patronaat", Address = "Zijlsingel 2", PostalCode = "2013 DN", City = "Haarlem" },
                new Location { Id = 4, Name = "Pathe", Address = "Zijlvest 41-43", PostalCode = "2011 VB", City = "Haarlem" },
                new Location { Id = 5, Name = "Stempels Brasserie", Address = "Klokhuisstraat 9", PostalCode = "2011 HK", City = "Haarlem" },
                new Location { Id = 6, Name = "De Ark", Address = "Nieuw Heiligland 3", PostalCode = "2011 EM", City = "Haarlem" },
                new Location { Id = 7, Name = "Dijkers", Address = "Warmoestraat 5-7", PostalCode = "2011 HN", City = "Haarlem" },
                new Location { Id = 8, Name = "De Uitkijk", Address = "Hoge duin en daalseweg", PostalCode = "2061 AD", City = "Bloemendaal" },
                new Location { Id = 9, Name = "Ratatouille Food & Wine", Address = "Lange veerstraat 11-13", PostalCode = "2011 DA", City = "Haarlem" },
                new Location { Id = 10, Name = "Restaurant Terra", Address = "Kerkplein 16a", PostalCode = "2061 JD", City = "Bloemendaal" }
            );

            context.Rooms.AddOrUpdate(
                new Room { Id = 1, Name = "Van Beinum zaal", LocationId = 1, Capacity = 150 },
                new Room { Id = 2, Name = "Artiesten Foyer", LocationId = 1, Capacity = 70 },
                new Room { Id = 3, Name = "Filmzaal-1", LocationId = 2, Capacity = 75 },
                new Room { Id = 4, Name = "Filmzaal-2", LocationId = 2, Capacity = 110 },
                new Room { Id = 5, Name = "Kleine zaal", LocationId = 3, Capacity = 250 },
                new Room { Id = 6, Name = "Zaal 1", LocationId = 4, Capacity = 260 },
                new Room { Id = 7, Name = "Zaal 9", LocationId = 4, Capacity = 120 },
                new Room { Id = 8, Name = "Zaal 13", LocationId = 4, Capacity = 90 }
            );

            context.Speakers.AddOrUpdate(
                new Speaker { Id = 1, FirstName = "Hans", LastName = "Groenendijk" },
                new Speaker { Id = 2, FirstName = "Frank", LastName = "Lammers" },
                new Speaker { Id = 3, FirstName = "Susan", LastName = "Visser" },
                new Speaker { Id = 4, FirstName = "Tygo", LastName = "Gernandt" },
                new Speaker { Id = 5, FirstName = "Thony", LastName = "Zhou" },
                new Speaker { Id = 6, FirstName = "Marleen", LastName = "Gorris" },
                new Speaker { Id = 7, FirstName = "Tom", LastName = "Fassaert" },
                new Speaker { Id = 8, FirstName = "Felix", LastName = "van Groeningen" },
                new Speaker { Id = 9, FirstName = "Paul", LastName = "Driessen" },
                new Speaker { Id = 10, FirstName = "Tamar", LastName = "van den Dop" }
            );

            context.Specials.AddOrUpdate(
                new Special { Id = 24, Name = "De erfenis van Louis H. Chrispijn", SpeakerId = 1, Type = "special", Image = "hans_groenendijk.jpg", Price = 0M },
                new Special { Id = 25, Name = "Haarlem Film set", SpeakerId = 2, Type = "special", Image = "frank_lammers.jpg", Price = 0M },
                new Special { Id = 26, Name = "AIVD - De wolf in schaapskleren", Description = "Discussieforum onder leiding van actrice Susan Visser.", SpeakerId = 3, Type = "special", Image = "susan_visser.jpg", Price = 0M },
                new Special { Id = 27, Name = "Bloot uit nood of ...", SpeakerId = 4, Type = "special", Image = "tygo_gernandt.jpg", Price = 0M },
                new Special { Id = 28, Name = "The poetry of details", SpeakerId = 5, Type = "special", Image = "thony_zhou.jpg", Price = 0M },
                new Special { Id = 29, Name = "Hollywood tijdens de crisis v.d. vorige eeuw", SpeakerId = 6, Type = "special", Image = "marleen_gorris.jpg", Price = 0M },
                new Special { Id = 30, Name = "Wat is film?", SpeakerId = 7, Type = "special", Image = "tom_fassaert.jpg", Price = 0M },
                new Special { Id = 31, Name = "Broken circle", SpeakerId = 8, Type = "special", Image = "felix_van_groeningen.jpg", Price = 0M },
                new Special { Id = 32, Name = "Timboektoe", SpeakerId = 9, Type = "special", Image = "paul_driessen.jpg", Price = 0M },
                new Special { Id = 33, Name = "De kleur van Sneeuw", SpeakerId = 10, Type = "special", Image = "tamar_vd_dop.jpg", Price = 0M }
            );

            context.Restaurants.AddOrUpdate(
                new Restaurant { Id = 34, Name = "Stempels Brasserie", Description = "", Image = "stempels_brasserie.jpg", Price = 10.00M, Type = "restaurant", Capacity = 35, LocationId = 5 },
                new Restaurant { Id = 35, Name = "De Ark", Description = "", Image = "de_ark.jpg", Price = 10.00M, Type = "restaurant", Capacity = 50, LocationId = 6 },
                new Restaurant { Id = 36, Name = "Dijkers", Description = "", Image = "dijkers.jpg", Price = 10.00M, Type = "restaurant", Capacity = 42, LocationId = 7 },
                new Restaurant { Id = 37, Name = "De Uitkijk", Description = "", Image = "de_uitkijk.jpg", Price = 10.00M, Type = "restaurant", Capacity = 60, LocationId = 8 },
                new Restaurant { Id = 38, Name = "Ratatouille Food & Wine", Description = "", Image = "ratatouille_food_wine.jpg", Price = 10.00M, Type = "restaurant", Capacity = 18, LocationId = 9 },
                new Restaurant { Id = 39, Name = "Restaurant Terra", Description = "", Image = "restaurant_terra.jpg", Price = 10.00M, Type = "restaurant", Capacity = 40, LocationId = 10 }
            );

            context.Shows.AddOrUpdate(
                // Specials
                new Show { ActivityId = 24, LocationId = 3, RoomId = 5, Day = DayOfWeek.Wednesday, Start = new TimeSpan(14,0,0), End = new TimeSpan(15,30,0) },
                new Show { ActivityId = 25, LocationId = 1, RoomId = 2, Day = DayOfWeek.Wednesday, Start = new TimeSpan(18,0,0), End = new TimeSpan(19,0,0) },
                new Show { ActivityId = 26, LocationId = 3, RoomId = 5, Day = DayOfWeek.Thursday, Start = new TimeSpan(18,0,0), End = new TimeSpan(19,30,0) },
                new Show { ActivityId = 27, LocationId = 1, RoomId = 2, Day = DayOfWeek.Thursday, Start = new TimeSpan(22,0,0), End = new TimeSpan(23,0,0) },
                new Show { ActivityId = 28, LocationId = 1, RoomId = 2, Day = DayOfWeek.Friday, Start = new TimeSpan(17,0,0), End = new TimeSpan(18,30,0) },
                new Show { ActivityId = 29, LocationId = 3, RoomId = 5, Day = DayOfWeek.Friday, Start = new TimeSpan(15,0,0), End = new TimeSpan(16,30,0) },
                new Show { ActivityId = 30, LocationId = 3, RoomId = 5, Day = DayOfWeek.Saturday, Start = new TimeSpan(16,0,0), End = new TimeSpan(17,0,0) },
                new Show { ActivityId = 31, LocationId = 1, RoomId = 2, Day = DayOfWeek.Saturday, Start = new TimeSpan(14,0,0), End = new TimeSpan(15,30,0) },
                new Show { ActivityId = 32, LocationId = 1, RoomId = 2, Day = DayOfWeek.Sunday, Start = new TimeSpan(17,0,0), End = new TimeSpan(19,0,0) },
                new Show { ActivityId = 33, LocationId = 3, RoomId = 5, Day = DayOfWeek.Sunday, Start = new TimeSpan(16,0,0), End = new TimeSpan(17,30,0) },

                // Movies
                new Show { ActivityId = 5, LocationId = 4, RoomId = 6, Day = DayOfWeek.Wednesday, Start = new TimeSpan(14,30,0), End = new TimeSpan(16,45,0) },
                new Show { ActivityId = 23, LocationId = 4, RoomId = 8, Day = DayOfWeek.Wednesday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 7, LocationId = 2, RoomId = 4, Day = DayOfWeek.Wednesday, Start = new TimeSpan(15,0,0), End = new TimeSpan(18,0,0) },
                new Show { ActivityId = 20, LocationId = 1, RoomId = 1, Day = DayOfWeek.Wednesday, Start = new TimeSpan(13,0,0), End = new TimeSpan(15,30,0) },
                new Show { ActivityId = 3, LocationId = 4, RoomId = 7, Day = DayOfWeek.Wednesday, Start = new TimeSpan(19,0,0), End = new TimeSpan(21,0,0) },
                new Show { ActivityId = 9, LocationId = 4, RoomId = 8, Day = DayOfWeek.Wednesday, Start = new TimeSpan(19,30,0), End = new TimeSpan(22,0,0) },
                new Show { ActivityId = 8, LocationId = 2, RoomId = 3, Day = DayOfWeek.Wednesday, Start = new TimeSpan(19,0,0), End = new TimeSpan(22,30,0) },

                new Show { ActivityId = 17, LocationId = 4, RoomId = 8, Day = DayOfWeek.Thursday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 18, LocationId = 1, RoomId = 1, Day = DayOfWeek.Thursday, Start = new TimeSpan(17,0,0), End = new TimeSpan(20,0,0) },
                new Show { ActivityId = 15, LocationId = 4, RoomId = 8, Day = DayOfWeek.Thursday, Start = new TimeSpan(18,0,0), End = new TimeSpan(20,30,0) },
                new Show { ActivityId = 23, LocationId = 4, RoomId = 7, Day = DayOfWeek.Thursday, Start = new TimeSpan(14,30,0), End = new TimeSpan(16,30,0) },
                new Show { ActivityId = 16, LocationId = 4, RoomId = 6, Day = DayOfWeek.Thursday, Start = new TimeSpan(16,0,0), End = new TimeSpan(18,30,0) },
                new Show { ActivityId = 11, LocationId = 4, RoomId = 7, Day = DayOfWeek.Thursday, Start = new TimeSpan(17,30,0), End = new TimeSpan(20,30,0) },
                new Show { ActivityId = 19, LocationId = 4, RoomId = 6, Day = DayOfWeek.Thursday, Start = new TimeSpan(16,30,0), End = new TimeSpan(19,30,0) },
                new Show { ActivityId = 20, LocationId = 4, RoomId = 8, Day = DayOfWeek.Thursday, Start = new TimeSpan(21,30,0), End = new TimeSpan(23,30,0) },
                new Show { ActivityId = 10, LocationId = 2, RoomId = 3, Day = DayOfWeek.Thursday, Start = new TimeSpan(14,0,0), End = new TimeSpan(18,0,0) },
                new Show { ActivityId = 5, LocationId = 2, RoomId = 4, Day = DayOfWeek.Thursday, Start = new TimeSpan(20,0,0), End = new TimeSpan(22,30,0) },
                new Show { ActivityId = 2, LocationId = 2, RoomId = 3, Day = DayOfWeek.Thursday, Start = new TimeSpan(19,0,0), End = new TimeSpan(22,30,0) },

                new Show { ActivityId = 22, LocationId = 1, RoomId = 1, Day = DayOfWeek.Friday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 12, LocationId = 1, RoomId = 1, Day = DayOfWeek.Friday, Start = new TimeSpan(18,30,0), End = new TimeSpan(21,0,0) },
                new Show { ActivityId = 19, LocationId = 4, RoomId = 7, Day = DayOfWeek.Friday, Start = new TimeSpan(14,0,0), End = new TimeSpan(16,30,0) },
                new Show { ActivityId = 11, LocationId = 4, RoomId = 7, Day = DayOfWeek.Friday, Start = new TimeSpan(20,30,0), End = new TimeSpan(22,30,0) },
                new Show { ActivityId = 10, LocationId = 4, RoomId = 8, Day = DayOfWeek.Friday, Start = new TimeSpan(14,0,0), End = new TimeSpan(17,0,0) },
                new Show { ActivityId = 13, LocationId = 4, RoomId = 8, Day = DayOfWeek.Friday, Start = new TimeSpan(18,0,0), End = new TimeSpan(20,30,0) },
                new Show { ActivityId = 14, LocationId = 4, RoomId = 6, Day = DayOfWeek.Friday, Start = new TimeSpan(16,30,0), End = new TimeSpan(19,30,0) },
                new Show { ActivityId = 4, LocationId = 2, RoomId = 3, Day = DayOfWeek.Friday, Start = new TimeSpan(21,30,0), End = new TimeSpan(23,30,0) },
                new Show { ActivityId = 7, LocationId = 2, RoomId = 4, Day = DayOfWeek.Friday, Start = new TimeSpan(18,0,0), End = new TimeSpan(20,0,0) },
                new Show { ActivityId = 1, LocationId = 2, RoomId = 4, Day = DayOfWeek.Friday, Start = new TimeSpan(21,0,0), End = new TimeSpan(23,0,0) },

                new Show { ActivityId = 21, LocationId = 1, RoomId = 1, Day = DayOfWeek.Saturday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 17, LocationId = 1, RoomId = 1, Day = DayOfWeek.Saturday, Start = new TimeSpan(18,0,0), End = new TimeSpan(21,0,0) },
                new Show { ActivityId = 5, LocationId = 4, RoomId = 7, Day = DayOfWeek.Saturday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 22, LocationId = 4, RoomId = 7, Day = DayOfWeek.Saturday, Start = new TimeSpan(20,0,0), End = new TimeSpan(22,0,0) },
                new Show { ActivityId = 18, LocationId = 4, RoomId = 8, Day = DayOfWeek.Saturday, Start = new TimeSpan(14,30,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 23, LocationId = 4, RoomId = 8, Day = DayOfWeek.Saturday, Start = new TimeSpan(16,0,0), End = new TimeSpan(18,30,0) },
                new Show { ActivityId = 15, LocationId = 4, RoomId = 6, Day = DayOfWeek.Saturday, Start = new TimeSpan(17,0,0), End = new TimeSpan(19,30,0) },
                new Show { ActivityId = 8, LocationId = 2, RoomId = 3, Day = DayOfWeek.Saturday, Start = new TimeSpan(21,30,0), End = new TimeSpan(23,30,0) },
                new Show { ActivityId = 9, LocationId = 2, RoomId = 4, Day = DayOfWeek.Saturday, Start = new TimeSpan(18,0,0), End = new TimeSpan(20,0,0) },

                new Show { ActivityId = 13, LocationId = 1, RoomId = 1, Day = DayOfWeek.Sunday, Start = new TimeSpan(16,0,0), End = new TimeSpan(17,45,0) },
                new Show { ActivityId = 23, LocationId = 1, RoomId = 1, Day = DayOfWeek.Sunday, Start = new TimeSpan(18,0,0), End = new TimeSpan(21,0,0) },
                new Show { ActivityId = 3, LocationId = 2, RoomId = 3, Day = DayOfWeek.Sunday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 5, LocationId = 2, RoomId = 4, Day = DayOfWeek.Sunday, Start = new TimeSpan(16,0,0), End = new TimeSpan(18,0,0) },
                new Show { ActivityId = 22, LocationId = 4, RoomId = 7, Day = DayOfWeek.Sunday, Start = new TimeSpan(15,0,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 16, LocationId = 4, RoomId = 7, Day = DayOfWeek.Sunday, Start = new TimeSpan(20,0,0), End = new TimeSpan(22,0,0) },
                new Show { ActivityId = 20, LocationId = 4, RoomId = 8, Day = DayOfWeek.Sunday, Start = new TimeSpan(14,30,0), End = new TimeSpan(17,30,0) },
                new Show { ActivityId = 12, LocationId = 4, RoomId = 8, Day = DayOfWeek.Sunday, Start = new TimeSpan(16,0,0), End = new TimeSpan(18,30,0) },
                new Show { ActivityId = 9, LocationId = 4, RoomId = 6, Day = DayOfWeek.Sunday, Start = new TimeSpan(17,0,0), End = new TimeSpan(19,30,0) },
                new Show { ActivityId = 4, LocationId = 2, RoomId = 3, Day = DayOfWeek.Sunday, Start = new TimeSpan(18,30,0), End = new TimeSpan(21,30,0) },
                new Show { ActivityId = 21, LocationId = 2, RoomId = 4, Day = DayOfWeek.Sunday, Start = new TimeSpan(17,0,0), End = new TimeSpan(19,30,0) },
                new Show { ActivityId = 7, LocationId = 2, RoomId = 3, Day = DayOfWeek.Sunday, Start = new TimeSpan(22,0,0), End = new TimeSpan(0,30,0) },
                new Show { ActivityId = 1, LocationId = 2, RoomId = 4, Day = DayOfWeek.Sunday, Start = new TimeSpan(20,30,0), End = new TimeSpan(23,30,0) }
            );
        }
    }
}
