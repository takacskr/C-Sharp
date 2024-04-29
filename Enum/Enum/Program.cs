using System.Threading.Channels;
using static Enum.Program;

namespace Enum
{
    internal class Program
    {
        public enum FailMessages
        {
            InvalidInput,
            InvalidUsername,
            InvalidPassword,
            InvalidEmail,
            InvalidPhoneNumber,
            InvalidAddress,
            InvalidCity,
            InvalidState = 404,
            InvalidZipCode,
            InvalidCountry
        }

        static void Main(string[] args)
        {
            List<FailMessages> failMessages = new List<FailMessages>();

            failMessages.Add(FailMessages.InvalidInput);
            failMessages.Add(FailMessages.InvalidUsername);
            failMessages.Add(FailMessages.InvalidPassword);

            failMessages.ForEach(m => Console.WriteLine(m));

            Console.WriteLine(404 == (int)FailMessages.InvalidState);
        }
    }
}
