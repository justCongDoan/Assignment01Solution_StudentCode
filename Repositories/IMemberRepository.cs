using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMemberRepository
    {
        void SaveMember(Member member);

        Member GetMember(int id);

        void DeleteMember(Member member);

        void UpdateMember(Member member);

        List<Member> GetMembers();
    }
}
