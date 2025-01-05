using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CastingOperatorOverloading
{
    internal class USerViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static /*USerViewModel*/ explicit operator USerViewModel(User user)
        {
            string[]? names = user?.FullName?.Split(" ");
            return new USerViewModel()
            {
                Email = user?.Email,
                FirstName = names?.Length > 0 ? names[0] : string.Empty, //Defensive Code
                LastName = names?.Length > 1 ? names[1] : string.Empty //Defensive Code
            };
        }

    }
}
