using CASO6_Combinado__SRP___ISP__El_Reporte_Financiero.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;



namespace CASO6_Combinado__SRP___ISP__El_Reporte_Financiero.Exporters
{
    internal class PdfExporter : IDocumentExporter
    {
        public void Export(decimal amount)
        {
            // SOLUCIÓN: Cambiar LicenseKind por LicenseType en la versión 2026.8
            QuestPDF.Settings.License = LicenseType.Community;

            string fileName = $"ReporteFinanciero_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            QuestPDF.Fluent.Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    // Encabezado
                    page.Header()
                        .Text("REPORTE FINANCIERO")
                        .SemiBold().FontSize(22).FontColor(Colors.Blue.Darken3);

                    // Contenido: Solo muestra el monto final precalculado que recibió por parámetro
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(column =>
                        {
                            column.Spacing(15);

                            column.Item().Text($"Fecha de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm}");
                            column.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            // Cuadro destacado con el balance total enviado
                            column.Item().Background(Colors.Grey.Lighten4).Padding(15).Row(row =>
                            {
                                row.RelativeItem().Text("Monto Total Procesado:").Bold().FontSize(14);
                                row.ConstantItem(120).AlignRight().Text($"{amount:C}").Bold().FontSize(14).FontColor(Colors.Green.Darken3);
                            });
                        });

                    // Pie de página administrativo
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Documento generado automáticamente bajo principios SOLID (SRP/ISP).").FontSize(9).FontColor(Colors.Grey.Medium);
                        });
                });
            })
            .GeneratePdf(filePath);

            Console.WriteLine($"[PDF] Reporte exportado exitosamente en: {filePath}");
        }

    }
    }


    

