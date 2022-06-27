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
                new Zombie { Id = 1, Point = 5, ForceLevelId = 8, ShortDesc = "Pirate des Caraibes", Name = "LeChuck", ZombieTypeId = 1 },
                new Zombie { Id = 2, Point = 4, ForceLevelId = 6, ShortDesc = "Cute Little Dead Girl", Name = "Lenore", ZombieTypeId = 2 },
                new Zombie { Id = 3, Point = 8, ForceLevelId = 4, ShortDesc = "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", Name = "Baron Samedi", ZombieTypeId = 2 },
                new Zombie { Id = 4, Point = 2, ForceLevelId = 9, ShortDesc = "Vivant dans sa tombe grandant son trésor", Name = "Draugr", ZombieTypeId = 3 },
                new Zombie { Id = 5, Point = 5, ForceLevelId = 4, ShortDesc = "Ancien vampire transformé en poupée de chiffon, ami de Lenore", Name = "Ragamuffin ", ZombieTypeId = 2 },
                new Zombie { Id = 6, Point = 6, ForceLevelId = 3, ShortDesc = "Tête de sac avec yeux en boutons, amoureux de Lenore", Name = "Mr Gosh", ZombieTypeId = 1 },
                new Zombie { Id = 7, Point = 1, ForceLevelId = 1, ShortDesc = "Tête de cerf empaillé, voisin de Lenore", Name = "Taxidermy ", ZombieTypeId = 3 },
                new Zombie { Id = 8, Point = 3, ForceLevelId = 9, ShortDesc = "Chat mort de Lenore", Name = "Kitty", ZombieTypeId = 1 },
                new Zombie { Id = 9, Point = 2, ForceLevelId = 3, ShortDesc = "Voleur très rapide", Name = "Singe zombie", ZombieTypeId = 3 },
                new Zombie { Id = 10, Point = 7, ForceLevelId = 5, ShortDesc = "chien très rapide, pouvant être enflammé", Name = "chien de l'enfer", ZombieTypeId = 3 },
                new Zombie { Id = 11, Point = 9, ForceLevelId = 9, ShortDesc = "Attaque avec des éclairs suite à un orage", Name = "Avogadro", ZombieTypeId = 3 },
                new Zombie { Id = 12, Point = 6, ForceLevelId = 9, ShortDesc = "", Name = "Lady Rose", ZombieTypeId = 3 },
                new Zombie { Id = 13, Point = 2, ForceLevelId = 10, ShortDesc = "Jeune étudiante qui cherche son professeur pour se venger", Name = "Matbeth", ZombieTypeId = 2 },
                new Zombie { Id = 14, Point = 5, ForceLevelId = 2, ShortDesc = "Le clown malheureux qui court après les enfants", Name = "The Clown", ZombieTypeId = 3 },
                new Zombie { Id = 15, Point = 4, ForceLevelId = 5, ShortDesc = "Le comptable mécontent qui cherche les failles", Name = "Clicker", ZombieTypeId = 2 },
                new Zombie { Id = 16, Point = 10, ForceLevelId = 9, ShortDesc = "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", Name = "TeamsZombie", ZombieTypeId = 3 },
                new Zombie { Id = 17, Point = 4, ForceLevelId = 7, ShortDesc = "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", Name = "Mathilde", ZombieTypeId = 3 }
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
