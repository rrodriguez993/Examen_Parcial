using System;

namespace SistemaBancario
{
    // Clase base
    abstract class CuentaBancaria
    {
        public decimal Saldo { get; set; }

        public CuentaBancaria(decimal saldo)
        {
            Saldo = saldo;
        }

        public abstract decimal CalcularInteresMensual();
    }

    // Cuenta de Ahorros
    class CuentaAhorros : CuentaBancaria
    {
        public decimal TasaPromocional { get; set; }

        public CuentaAhorros(decimal saldo, decimal tasaPromocional)
            : base(saldo)
        {
            TasaPromocional = tasaPromocional;
        }

        public override decimal CalcularInteresMensual()
        {
            return Saldo * TasaPromocional;
        }
    }

    // Cuenta de Inversión
    class CuentaInversion : CuentaBancaria
    {
        public double FactorRiesgo { get; set; }

        public CuentaInversion(decimal saldo, double factorRiesgo)
            : base(saldo)
        {
            FactorRiesgo = factorRiesgo;
        }

        public override decimal CalcularInteresMensual()
        {
            return Saldo * (decimal)FactorRiesgo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaAhorros(10000m, 0.03m);
            CuentaBancaria cuenta2 = new CuentaInversion(10000m, 0.07);

            Console.WriteLine("Interés Cuenta de Ahorros: Q" +
                cuenta1.CalcularInteresMensual());

            Console.WriteLine("Interés Cuenta de Inversión: Q" +
                cuenta2.CalcularInteresMensual());
        }
    }
}