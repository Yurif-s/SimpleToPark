using System;
using System.Data;
using Microsoft.VisualBasic;

namespace SimpleToPark
{
    class GerenciadorArrecadacao
    {
        public float ValorHora { get; set; }
        private float _arrecadado;

        public float Arrecadado
        {
            get => _arrecadado;
            set => _arrecadado += value;
        }

        public  float CalcularEstadiaCliente(DateTime entrada)
        {
            var permanencia = DateTime.Now - entrada;

            if (permanencia.Hours <= 0)
            {
                return ValorHora;
            }
            else
            {
                return ValorHora * permanencia.Hours;
            }
        }
        
    }
}
