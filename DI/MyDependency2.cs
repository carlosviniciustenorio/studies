using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.DI
{
    // Objetos transitórios são sempre diferentes; uma nova instância é fornecida para todo controlador e todo serviço.
    //services.AddTransient<IEmailSender, AuthMessageSender>();
    
    // Objetos com escopo definido são os mesmos em uma solicitação, mas diferentes entre solicitações diferentes.
    // services.AddScoped<IEmailSender, AuthMessageSender>();

    // Objetos Singleton são os mesmos para todos os objetos e solicitações.

    public class MyClass
    {
        public MyClass()
        {}

        public void Teste(int num = 0) { }
    }

    public class MyDependency2 : MyClass, IInterface
    {
        public MyDependency2()
        {
        }

        public void WriteMessage(int num = 0)
        {
            Teste(num);
        }
    }

    public interface IInterface
    {
        void WriteMessage(int num = 0);
    }

    public class MyDependency3
    {
        private readonly IInterface _dependency;
        public MyDependency3()
        {
            _dependency.WriteMessage(0);
        }
    }

}
