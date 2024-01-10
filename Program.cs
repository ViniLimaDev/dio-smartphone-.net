using DesafioPOO.Models;

class Program{

    static void Main(){
        menu();
    }


    static void menu(){
        int seletor;
        Console.WriteLine("Bem vindo ao cadastro de smartphones, o que deseja realizar?");
        Console.WriteLine("1.Novo Cadastro\n2.Sair");
        seletor = int.Parse(Console.ReadLine());
        if (seletor == 1){
            int seletorSmartCadastro;
            Console.WriteLine("Qual modelo você quer cadastrar?");
            Console.WriteLine("1.Nokia\n2.Iphone\n3.Voltar");
            seletorSmartCadastro = int.Parse(Console.ReadLine());
            NovoCadastro(seletorSmartCadastro);
        }
    }

    static void NovoCadastro(int seletor){

        string numero = "";
        string modelo = "";
        string imei = "";
        int memoria = 0;

        if(seletor == 1 || seletor == 2){
            Console.WriteLine("Qual o número de telefone?");
            numero = Console.ReadLine();
            Console.WriteLine("Qual o modelo do telefone?");
            modelo = Console.ReadLine();
            Console.WriteLine("Qual o imei do telefone?");
            imei = Console.ReadLine();
            Console.WriteLine("Quantos Gigabytes de memória possui o telefone?");
            memoria = int.Parse(Console.ReadLine());
        }
        
        switch(seletor){
            case 1:
                Nokia smartNokia = new Nokia(numero, modelo, imei, memoria);
                Console.WriteLine($"Você cadastrou um smartphone Nokia {modelo} de numero {numero}, imei {imei} e {memoria}GB de memória");
                smartNokia.Ligar();
                smartNokia.ReceberLigacao();
                smartNokia.InstalarAplicativo("Whatsapp");
            break;
            case 2:
                Iphone smartIphone = new Iphone(numero, modelo, imei, memoria);
                Console.WriteLine($"Você cadastrou um smartphone Iphone {modelo} de numero {numero}, imei {imei} e {memoria}GB de memória");
                smartIphone.Ligar();
                smartIphone.ReceberLigacao();
                smartIphone.InstalarAplicativo("Telegram");
            break;
            default:
            break;
        }

        menu();
    }
 }