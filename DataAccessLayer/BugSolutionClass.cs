using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BugSolutionClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int BugSolutionTable(int BugSolutionId,
            String BugSolvedBy,
            DateTime Date,
            String Project,
            String BugDetails,
            String SolutionDetails,
            String Code,
            byte[] Snap,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageBugSolutions", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BugsolutionId", BugSolutionId);
                cmd.Parameters.AddWithValue("@BugsolvedBy", BugSolvedBy);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Project", Project);
                cmd.Parameters.AddWithValue("@BugDetails", BugDetails);
                cmd.Parameters.AddWithValue("@SolutionDetails", SolutionDetails);
                cmd.Parameters.AddWithValue("@Code", Code);
                cmd.Parameters.AddWithValue("@Snap", Snap);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetAllBugSolutions()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from BugSolutionTable", conn);
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
        //public DataTable getAllBugSolutions()
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("select b.bugSolutionId,b.dateOfSolutionIdentified,m.memberName, p.projectName,e.bugDetails,e.snapShotOfBugMessage,b.solutionDetails,b.codeAfterFixingBug from BugSolutionTable b,BugEntryTable e, ProjectTable p, MemberTable m where b.bugId=e.bugId and b.projectId=p.projectId and b.memberId=m.memberId", conn);
        //        cmd.CommandType = CommandType.Text;
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
