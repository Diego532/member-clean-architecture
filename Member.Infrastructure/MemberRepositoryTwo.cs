using Member.ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Infrastructure
{
    public class MemberRepositoryTwo : ImemberRepository
    {
        private List<Domain.Member> members = new List<Domain.Member>()
        {
           new Domain.Member{  Id =1 ,Name= "Kirtesh Shah", Type ="G" , Address="Vadodara"},
           new Domain.Member{  Id =2 ,Name= "Mahesh Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Member{  Id =3 ,Name= "Nitya Shah", Type ="G" , Address="Mumbai"},
        };
        public List<Domain.Member> GetAllMembers()
        {
            return this.members;
        }
    }
}
