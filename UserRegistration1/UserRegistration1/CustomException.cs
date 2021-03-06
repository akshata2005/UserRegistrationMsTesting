using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME, INVALID_EMAIL, INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }

        private readonly ExceptionType type;
        public CustomException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
