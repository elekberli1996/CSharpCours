using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesImportantSignificant
{
    interface ICustomerDal
    {

        void Add();
        void Delete();

        void Update();

    }

    class SqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql  added");
        }

        public void Delete()
        {

            Console.WriteLine("sqlden deleted");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("orcale added");
        }

        public void Delete()
        {
            Console.WriteLine("oracldan deleted");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("mysql deleted");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }


    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();

        }

        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();

        }
    }


}
