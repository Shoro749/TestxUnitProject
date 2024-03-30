using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestxUnitProject
{
    public static class UserValidation
    {
        public static bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
            return !name.Any(char.IsDigit);
        }

        public static bool IsLoginValid(string name)
        {
            throw new NotImplementedException();
        }

        public static bool IsPasswordValid(string name)
        {
            throw new NotImplementedException();
        }
    }
}
