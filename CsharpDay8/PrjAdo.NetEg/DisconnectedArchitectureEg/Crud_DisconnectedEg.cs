using System;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedArchitectureEg
{
    class Crud_DisconnectedEg
    {
        static void Main()
        {
            //2. create   SqlConnection object
            //connection string 
            SqlConnection con = null;
            SqlDataAdapter da;
          try  {

                //Windows authentication
                con = new SqlConnection(
                "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true");
                da = new SqlDataAdapter("select * from Region",con);
           
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NorthwindRegion");
                DataTable dt = ds.Tables["NorthwindRegion"];

                

                foreach (DataRow row0 in dt.Rows)
                {
                    foreach(DataColumn col in dt.Columns)
                    {
                        Console.Write(row0[col]);
                        Console.Write(" ");
                       // Console.WriteLine("".PadLeft(20,'='));
                    }
                    Console.WriteLine(" ");
                }


               
                //Adding one more table in same dataset
                Console.WriteLine("-------------------------");
                 da=new SqlDataAdapter("select * from Shippers", con);
                da.Fill(ds, "NorthwindShipper");
                 dt = ds.Tables["NorthwindShipper"];

                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row1[col]);
                        Console.Write(" ");
                        // Console.WriteLine("".PadLeft(20,'='));
                    }
                    Console.WriteLine(" ");
                }
             
                 
                //Insering Record Region table by adding new ROW in Datset
                //Insert,Update and Delete operation
                     SqlCommandBuilder scb = new SqlCommandBuilder(da);
                 da.Fill(ds);
                //Inserting or Adding New Row
                DataRow row = ds.Tables["NorthwindRegion"].NewRow();
                row["RegionID"] = 10;
                row["RegionDescription"] = "NW";
                //Adding Row to Datatable in Dataset 
                ds.Tables["NorthwindRegion"].Rows.Add(row);
            
                da.UpdateCommand = scb.GetUpdateCommand();
                da.Update(ds);
                Console.WriteLine("-------------");

                dt = ds.Tables["NorthwindRegion"];



                foreach ( DataRow row0 in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row0[col]);
                        Console.Write(" ");
                        // Console.WriteLine("".PadLeft(20,'='));
                    }
                    Console.WriteLine(" ");
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
            Console.Read();

        }
    }
}
