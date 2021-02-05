using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Web;
using System.IO;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace Assignment_5.Models
{
    public  class CAccount
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string uname { get; set; }
        public string email { get; set; }
        public string pass { get; set; } 
        public string pic { get; set; }

        public int is_admin { get; set; }
        

        static String connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Web;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //public HttpPostedFileBase pic { get; set; }


        public CAccount(int id , string fname, string uname, string email,  string pass  )
        {

            this.id = id;
            this.fname = fname;
            this.uname = uname;
            this.email = email;
            this.pass = pass;
        }

        public CAccount(int id, string fname, string uname, string email, string pass , string pic)
        {

            this.id = id;
            this.fname = fname;
            this.uname = uname;
            this.email = email;
            this.pass = pass;
            this.pic = pic;
        }

        public CAccount(int id, string fname, string uname, string email, string pass , int is_admin)
        {

            this.id = id;
            this.fname = fname;
            this.uname = uname;
            this.email = email;
            this.pass = pass;
            this.is_admin = is_admin;
        }

        public CAccount(int id, string fname, string uname, string email, string pass, string pic, int is_admin )
        {

            this.id = id;
            this.fname = fname;
            this.uname = uname;
            this.email = email;
            this.pass = pass;
            this.pic = pic;
            this.is_admin = is_admin;
        }

        //List<CAccount> users = new List<CAccount>();

        public static CAccount GetCAccountBy_user_name_and_password(string user_name, string password)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"select * from [user] where uname = '{user_name}' and pass = '{password}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                return new CAccount((int)dr[0], (string)dr[5], (string)dr[1], (string)dr[2], (string)dr[3] , (int)dr[6]);

            }
            else {  return null; }
        }

        public static CAccount GetCAccountBy_user_name(string user_name)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"select * from [user] where uname = '{user_name}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                return new CAccount((int)dr[0], (string)dr[5], (string)dr[1], (string)dr[2], (string)dr[3], (int)dr[6]);

            }
            else { return null; }
        }

        public static void Register_User(string fname, string uname, string email, string pass , string pic)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            int num = 0 ;
            string query1 = $"insert into [user] (uname , email , pass , fname , is_admin , pic) values ('{uname}' , '{email}' , '{pass}' , '{fname}' , '{num}' , '{pic}')";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        public static void Add_User_For_Admin(string fname, string uname, string email, string pass , string pic)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            int num = 0;
            string query = $"insert into [user] (uname , email , pass , fname , is_admin , pic) values ('{uname}' , '{email}' , '{pass}' , '{fname}' , '{num}' , '{pic}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<CAccount> GetAllUsers()
        {
            SqlConnection conn = new SqlConnection(connString);
            int num = 0;

            List<CAccount> users = new List<CAccount>();

            conn.Open();
            string query = $"select * from [user] where  is_admin = '{num}'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                users.Add(new CAccount((int)dr[0], (string)dr[5], (string)dr[1], (string)dr[2], (string)dr[3] , (string)dr[4]));
            }

            conn.Close();

            return users;
        }

        public static CAccount Get_User_By_ID(int id )
        {
            SqlConnection conn = new SqlConnection(connString);
          
            List<CAccount> users = new List<CAccount>();

            conn.Open();
            string query = $"select * from [user] where  id = '{id}'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                return new CAccount((int)dr[0], (string)dr[5], (string)dr[1], (string)dr[2], (string)dr[3] , (string)dr[4] , (int)dr[6]);
            }

            else { return null; }

            
        }

        public static void Update_User(string name , string email , string new_pass , int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            string query2 = $"Update [user] set uname = '{name}' , email = '{email}' , pass = '{new_pass}' where id = '{id}' ";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public static void Update_User_for_Admin(int id, string name, string uname, string email, string pass  )
        {
            SqlConnection conn = new SqlConnection(connString);
            string query2 = $"Update [user] set fname = '{name}' ,  uname = '{uname}' , email = '{email}' , pass = '{pass}'  where id = '{id}' ";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public static void Delete_User(int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"delete from [user] where id = '{id}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
