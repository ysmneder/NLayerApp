using System;
namespace App.Services.Exceptions
{
    public class ClientSideException :Exception
    {
        public ClientSideException(string message): base(message)
        {

        }
        
    }
}

