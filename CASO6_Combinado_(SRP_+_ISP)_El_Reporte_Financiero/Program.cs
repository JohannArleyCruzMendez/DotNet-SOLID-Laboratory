using CASO6_Combinado__SRP___ISP__El_Reporte_Financiero.Exporters;
using CASO6_Combinado__SRP___ISP__El_Reporte_Financiero.Services;








RevenueCalculatorService service = new RevenueCalculatorService();
var totalIngresos = service.CalculateTotalRevenue();
    PdfExporter exporter = new PdfExporter();
    exporter.Export(totalIngresos);
