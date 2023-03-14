using System;
using System.IO;

namespace OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            CadPf cadf = new CadPf();
            cadf.nome = "Julio Vernner";
            cadf.CPF = Convert.ToUInt64("14875998680").ToString(@"000\.000\.000\-00");
            cadf.datanascimento = new DateOnly(2023,03,13);
            cadf.pagamentoImposto();

            //Console.WriteLine($"Seu nome é {cadf.nome} seu CPF é {cadf.CPF} é sua data de nascimento é {cadf.datanascimento}");


            CadPj cadp = new CadPj();
            cadp.razaoSocial = "nameless";
            cadp.CNPJ = Convert.ToUInt64("01265784200012").ToString(@"00\.000\.000\/0000\-00");
            cadp.pagamentoImposto();

            //Console.WriteLine($"Sua razão social é {cadp.razaoSocial} e seu CNPJ é {cadp.CNPJ}");


            string caminhoArquivo = "C:\\Users\\Julio\\Desktop\\c# atividades opp\\arquivo.txt";

            var stream = new StreamWriter(caminhoArquivo);

            stream.WriteLine($"Nome cadastrado {cadf.nome} é CPF cadastrado é {cadf.CPF}");
            stream.WriteLine($"Nome Cadastrado {cadp.razaoSocial} é CNPJ cadastrado é {cadp.CNPJ}");

            stream.Close();

            using (var reader = new StreamReader(caminhoArquivo))
            {
                Console.WriteLine(reader.ReadLine());
                Console.WriteLine(reader.ReadLine());
            }
            
        }
    }
}

