using Rappel_CourseVoiture.Models;

Console.WriteLine("Course de voiture");
Console.WriteLine("*****************");

Track frankForchamps = new Track("Frank For champs", 3.36);

Race grandPrixDigit = new Race("Le grand prix de Digital City 2025", 25, frankForchamps);

grandPrixDigit.AddParticipant(new Car("XC", "Audi", 100.00, 225.00), "Kevain");
grandPrixDigit.AddParticipant(new Car("Mustang5000X", "Ford", 90.00, 250.00), "Germaine");
grandPrixDigit.AddParticipant(new Car("Coccinelle", "VW", 85.00, 300.00), "Huguette");
grandPrixDigit.AddParticipant(new Car("Aventador", "Lamborghini", 110.00, 330.00), "Martin");
grandPrixDigit.AddParticipant(new Car("ModelS", "Tesla", 95.00, 310.00), "Laurent");
grandPrixDigit.AddParticipant(new Car("SupraMK4", "Toyota", 92.00, 280.00), "Olivier");
grandPrixDigit.AddParticipant(new Car("ClioRS", "Renault", 88.00, 240.00), "Cemali");
grandPrixDigit.AddParticipant(new Car("AMGGT", "Mercedes", 105.00, 320.00), "Ousmane");
grandPrixDigit.AddParticipant(new Car("MiataMX5", "Mazda", 85.00, 220.00), "Béatrice");
grandPrixDigit.AddParticipant(new Car("ImprezaWRX", "Subaru", 90.00, 260.00), "Liudmyla");
grandPrixDigit.AddParticipant(new Car("GolfGTI", "VW", 89.00, 250.00), "Kévin");
grandPrixDigit.AddParticipant(new Car("ChargerRT", "Dodge", 100.00, 290.00), "Abderrahman");
grandPrixDigit.AddParticipant(new Car("CamaroZL1", "Chevrolet", 98.00, 300.00), "Jason");
grandPrixDigit.AddParticipant(new Car("GiuliaQ", "AlfaRomeo", 94.00, 280.00), "Médéric");
grandPrixDigit.AddParticipant(new Car("CorvetteC8", "Chevrolet", 108.00, 315.00), "Dennis");
grandPrixDigit.AddParticipant(new Car("911Turbo", "Porsche", 115.00, 330.00), "Raphaël");
grandPrixDigit.AddParticipant(new Car("Up", "VW", 112.00, 325.00), "Slimane");


while (grandPrixDigit.CurrentLap <= grandPrixDigit.NbLap) { 

    grandPrixDigit.DoALap();
    
}
    Participant winner = grandPrixDigit.GetWinner();

    Console.WriteLine($"Le gagnant est : {winner.Identifiant}");

