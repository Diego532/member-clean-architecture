namespace Member.ApplicationLayer
{
    public class MemberService : IMemberServices
    {
        private readonly ImemberRepository _memberRepository;

        public MemberService(ImemberRepository memberRepository)
        {
            this._memberRepository = memberRepository;
        }

        public List<Domain.Member> GetAllMembers()
        {
            return this._memberRepository.GetAllMembers();
        }
    }
}