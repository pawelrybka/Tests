namespace SuperHeroAPI.Services.SuperHeroService

{
    public interface ISuperHeroService
    {
        List<SuperHero> ReadAllHeroes();
        SuperHero? ReadSingleHero(int id);
        List<SuperHero> CreateHero(SuperHero hero);
        List<SuperHero>? UpdateHero(int id, SuperHero request);
        List<SuperHero>? DeleteHero(int id);
    }
}
