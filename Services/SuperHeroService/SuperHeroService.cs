namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place ="New York City"
                },
                new SuperHero
                {
                    Id = 2,
                    Name = "Pulas Boy",
                    FirstName = "Marek",
                    LastName = "Falus",
                    Place ="Los Angeles"
                }
        };
        public List<SuperHero> CreateHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> ReadAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? ReadSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == request.Id);
            if (hero is null)
                return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Name = request.Name;
            hero.Place = request.Place;

            return superHeroes;
        }
    }
}
