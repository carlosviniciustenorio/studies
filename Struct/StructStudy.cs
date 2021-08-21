using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.Struct
{
    struct Point
    {
        //Um struct é considerado como semântica de valor, pois são tipos de valores.
        
        //A Herança não tem suporte para Struct. Sendo assim, não é possível ser abstract, ter métodos virtuais, ser internal
        //Porém, é possível implementar interfaces e utilizar o modificador override nos métodos de System.ValueType (Herdado implicitamente)
        
        //Não pode existir uma referência de um struct dentro do mesmo Struct
        //Ao atribuir um struct a outro struct, não é feita a referência de um objeto mas sim uma cópia dos valores da struct
        //Ex: 
        //   var a = new Z(10,10);
        //   var b = a;
        //   a.x = 100;
        //   Console.WriteLine(b.x);
        
        //   O Valor será igual a 10, pois "b" é uma cópia do valor de a, e não uma referência.
        //   Caso Z fosse uma classe, o valor de b.x seria 100, pois uma classe é considerada como semântica de referência.

        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
