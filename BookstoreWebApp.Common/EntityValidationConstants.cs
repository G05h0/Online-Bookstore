using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWebApp.Common
{
    public static class EntityValidationConstants
    {
        public static class BookEntityValidations
        {
            public const int TitleMaxLenght = 3800;
            public const int AuthorMaxLenght = 10;
            public const int GenreMaxLenght = 10;
            public const int PagesMaxLenght = 22000;
            public const int DescriptionMaxLenght = 1000;
        }

        public static class AuthorEntityValidations
        {
            public const int NameMaxLenght = 10;
            public const int BiographyMaxLenght = 2000;

        }
    }
}
