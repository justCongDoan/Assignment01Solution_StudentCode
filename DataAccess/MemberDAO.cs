using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MemberDAO
    {
        public static List<Member> GetMembers()
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    return context.Member.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Member FindMember(int memId)
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    return context.Member.SingleOrDefault(p => p.CategoryId == memId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void SaveMember(Member member)
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    context.Member.Add(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateMember(Member member)
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    context.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteMember(Member member)
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    context.Member.Remove(context.Member.SingleOrDefault(p => p.MemberId == member.MemberId));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
