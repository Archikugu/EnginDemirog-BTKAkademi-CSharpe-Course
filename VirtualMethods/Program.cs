using System;

namespace VirtualMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer=new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();


        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql Code");
        }
    }
    class MySql:Database
    {
        public override void Add()
        {
            base.Add();
        }
        public override void Delete()
        {
            base.Delete();
        }
    }
}
