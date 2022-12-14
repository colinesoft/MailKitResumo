using ClosedXML.Excel;
using MailKit.Data;
using System;
using System.Linq;

namespace MailKit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verificar os parametros necessários para funcinar
            var mails = EmailsMailKit.GetEmails("hostnameAqui", 0, true, "EmailAqui", "SenhaDoEmailAqui", StatusMessage.UNREAD,  @"c:\temp\anexos");
            var ctx = new DataContext();
            var registros = ctx.Registros;

            foreach(var mail in mails)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("De: {0}", mail.From);
                Console.WriteLine("Assunto: {0}", mail.Subject);
                Console.WriteLine("Lida: {0}", mail.Read);
                //Console.WriteLine("Corpo: {0}", mail.Body);
                Console.WriteLine("ANEXOS:");
                foreach (var anexo in mail.Attachments)
                {
                    Console.WriteLine(anexo);

                    var xls = new XLWorkbook(anexo);
                    var planilha = xls.Worksheets.FirstOrDefault();
                    var totalLinhas = planilha.Rows().Count();
                    for (int l = 3; l <= totalLinhas; l++)
                    {
                        var operacao = planilha.Cell($"B{l}").Value.ToString();
                        var cliente = planilha.Cell($"C{l}").Value.ToString();
                        var rdvi = planilha.Cell($"D{l}").Value.ToString();
                        Console.WriteLine($"{operacao} - {cliente} - {rdvi}");

                        registros.Add(new Entities.RegistroEntity()
                        {
                            ID = Guid.NewGuid(),
                            Operacao = operacao,
                            Cliente = cliente,
                            RDVI = rdvi
                        });

                        //Salva as alterações
                        ctx.SaveChanges();
                    }
                }
            }
        }
    }
}
