using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ReportClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public DataTable GetBugByMember(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select m.UserName,ProjectName,BugId,BugDetails,Class,Method,Block,LineNumber from BugTable b,MemberTable m,ProjectTable p where m.MemberId=b.BugId and b.BugId=p.ProjectId  and m.MemberId=MemberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetBugByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select m.memberName,ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber from BugEntryTable b,MemberTable m,ProjectTable p where m.memberId=b.memberId and b.ProjectId=p.ProjectId  and p.ProjectId=@ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
