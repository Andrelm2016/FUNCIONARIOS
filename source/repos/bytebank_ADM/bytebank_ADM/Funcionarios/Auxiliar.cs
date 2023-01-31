using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Auxiliar:Funcionario
    {
        public override double GetBonificacao()
        {
            return base.Salario *= 0.2;
        }
        public override void AumentarSalario() 
        {
            this.Salario *= 1.1;
        }
    }
}
