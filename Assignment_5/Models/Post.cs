using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Web;

namespace Assignment_5.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int user_id { get; set; }
        public DateTime created_at { get; set; }
        public string name { get; set; }

        public string pic { get; set; }

        static String connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Web;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Post(int id, string title, string body, int user_id, DateTime created_at , string name)
        {

            this.id = id;
            this.title = title;
            this.body = body;
            this.user_id = user_id;
            this.created_at = created_at;
            this.name = name;
        }

        public Post(int id, string title, string body, int user_id, DateTime created_at, string name , string pic)
        {

            this.id = id;
            this.title = title;
            this.body = body;
            this.user_id = user_id;
            this.created_at = created_at;
            this.name = name;
            this.pic = pic;
        }

        public static List<Post> Get_All_Post()
        {
            List<Post> posts = new List<Post>();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"select * from [posts]  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
               posts.Add(new Post((int)dr[0], (string)dr[1], (string)dr[2], (int)dr[3], (DateTime)dr[4], (string)dr[6], (string)dr[5] ));
                string pic = (string)dr[5];
              
            }
            conn.Close();
            return posts;
        }

        public static void Create_Post(string title, string body, int user_id  , string name , string pic )
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string created_at = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"insert into [posts] (title , body , user_id , created_at , name , pic ) values ('{title}' , '{body}' , '{user_id}' , '{created_at}' , '{name}' , '{pic}' )";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Post> Get_Post_By_ID(int post_id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"select * from [posts] where id = '{post_id}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Post> posts = new List<Post>();
            while (dr.Read())
            {
                posts.Add(new Post((int)dr[0], (string)dr[1], (string)dr[2], (int)dr[3], (DateTime)dr[4], (string)dr[6], (string)dr[5]));
            }
            conn.Close();
            return posts;
        }

        public static Post Get_Post_By_PostandUser_ID(int post_id , int user_id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query2 = $"select * from [posts] where id = '{post_id}' and user_id = '{user_id}' ";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DateTime t = System.DateTime.Now;

            if (dr2.Read())
            {
                Post post = new Post(post_id, null, null, user_id, t, null, null);
                return post;
            }
            else { return null; }
            
        }

        public static int Get_Post_By_User_ID(int user_id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query2 = $"select * from [posts] where user_id = '{user_id}' ";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DateTime t = System.DateTime.Now;
            //List<Post> posts = new List<Post>();
            int count = 0;
            while (dr2.Read())
            {
                //posts.Add(new Post(0, null, null, user_id, t, null, null));
                count++;
                
            }
            conn.Close();
            return count;
        }

        public static void Delete_Post(int post_id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"delete from [posts] where id = '{post_id}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Delete_Post_By_UserID(int user_id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = $"delete from [posts] where user_id = '{user_id}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Update_Post(string title , string body , int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            string query = $"Update [posts] set title = '{title}' , body = '{body}' where id = '{id}' ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
