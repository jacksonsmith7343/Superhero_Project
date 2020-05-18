using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteSuperHero_Project.Models
{
    public class Hero
    {
        public string Name { get; set; }

        public string AlterEgo { get; set; }

        public string PrimarySuperheroAbility { get; set; }

        public string SecondarySuperheroAbility { get; set; }

        public string CatchPhrase { get; set; }
    }
}
