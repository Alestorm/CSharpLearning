namespace ClientAccountApi.Domain.Models
{
    public class Result<T>
    {
        public T Value { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSuccess => ErrorMessage == null;

        public static Result<T> Success(T value)
        {
            return new Result<T> { Value = value };
        }
        public static Result<T> Failure(string errorMessage)
        {
            return new Result<T> { ErrorMessage = errorMessage };
        }
    }
}