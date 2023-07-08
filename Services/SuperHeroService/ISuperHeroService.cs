namespace SuperHeroAPI.Services.SuperHeroService

{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> ReadAllHeroes();
        Task<SuperHero?> ReadSingleHero(int id);
        Task<List<SuperHero>> CreateHero(SuperHero hero);
        Task<List<SuperHero>?> UpdateHero(int id, SuperHero request);
        Task<List<SuperHero>?> DeleteHero(int id);
    }
}
