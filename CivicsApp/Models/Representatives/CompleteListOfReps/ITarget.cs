using System;
using System.Collections.Generic;

namespace CivicsApp.Models.Representatives.CompleteListOfReps
{
    public interface ITarget
    {
        public List<Representative> ReturnListOfHouseMembers(ListOfHouseMembers deserializeClass);
    }
}
