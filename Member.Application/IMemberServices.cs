using System.Collections.Generic;
using Member.Domain;

namespace Member.ApplicationLayer
{
    public interface IMemberServices
    {
        //This interface is use for Bussiness Rule / USE CASE
        List<Domain.Member> GetAllMembers();
    }
}
