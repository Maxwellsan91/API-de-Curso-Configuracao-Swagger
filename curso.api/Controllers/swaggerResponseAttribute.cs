using System;

namespace curso.api.Controllers
{
    internal class swaggerResponseAttribute : Attribute
    {
        private int statusCode;
        private string description;

        public swaggerResponseAttribute(int StatusCode, string description)
        {
            statusCode = StatusCode;
            this.description = description;
        }
    }
}