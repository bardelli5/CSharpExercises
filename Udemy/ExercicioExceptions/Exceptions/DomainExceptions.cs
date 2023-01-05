using System;

namespace Udemy.ExercicioExceptions.Exceptions
    {
    internal class DomainExceptions : ApplicationException
        {
        public DomainExceptions(string message) : base(message) 
            {
            }
        }
    }
