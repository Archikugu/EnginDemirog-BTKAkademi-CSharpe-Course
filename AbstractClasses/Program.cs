using System;

namespace AbstractClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();
            database.Add();
            database.Delete();

            Database database2=new SqlServer();
            database2.Add();
            database2.Delete();
        }
    }
    //Abstract class = virtual methods + interface 
    //Abstract class = inheritance dır 
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
