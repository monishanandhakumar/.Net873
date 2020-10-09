using System;
using System.Data;
using System.Data.SqlClient; //1.Adding sql server- data provider


namespace ConnectedArchitectureEg
{
    class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public void GetShipper()
        {
            Console.WriteLine("Ënter ShipperName");
            CompanyName = Console.ReadLine();
            Console.WriteLine("Enter phoneNo");
            Phone = Console.ReadLine();
        }
    }

    class BasicAdo
    {
        
        static void Main()
        {
            //2. create   SqlConnection object
            //connection string 
            SqlConnection con=null;
            //Creating object for command class
            SqlCommand cmd;
            try
            {
                //Windows authentication
                con = new SqlConnection(
                "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true");
                //Sql server authentication
                // con = new SqlConnection(
                // "Data Source= DESKTOP-U8J1M3C\\MSSQLSERVER01;Initial Catalog=Northwind;User ID=sa;Password=newuser123#");
                Console.WriteLine("Connection Established with Sqlserver!!!");

                //Open the connection
                con.Open();
                //Insert Operation in shippers tbl in static 
                //   cmd = new SqlCommand("insert into Shippers values('SAI','123456789')", con);

                //Dynamic Insertion
                //creating object for shipper class
                 Shipper shipper = new Shipper();
                /*shipper.GetShipper(); //calling get shipper method to get input from user

                cmd = new SqlCommand("insert into Shippers values(@cname,@phoneno)", con);
                cmd.Parameters.AddWithValue("@cname", shipper.CompanyName);
                cmd.Parameters.AddWithValue("@phoneno", shipper.Phone);
                int i= cmd.ExecuteNonQuery(); //return integer 
                Console.WriteLine("No of rows affected is:{0}",i);
                cmd.Parameters.Clear();*/

                //Delete operation with parameter
                /*  Console.WriteLine("Enter the CompanyName to be deleted");
                  shipper.CompanyName = Console.ReadLine();
                  string delcom = "delete from Shippers where CompanyName=@Cname";
                  cmd = new SqlCommand(delcom,con);
                  cmd.Parameters.AddWithValue("@cname", shipper.CompanyName);
                 int i= cmd.ExecuteNonQuery(); //delete will performed
                  Console.WriteLine("No of rows deleted is:{0}",i);*/
                cmd = new SqlCommand("Ten Most Expensive Products", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Console.WriteLine(dr[0] + "  " + dr[1]);
                    Console.WriteLine(dr["0"].ToString() + "  " + dr["1"].ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                con.Close();
            }
            Console.Read();
        }
    }
}
