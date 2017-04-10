using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Test
{
    class Class
    {
        void Foo()
        {
            using (var c = new CustomClass())
            {

            }
        }
    }

    internal class CustomClass : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Do()
        {

        }
    }

    class Program1
    {
        void Foo()
        {
            var connection = new CustomClass();

            try
            {
                connection.Do();
            }
            finally
            {
                if (connection != null)
                    ((IDisposable)connection).Dispose();
            }
        }
    }
}
