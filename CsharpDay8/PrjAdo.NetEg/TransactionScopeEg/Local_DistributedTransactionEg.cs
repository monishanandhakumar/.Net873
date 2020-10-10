using System;
using System.Data.SqlClient; 
using System.Transactions;

namespace TransactionScopeEg
{
    class Local_DistributedTransactionEg
    {
        static void LocalTransactionScope()
        {

          /*  using{

            }*/
            int i, j;
            //Transaction class
            SqlTransaction mytran=null;
            string myconnectionString = "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true";
            //transaction
            using (TransactionScope myscope = new TransactionScope())
            {
                //Connection
                using (SqlConnection conn = new SqlConnection(myconnectionString))
                {
                    conn.Open();
                    try
                    {
                        //Begin transaction
                        mytran = conn.BeginTransaction();
                        SqlCommand mycommand2 = new SqlCommand("Insert into Shippers values('MyShop','8729298372')", conn);
                        j = mycommand2.ExecuteNonQuery();
                        Console.WriteLine("Inserted record in Shipper table :{0}",j);
                        var mycommand = new SqlCommand("Insert into Region  values(9,'southwest')", conn);

                        i = mycommand.ExecuteNonQuery();
                        //Commiting transaction
                        mytran.Commit();
                      //  myscope.Complete();

                    }
                    catch (Exception e)
                    {
                        if(mytran!=null)
                        {
                            mytran.Rollback();
                            Console.WriteLine(e);
                            Console.WriteLine("Not Complete");

                        }
                       
                    }


                }


            }

        }


        static void DistributedTransactionScope()
        {
            string myconnectionString = "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = Northwind; Integrated Security = true";
            string myconnectionString1 = "Data Source = DESKTOP-U8J1M3C\\MSSQLSERVER01; Initial Catalog = dbEmployee873; Integrated Security = true";

            using (TransactionScope myscope = new TransactionScope())
            {
                using (var myconn = new SqlConnection(myconnectionString))
                {
                    myconn.Open();
                    var mycommand2 = new SqlCommand("Insert into Shippers values('VegatableShop','8729298372')", myconn);
                    mycommand2.ExecuteNonQuery();
                    using (var myconn1 = new
                       SqlConnection(myconnectionString1))
                    {
                        myconn1.Open();
                        var cmd = new SqlCommand("Insert into Book values('B005','AAAA')", myconn1);
                        cmd.ExecuteNonQuery();
                    }
                }
                myscope.Complete();
            }
        }


        static void Main()
        {
            try
            {
                LocalTransactionScope();
               // DistributedTransactionScope();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
            Console.Read();

        }

    }
}
