using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.ApplicationLayer
{
    public interface ImemberRepository
    {
        List<Domain.Member> GetAllMembers();
    }
}
