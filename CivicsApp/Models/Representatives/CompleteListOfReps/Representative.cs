using System;
namespace CivicsApp.Models.Representatives.CompleteListOfReps
{
    public class Representative
    {
        public Representative(string firstName)
        {
            FirstName = firstName;
        }

        public string FirstName { get; set; }
    }
}
