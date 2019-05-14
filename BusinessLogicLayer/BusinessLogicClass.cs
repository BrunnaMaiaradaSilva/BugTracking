using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        MemberClass mc = new MemberClass();
        ProjectClass pc = new ProjectClass();
        BugEntryClass bec = new BugEntryClass();
        BugSolutionClass bsc = new BugSolutionClass();

        public bool MemberTable(int MemberId,
            String UserName,
            String Name,
            String Password,
            String Role,
            String Address,
            String Email,
            String Gender,
            int Contact,
            DateTime DOB,
            DateTime DOJ,
            byte[] Image,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = mc.MemberTable(MemberId,
                    UserName, Name, Password, Role, Address, Email,
                    Gender, Contact, DOB, DOJ, Image, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ProjectTable(int ProjectId,
            String ProjectName,
            DateTime StartingDate,
            DateTime FinishingDate,
            String Description,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = pc.ProjectTable(ProjectId,ProjectName,StartingDate,FinishingDate,Description, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool BugTable(int BugId,
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
                bool result = false;
                int conn = bec.BugTable(BugId,Date,ClassLibrary,Block,IdentifiedBy,Class,LineNumber,Project,Method,BugDetails,Code,Snap, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

 
        public bool BugSolutionTable(int BugSolutionId, 
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
                bool result = false;
                int conn = bsc.BugSolutionTable(BugSolutionId,BugSolvedBy,Date,Project,BugDetails,SolutionDetails, Code, Snap, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
