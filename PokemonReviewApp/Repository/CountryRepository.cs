using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public bool CountryExists(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Country> GetCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Owner> GetOwnersFromCountry(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
