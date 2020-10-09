using System;
using System.Data.SqlClient; //1.Adding sql server- data provider
using System.Data;


namespace ConnectedArchitectureEg
{
    class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        internal void GetRegion()
        {
            Console.WriteLine("Enter RegionId");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter RegionDescription");
            RegionDescription = Console.ReadLine();
        }
    }

    class DataAccess

    {
        //2. create   SqlConnection object
        //connection string 
        SqlConnection con = null;
        //Creating object for command class
        SqlCommand cmd;

        public SqlConnection GetConnection()
        {
            //Windows authentication
            con = new SqlConnection(
            "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true");
            con.Open();
            return con;
        }
        //select 
        public void DisplayRegion()
        {
            try
            {/* SqlConnection con1;
             con1 = GetConnection();*/
             //reuse object
                con = GetConnection();
                SqlDataReader dr;
                // string s = "select * from Region";
                cmd = new SqlCommand("select * from Region", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Console.WriteLine(dr[0] + "  " + dr[1]);
                    Console.WriteLine(dr["RegionId"] + "  " + dr["RegionDescription"]);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e); 

            }

            finally
            {
                con.Close();
            }
           
        }

        //Execute scalar
     internal   void GetbyExecuteScalar()
        {
            con = GetConnection();
            cmd = new SqlCommand("select count(RegionID) from Region", con);
           int count= Convert.ToInt32(cmd.ExecuteScalar()); //execute scalar retuns object
            Console.WriteLine("No of Region:{0}",count);
        }

        //Update
        internal void EditRegion()
        {
            Region region = new Region();
            Console.WriteLine("Please the which region description to be updated");
            region.GetRegion();
            con = GetConnection();
            cmd = new SqlCommand("update Region set RegionDescription=@RDesc where RegionId=@Rid", con);
          
            cmd.Parameters.AddWithValue("@Rid", region.RegionId);
            cmd.Parameters.AddWithValue("@RDesc",region.RegionDescription);
            int i= cmd.ExecuteNonQuery();
            Console.WriteLine("Rows Updated are:{0}",i);
            
        }

        //StoredProcedure with Parameters
    internal  void CallProcedure()
        {
            con = GetConnection();

            Console.WriteLine("Enter the Customer ID");
            string custId = Console.ReadLine();
                                //Procedurename
            cmd = new SqlCommand("CustOrdersOrders", con);
                             //using System.Data
            cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@CustomerID", custId);
            
            //Or
            /*SqlParameter sqlParameter = new SqlParameter("@CustomerID", custId);
            sqlParameter.Direction = ParameterDirection.Input;
            sqlParameter.DbType = DbType.String;
            cmd.Parameters.Add(sqlParameter);*/
            
            SqlDataReader rdr;
        
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["OrderId"] + " " + rdr["OrderDate"]+" "+rdr["RequiredDate"]);

            }
            con.Close();
        }

    }


    class ClientEnd
    {
        static void Main()
        {
            DataAccess d = new DataAccess();
            try
            {
              /*  d.DisplayRegion();
                d.GetbyExecuteScalar();
                d.EditRegion();*/
                d.CallProcedure();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
         
            Console.Read();
        }
    }



    class Crud_ConnectedArchitectureEg
    {

    }
}