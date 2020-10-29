using Monetiza.Models;
using System;

namespace Monetiza.Services
{
    public class CalculaAtrasoService 
    {

        public string Calcular(Conta model, out int diasAtraso, out double percMulta, out double valMulta, out double percJuros, out double valJuros, out double valCorrigido)
        {
            percMulta = 0;
            percJuros = 0.1;
            valMulta = 0;
            valJuros = 0;

            diasAtraso = (DateTime.Parse(model.datapagamento).Subtract(DateTime.Parse(model.datavencimento))).Days;

            if (diasAtraso > 0)
            {
                if (diasAtraso <= 3)
                {
                    percMulta = 2;
                    percJuros = 0.1;

                    goto CalcularAtraso;
                }
                if (diasAtraso <= 5)
                {
                    percMulta = 3;
                    percJuros = 0.2;

                    goto CalcularAtraso;
                }
                if (diasAtraso > 5)
                {
                    percMulta = 5;
                    percJuros = 0.3;
                }

            CalcularAtraso:

                valMulta = (model.valororiginal * percMulta) / 100;

                valJuros = ((percJuros * diasAtraso) * model.valororiginal) / 100; //Cálculo de juros simples.

                valCorrigido = model.valororiginal + valMulta + valJuros;

            }
            else
            {
                percMulta = 0;
                valMulta = 0;
                percJuros = 0;
                valJuros = 0;
                valCorrigido = model.valororiginal;
            }
            
            return "ok";

        }
    }
}
