using System;


public class AgendaTelefonica
{
    public static void Main(string[] args)
    {
        string[] primeiroNome = new string[100];
        string[] sobrenome = new string[100];
        string[] tipoDeContato = new string [100];
        string[] telefone = new string [100];
        string[] email = new string [100];
        string[] bairro = new string [100];
        string[] cidade = new string[100];
        string[] estado = new string[100];
        string[] dataDeNascimento = new string [100];
        int[] codigo = new int[100];
        
        DateTime data = new DateTime(2008, 4, 10);
        
        int tl = 0, lastcod = 0, op = 0;


        static int ExibeMenu()
        {
            //Menu principal
            Console.WriteLine("------Agenda------");
            int op = 0;
            Console.Clear();
            Console.WriteLine(
                "Escolha uma das opções abaixo\n" +
                "1- Busca por primeiro nome\n" +
                "2- Busca por nome completo\n" +
                "3- Buscar por tipo de contato\n" +
                "4- Buscar por cidade\n" +
                "5- Inserir um contato\n" +
                "6- Remover um contato\n" +
                "7- Listar contatos\n" +
                "8-Sair");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        //Se escolher 3 tenho que fazer um if para colocar cada tipo de contato?
        //A opção 5 (Se a lista de contato estiver cheia - Mensagem ("Agenta cheia")

        while (op != 8)
        {
            op = ExibeMenu();
            if(op == 1) //Buscar por primeiro nome
            {
                Console.WriteLine("Dígite o nome: ");
                string buscar_nome = Console.ReadLine();
                int i = 0;
                for (i = 0; i < tl; i++)
                {
                    if (primeiroNome[i] == buscar_nome)
                    {
                        Console.Write("Código: " + codigo[i] +
                            " Nome Completo: " + primeiroNome[i] + " " + sobrenome[i] +
                            " Tipo de contato: " + tipoDeContato[i] +
                            " Telefone: " + telefone[i] +
                            " Email: " + email[i]);
                        Console.WriteLine();
                    }
                    /// Caso não encontre deve executar (Contato não localizado)
                    /// 
                    else Console.Write("Contato não localizado");
                    
                }
                
            }
            if(op == 2) //Buscar por nome completo
            {
                Console.WriteLine("Dígite o nome completo: ");
                string buscar_nomeCompleto = Console.ReadLine();
                int i = 0;
                for (i = 0; i < tl; i++)
                {
                    if (primeiroNome[i] + sobrenome[i] == buscar_nomeCompleto)
                    {
                        Console.Write("Código: " + codigo[i] +
                            " Nome Completo: " + primeiroNome[i] + " " + sobrenome[i] +
                            " Tipo de contato: " + tipoDeContato[i] +
                            " Telefone: " + telefone[i] +
                            " Email: " + email[i]);
                        Console.WriteLine();
                    }
                    /// Caso não encontre deve executar (Contato não localizado)

                }
            }
            if(op == 3) //Buscar por tipo de contato
            {
                Console.WriteLine("Dígite o tipo de contato: ");
                string buscar_tipoDeContato = Console.ReadLine();
                int i = 0;
                for (i = 0; i < tl; i++)
                {
                    if (tipoDeContato[i] == buscar_tipoDeContato)
                    {
                        Console.Write("Código: " + codigo[i] +
                            " Nome Completo: " + primeiroNome[i] + " " + sobrenome[i] +
                            " Tipo de contato: " + tipoDeContato[i] +
                            " Telefone: " + telefone[i] +
                            " Email: " + email[i]);
                        Console.WriteLine();
                    }
                    /// Caso não encontre deve executar (Contato não localizado)

                }
            }
            if(op == 4) //Buscar por cidade
            {
                Console.WriteLine("Dígite a cidade: ");
                string buscar_cidade = Console.ReadLine();
                int i = 0;
                for (i = 0; i < tl; i++)
                {
                    if (cidade[i] == buscar_cidade)
                    {
                        Console.Write("Código: " + codigo[i] +
                            " Nome Completo: " + primeiroNome[i] + " " + sobrenome[i] +
                            " Tipo de contato: " + tipoDeContato[i] +
                            " Telefone: " + telefone[i] +
                            " Email: " + email[i]);
                        Console.WriteLine();
                    }
                    /// Caso não encontre deve executar (Contato não localizado)

                }
            }
            if(op == 5) //Inserir um contato
            {
                Console.WriteLine("----Cadastrar contato----");
                Console.WriteLine("Nome: ");
                String p_nome = Console.ReadLine();
                Console.WriteLine("Sobrenome: ");
                String p_sobrenome = Console.ReadLine();
                Console.WriteLine("Tipo de contato: \n" + "Celular, Trabalho, Casa, Principal, Pager, Fax Trabalho, Fax Casa ou Outro");
                String p_tipoContato = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                String p_telefone = Console.ReadLine();
                Console.WriteLine("Email: ");
                String p_email = Console.ReadLine();
                Console.WriteLine("----Endereço----");
                Console.WriteLine("Bairro: ");
                String p_bairro = Console.ReadLine();
                Console.WriteLine("Cidade: ");
                String p_cidade = Console.ReadLine();
                Console.WriteLine ("Estado: ");
                String p_estado = Console.ReadLine();
                Console.WriteLine("Data de nascimento: " + data.ToString("dd/MM/yyyy"));
                String p_dataDeNascimento = Console.ReadLine();


                primeiroNome[tl] = p_nome;
                sobrenome[tl] = p_sobrenome;
                tipoDeContato[tl] = p_tipoContato;
                telefone[tl] = p_telefone;
                email[tl] = p_email;
                bairro[tl] = p_bairro;
                cidade[tl] = p_cidade;
                estado[tl] = p_estado;
                dataDeNascimento[tl] = p_dataDeNascimento;
                lastcod++;
                codigo[tl] = lastcod;
                tl++;


            }
            if (op == 6) //Remover um contato
            {
                Console.Write("Dígite o nome do contato: ");
                string buscar_nome = Console.ReadLine();
                int i = 0;
                for (i = 0; i < tl; i++)
                {
                    if (primeiroNome[i] == buscar_nome)
                    {
                        Console.Write("Código: " + codigo[i] +
                            " Nome Completo: " + primeiroNome[i] + " " + sobrenome[i] +
                            " Tipo de contato: " + tipoDeContato[i] +
                            " Telefone: " + telefone[i] +
                            " Email: " + email[i]);
                        Console.WriteLine();
                    }
                    /// Caso não encontre deve executar (Contato não localizado)
                    break;
                }
                Console.Write("");
                Console.Write("Qual o código do contato: ");
                int buscar_codigo = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < tl; i++)
                {
                    if (codigo[i] == buscar_codigo)
                    {
                        codigo[i] = codigo[i + 1];
                        primeiroNome[i] = primeiroNome[i + 1];
                        sobrenome[i] = sobrenome[i + 1];
                        tipoDeContato[i] = tipoDeContato[i + 1];
                        telefone[i] = telefone[i + 1];
                        email[i] = email[i + 1];
                        bairro[i] = bairro[i + 1];
                        cidade[i] = cidade[i + 1];
                        dataDeNascimento[i] = dataDeNascimento[i + 1];
                    }
                    tl--;
                    /// Caso não encontre deve executar (Contato não localizado)

                }
            }
            if (op == 7) //Listar contatos
            {
                Console.WriteLine("----Agenda----");
                for (int i = 0; i < tl; i++)
                {
                    Console.Write("Código: " + codigo[i] +
                        " Nome Completo: " + primeiroNome[i] + " " + sobrenome[i] +
                        " Tipo de contato: " + tipoDeContato[i] +
                        " Telefone: " + telefone[i] +
                        " Email: " + email[i]);
                    Console.WriteLine();
                }
            }
            if (op == 8) //Sair

            {

            }
            Console.ReadKey();

        }


    }
}

