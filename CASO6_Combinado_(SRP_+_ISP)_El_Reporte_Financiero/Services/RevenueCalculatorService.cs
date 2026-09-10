using CASO6_Combinado__SRP___ISP__El_Reporte_Financiero.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO6_Combinado__SRP___ISP__El_Reporte_Financiero.Services
{
    internal class RevenueCalculatorService : IRevenueCalculator
    {
        public decimal CalculateTotalRevenue()
        {
            // 1. Simular el tiempo de espera de una consulta real a la Base de Datos (1.5 segundos)
            Thread.Sleep(1500);

            // 2. Simular los registros de una tabla de "Ventas" o "Facturas" usando una Colección
            var registrosVentas = new List<decimal>
            {
                25000.50m,
                15400.00m,
                30200.10m,
                4399.40m
            };

            // 3. Procesar y sumar los datos usando LINQ (.Sum()) para obtener el monto ficticio grande
            decimal totalCalculado = registrosVentas.Sum();

            return totalCalculado; // Retorna 75000.00m de forma dinámica
        }
    }
    }

