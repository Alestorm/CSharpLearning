namespace MoviesApi.Domain.Contracts
{
    public interface IRating
    {
        Rating AddRating(int idMovie, double rating);
    }
}
