using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FsConsoleApp
{
    internal class StudCrud
    {
        public class Student
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            String name, q;
            int roll, per;
            Student(SqlConnection conn)
            {
                this.conn = conn;
                conn.Open();
            }
            public void acceptRoll()
            {
                Console.WriteLine("Enter roll number:");
                roll = Convert.ToInt32(Console.ReadLine());
            }
            public void acceptPer()
            {
                Console.WriteLine("Enter percentage:");
                per = Convert.ToInt32(Console.ReadLine());
            }
            public void acceptName()
            {
                Console.WriteLine("Enter Name:");
                name = Console.ReadLine();
            }
            public void showData()
            {
                try
                {
                    cmd = new SqlCommand("select * from student", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("roll=" + dr["roll"].ToString());
                        Console.WriteLine("name=" + dr["roll"].ToString());
                        Console.WriteLine("per=" + dr["per"].ToString());
                        Console.WriteLine("------------");
                    }
                    dr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            public void insertData()
            {
                acceptName();
                acceptRoll();
                acceptPer();
                try
                {
                    q = "insert into student values(@roll,@name,@per)";
                    Console.WriteLine("query=" + q);
                    cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@roll", roll);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@per", per);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("record inserted");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public bool checkData()
            {
                acceptRoll();
                try
                {
                    q = "select * from student where roll=@roll";
                    cmd=new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@roll",roll);
                    dr=cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        dr.Close();
                        return true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return false;
            }
            public void updateData()
            {
                if (!checkData()) return;

                acceptPer();

                try
                {
                    q = "update student set per=@per where roll=@roll";
                    cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@roll", roll);
                    cmd.Parameters.AddWithValue("@per", per);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("update successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public void deleteData()
            {
                if (!checkData()) return;
                try
                {
                    q = "delete from student where roll=@roll";
                    cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@roll", roll);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Delete data successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public void menu()
            {
                Console.WriteLine("\n1.Show\n2.Insert\n3.Update\n4.Delete\n5.Exit");
                Console.WriteLine("Enter your choice:");
                String ch=Console.ReadLine();

                switch(ch)
                {
                    case "1":showData(); break;

                    case "2":insertData(); break;

                    case "3":updateData(); break;

                    case "4":deleteData(); break;

                    case "5":Environment.Exit(1);
                        break;

                    default: Console.WriteLine("Wrong choice");
                        break;
                }
            }
        //}

            static void Main(string[] args)
            {
                SqlConnection conn = null;
                SqlCommand cmd = null;
                SqlDataReader dr = null;

                try
                {
                    conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Asp dot net\basic\FsConsoleApp\FsConsoleApp\App_data\studentDB.mdf"";Integrated Security=True");
                    Student st = new Student(conn);
                    st.menu();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("sm main=" + ex.Message);
                }

            }
    }
}
} 
