using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.Sealad
{
    public sealed class SealadStudy : C
    {
        //Uma classe sealed não pode ser usada como uma classe base. 
        //Por esse motivo, também não pode ser uma classe abstrata.
        //As classes sealed impedem a derivação. 
        //Como elas nunca podem ser usadas como uma classe base, 
        //algumas otimizações em tempo de execução podem tornar a chamada a membros de classe sealed ligeiramente mais rápida.

        //Um método, um indexador, uma propriedade ou um evento em uma classe derivada que está substituindo 
        //um membro virtual da classe base, pode declarar esse membro como sealed. 
        //Isso anula o aspecto virtual do membro para qualquer outra classe derivada.
        //Isso é realizado através da colocação da palavra-chave sealed antes da palavra-chave override na declaração de membro de classe.Por exemplo:

        public sealed override void DoWork() {}
    }
}
