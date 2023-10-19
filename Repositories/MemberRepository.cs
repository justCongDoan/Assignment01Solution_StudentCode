using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(Member member) => MemberDAO.DeleteMember(member);

        public Member GetMember(int id) => MemberDAO.FindMember(id);

        public List<Member> GetMembers() => MemberDAO.GetMembers();

        public void SaveMember(Member member) => MemberDAO.SaveMember(member);

        public void UpdateMember(Member member) => MemberDAO.UpdateMember(member);
    }
}
