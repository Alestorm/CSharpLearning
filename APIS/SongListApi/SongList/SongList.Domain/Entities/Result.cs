using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Domain.Entities
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