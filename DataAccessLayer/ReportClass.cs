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

        //public DataTable GetBugByMember(int MemberId)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("select m.MemberName,Project,BugId,BugDetails,ClassName,MethodName,Block,LineNumber from BugEntryTable b,MemberTable m,ProjectTable p where m.MemberId=b.MemberId and b.ProjectId=p.ProjectId  and m.MemberId=@MemberId", conn);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@MemberId", MemberId);
        //        conn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        dt.Load(dr);
        //        conn.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally { conn.Close(); }
        //}
    }
}
