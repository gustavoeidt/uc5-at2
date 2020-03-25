/****
Classes estáticas não precisam ser instanciadas.
No ASP.NET Core MVC, classes estáticas vivem do início 
ao fim da execução do programa.
Por isso, Dados deve ser usado para manipular as informações
dos pedidos.
Exemplos de uso:
Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
Dados.PedidoAtual.MetodoDePedido();
*****/

using System.Collections.Generic;

namespace at02.Models
{
    public static class Dados{
        public static List<Agendamento> agendamentos {get; set;}
        static Dados()
        {
            agendamentos = new List<Agendamento>();
        }

        public static void incluir(Agendamento agendamento)
        {
            agendamentos.Add(agendamento);
        }

        public static List<Agendamento> listar()
        {
            return agendamentos;
        }
    }
}