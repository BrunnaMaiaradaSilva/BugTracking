using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BugEntryClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int BugTable(int BugId,
            DateTime Date,
            String ClassLibrary,
            String Block,
            String IdentifiedBy,
            String Class,
            String LineNumber,
            String Project,
            String Method,
            String BugDetails,
            String Code,
            byte[] Snap,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageBugs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bugid", BugId);
                cmd.Parameters.AddWithValue("@date", Date);
                cmd.Parameters.AddWithValue("@classlibrary", ClassLibrary);
                cmd.Parameters.AddWithValue("@block", Block);
                cmd.Parameters.AddWithValue("@identifiedby", IdentifiedBy);
                cmd.Parameters.AddWithValue("@class", Class);
                cmd.Parameters.AddWithValue("@linenumber", LineNumber);
                cmd.Parameters.AddWithValue("@project", Project);
                cmd.Parameters.AddWithValue("@method", Method);
                cmd.Parameters.AddWithValue("@bugdetails", BugDetails);
                cmd.Parameters.AddWithValue("@code", Code);
                cmd.Parameters.AddWithValue("@snap", Snap);
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
        public DataTable GetAllBugs() 
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from BugTable", conn);
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
