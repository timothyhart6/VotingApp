using System;
namespace CivicsApp.Models.Senators.Senator
{
    public class SenatorAdapter
    {
        public Senator ConvertToSenatorObject(SenateResult ProPublicaSenator)
        {
            Senator Senator = new Senator();

            Senator.FirstName = ProPublicaSenator.FirstName;
            Senator.LastName = ProPublicaSenator.LastName;

            return Senator;
        }
    }
}
