using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wamicBhaeProject.Models
{
    public class dbClass
    {

        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["memberConn"].ToString();
            con = new SqlConnection(constring);
        }


        public bool AddMember(addMemberClass c)
        {
            connection();
            SqlCommand cmd = new SqlCommand("Insert into Addmember values('"+c.memberName+ "','" + c.fatherName + "','" + c.CNIC + "','" + c.streetAddress + "','" + c.province + "','" + c.division + "','" + c.district + "','" + c.city + "','" + c.tehsil + "','" + c.unioncouncil + "','" + c.mailingAddress + "','" + c.mobileNumber + "','" + c.EmailAddress + "','" + c.photo + "','"+c.path+"')", con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<addMemberClass> viewMember()
        {
            connection();
            List<addMemberClass> list = new List<addMemberClass>();

            SqlCommand cmd = new SqlCommand("viewDetail1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(
                    new addMemberClass
                    {
                        Id = Convert.ToInt32(dr["memberId"]),  //  [memberId]
                        memberName = Convert.ToString(dr["memberName"]),
                        mobileNumber = Convert.ToString(dr["mobileNumbar"]),
                        //[mobileNumbar]
                        photo = Convert.ToString(dr["photo"]),
                        path = Convert.ToString(dr["path"])
                    });
            }
            return list;

        }


    }
}