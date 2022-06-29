using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_Models;

namespace ZombieParty_DataAccess.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {

            #region Zombie
            builder.Entity<Zombie>().HasData(
                new Zombie { Id = 1, Point = 5, ForceLevelId = 8, ShortDesc = "Pirate des Caraibes", Name = "LeChuck", ZombieTypeId = 1, Image =""},
                new Zombie { Id = 2, Point = 4, ForceLevelId = 6, ShortDesc = "Cute Little Dead Girl", Name = "Lenore", ZombieTypeId = 2, Image = "c7be9999-3b37-4d97-a131-914a4d15009a.png" },
                new Zombie { Id = 3, Point = 8, ForceLevelId = 4, ShortDesc = "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", Name = "Baron Samedi", ZombieTypeId = 2, Image = "02cdda86-0430-465a-acf5-d7ae3679bf97.png" },
                new Zombie { Id = 4, Point = 2, ForceLevelId = 9, ShortDesc = "Vivant dans sa tombe grandant son trésor", Name = "Draugr", ZombieTypeId = 3, Image = "8b2eaef1-45c3-4b32-9a6a-80173ceafd3b.png" },
                new Zombie { Id = 5, Point = 5, ForceLevelId = 4, ShortDesc = "Ancien vampire transformé en poupée de chiffon, ami de Lenore", Name = "Ragamuffin ", ZombieTypeId = 2, Image = "9bf4cadc-8d64-4aa5-b3b9-a481460e69b5.png" },
                new Zombie { Id = 6, Point = 6, ForceLevelId = 3, ShortDesc = "Tête de sac avec yeux en boutons, amoureux de Lenore", Name = "Mr Gosh", ZombieTypeId = 1, Image = "8b3e0771-da5a-4890-aad2-4eb5d91a38c2.png" },
                new Zombie { Id = 7, Point = 1, ForceLevelId = 1, ShortDesc = "Tête de cerf empaillé, voisin de Lenore", Name = "Taxidermy ", ZombieTypeId = 3, Image = "d8ffd3ac-79ef-4a9e-8287-9171acb3744c.png" },
                new Zombie { Id = 8, Point = 3, ForceLevelId = 9, ShortDesc = "Chat mort de Lenore", Name = "Kitty", ZombieTypeId = 1, Image = "548bb040-9748-43f0-98f6-64e4e3ae7b80.png" },
                new Zombie { Id = 9, Point = 2, ForceLevelId = 3, ShortDesc = "Voleur très rapide", Name = "Singe zombie", ZombieTypeId = 3, Image = "4dab96ad-a1cc-44b3-99f5-804d4e5fac81.png" },
                new Zombie { Id = 10, Point = 7, ForceLevelId = 5, ShortDesc = "chien très rapide, pouvant être enflammé", Name = "chien de l'enfer", ZombieTypeId = 3, Image = "5efefdf4-26c9-490e-b038-11b3e51af2c1.png" },
                new Zombie { Id = 11, Point = 9, ForceLevelId = 9, ShortDesc = "Attaque avec des éclairs suite à un orage", Name = "Avogadro", ZombieTypeId = 3, Image = "89935c4d-41c1-469b-87f2-ca588af035c5.png" },
                new Zombie { Id = 12, Point = 6, ForceLevelId = 9, ShortDesc = "", Name = "Lady Rose", ZombieTypeId = 3, Image = "0c3c00b8-463e-4a8e-ac1a-639c1293b06d.png" },
                new Zombie { Id = 13, Point = 2, ForceLevelId = 10, ShortDesc = "Jeune étudiante qui cherche son professeur pour se venger", Name = "Matbeth", ZombieTypeId = 2, Image = "d878df80-bb9f-470b-a328-a641b2c911d1.png" },
                new Zombie { Id = 14, Point = 5, ForceLevelId = 2, ShortDesc = "Le clown malheureux qui court après les enfants", Name = "The Clown", ZombieTypeId = 3, Image = "7180c597-7add-48a4-b33e-71de5d6fed7e.png" },
                new Zombie { Id = 15, Point = 4, ForceLevelId = 5, ShortDesc = "Le comptable mécontent qui cherche les failles", Name = "Clicker", ZombieTypeId = 2, Image = "97d242a7-eef2-4f88-b5ac-9dd73504284b.png" },
                new Zombie { Id = 16, Point = 10, ForceLevelId = 9, ShortDesc = "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", Name = "TeamsZombie", ZombieTypeId = 3, Image = "3c337bf8-7871-4acc-99a7-90829830c54a.png" },
                new Zombie { Id = 17, Point = 4, ForceLevelId = 7, ShortDesc = "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", Name = "Mathilde", ZombieTypeId = 3, Image = "98b6987a-c4f8-462c-9a99-e9163138fb5a.png" }
            );
            #endregion

            #region ZombieType
            builder.Entity<ZombieType>().HasData(
                new ZombieType { Id = 1, TypeName = "Contact" },
                new ZombieType { Id = 2, TypeName = "Virus" },
                new ZombieType { Id = 3, TypeName = "Chimique" },
                new ZombieType { Id = 4, TypeName = "Morsure" },
                new ZombieType { Id = 5, TypeName = "vampzombie" }
            );
            #endregion

            #region ForceLevel
            builder.Entity<ForceLevel>().HasData(
                new ForceLevel { Id = 1, ForceLevelNiv = 1 },
                new ForceLevel { Id = 2, ForceLevelNiv = 2 },
                new ForceLevel { Id = 3, ForceLevelNiv = 3 },
                new ForceLevel { Id = 4, ForceLevelNiv = 4 },
                new ForceLevel { Id = 5, ForceLevelNiv = 5 },
                new ForceLevel { Id = 6, ForceLevelNiv = 6 },
                new ForceLevel { Id = 7, ForceLevelNiv = 7 },
                new ForceLevel { Id = 8, ForceLevelNiv = 8 },
                new ForceLevel { Id = 9, ForceLevelNiv = 9 },
                new ForceLevel { Id = 10, ForceLevelNiv = 10 }
            );
            #endregion
        }
    }
}
