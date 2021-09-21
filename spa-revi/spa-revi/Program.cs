using System;


namespace spa_revi
{
    public class Program
    {
    static void Main(string[] args)
        {
//welcome message
                Console.WriteLine("Welcome to spanish review for tomorrows exam(9-22); to initiate the program input: initiate");
            Console.WriteLine("");

            //program initiation sequence(intial inputs)
            string iniSi = Console.ReadLine();
             if (iniSi == "initiate"){

                Console.WriteLine("Access granted.");
                Console.WriteLine("");
             }

             else
            {
                Console.WriteLine("access denied");
               
            }
            
//initiation guard(loop) in disguise as a function
/*
             void guard()
            {

                //loop itself (for loop)

                while (iniSi == "initiate")
                {
                    continue;
                }

            }
*/

//array containing available commands
                string[] comms = { 
                //0
                "1. intro",
                //1
                "2. estructuras-narrativas",
                //2
                "3. tipos-narrador",
                //3
                "4. estructura-texto-narrativo",
                
            };

//list commands prompt
            Console.WriteLine("");
            Console.WriteLine("input 'ls' to list available commands");
            Console.WriteLine("");
            string lst = Console.ReadLine();
            if (lst == "ls")
            {
                Console.WriteLine(comms[0]);
                Console.WriteLine(comms[1]);
                Console.WriteLine(comms[2]);
                Console.WriteLine(comms[3]);
            }
            //take input of desired command. Chain of if/else(that didn't work) because me no likey switch statement.
            Console.WriteLine("");
            Console.WriteLine("input one of the listed commands for its contents(without the number);");
            Console.WriteLine("");
            string in0 = Console.ReadLine();
                if(in0 == "intro"){
                Console.WriteLine("");
                funks.oNe();
            }

            Console.WriteLine("another one please");
            string in1 = Console.ReadLine();
            if (in1 == "estructuras-narrativas")
            {
                Console.WriteLine("");
                funks.tWo();
            }
            //divideR
        
            Console.WriteLine("another one please");
            string in2 = Console.ReadLine();
            if (in2 == "tipos-narrador")
            {
                Console.WriteLine("");
                funks.thRee();
            }
                //divideR

            Console.WriteLine("another one please");
            string in3 = Console.ReadLine();
            if (in3 == "estructura-texto-narrativo")
            {
                Console.WriteLine("");
                funks.foUr();
            }

            //end of programmePp

            Console.WriteLine("good luck on the test.");

            /*
                       else {
                            Console.WriteLine("input another one of the listed commands for its contents;");
                        }

                        string in1 = Console.ReadLine();
                        if (in1 == "estructuras-narrativas"){
                            funks.oNe();
                        }
                        else{
                            Console.WriteLine("input another one of the listed commands for its contents;");
                        }
                        string in2 = Console.ReadLine();
                        if (in2 == "tipos-narrador"){
                            funks.tWo();
                        }
                        else{
                            Console.WriteLine("input another one of the listed commands for its contents;");
                        }
                        string in3 = Console.ReadLine();
                        if (in3 == "estructura-texto-narrativo"){
                            funks.thRee();
                        }
                        else{
                            Console.WriteLine("end of the road kid.");
                        }
            */
        }
    }
//class containing all function referencing for concept/term knowledge
    public class funks
    {

        //divided in titles (the command titles)

//intro
        public static void oNe(){
            
                static void zero()
            {
                Console.WriteLine("_El examen se basa en 3 temas principales:");
                Console.WriteLine("+Las estructuras narrativas + Los tipos de narrador + La estructura de un texto narrativo");
            }
            zero();
        }
//estructuras-narrativas
        public static void tWo(){
                
                static void OnE()
            {

                Console.WriteLine("generos literarios narrativos");
                Console.WriteLine("");
                Console.WriteLine("¿Que son?");
                Console.WriteLine("");
                Console.WriteLine("son los distintos grupos o categorias en que podemos clasificar las obras literarias para atender su contenido; se agrupan en generos de acuerdo a su contenido y a la forma en que estan escritos.");
                Console.WriteLine("");
                Console.WriteLine("se dividen en:");
                Console.WriteLine("");
                Console.WriteLine("1. narrativo: ");
                Console.WriteLine("");
                Console.WriteLine(" Obras literarias que cuentan una historia imaginada por su autor y protagonizada por unos personajes, en un tiempo y lugar, determinados...pertenecen al genero narrativo.");
                Console.WriteLine("");
                Console.WriteLine("caracteristicas: ");
                Console.WriteLine("");
                Console.WriteLine("+pueden estar en verso o en prosa");
                Console.WriteLine("");
                Console.WriteLine("+hay un narrador, que es quien cuenta la historia(omnisciente o protagonista.)");
                Console.WriteLine("");
                Console.WriteLine("2. lirico: ");
                Console.WriteLine("");
                Console.WriteLine("Obras literarias que hablan de emociones, sentimientos, estados de animo como si fueran del propio autor.");
                Console.WriteLine("");
                Console.WriteLine("ejemplos:");
                Console.WriteLine("");
                Console.WriteLine("1. lirica tradicional: ");
                Console.WriteLine("");
                Console.WriteLine("autor desconocido, transmicion oral, metrica sencilla");
                Console.WriteLine("");
                Console.WriteLine("2. lirica (o)culta");
                Console.WriteLine("");
                Console.WriteLine("autor desconocido, transmicion escrita, metrica mas elaborada");
                Console.WriteLine("");
                Console.WriteLine("Caracteristicas: ");
                Console.WriteLine("");
                Console.WriteLine("+escritas... generalmente en verso.");
                Console.WriteLine("");
                Console.WriteLine("+empleo del ritmo y la rima");
                Console.WriteLine("");
                Console.WriteLine("+uso de recursos del lenguaje figurado");
                Console.WriteLine("");
                Console.WriteLine("+Pueden tratas temas como: el amor, la naturaleza, el dolor, los sentimientos morales, y religiosos, la patria, los objetos cotidianos.");
                Console.WriteLine("");
                Console.WriteLine("2. dramatico");
                Console.WriteLine("");
                Console.WriteLine("obras literarias que nacen para ser representadas. no hay autor. la historia se conoce a traves de los dialogos de los personajes.");
                Console.WriteLine("");
                Console.WriteLine("subgeneros: ");
                Console.WriteLine("");
                Console.WriteLine("1. tragedia:");
                Console.WriteLine("");
                Console.WriteLine("trata asuntos graves o dolorosos y su desenlace es siempre desgraciado.");
                Console.WriteLine("");
                Console.WriteLine("2. comedia: ");
                Console.WriteLine("");
                Console.WriteLine("hechos felices o humoristicos y su desenlace es feliz.");
                Console.WriteLine("");
                Console.WriteLine("3. tragicomedia: ");
                Console.WriteLine("");
                Console.WriteLine("combina elementos tragicos y comicos.");
                Console.WriteLine("");
                Console.WriteLine("caracteristicas: ");
                Console.WriteLine("");
                Console.WriteLine("+tipos textuales: dialogo y monologo");
                Console.WriteLine("");
                Console.WriteLine("+acotaciones: indicaciones de la puesta en escena y de la forma de actuar los personajes.");
                Console.WriteLine("");
                Console.WriteLine("+elementos visuales: gestos, movimientos, luces, vestuario.");
                Console.WriteLine("");
                Console.WriteLine("+elementos sonoros: ruidos y musica.");
                Console.WriteLine("");
                Console.WriteLine("Terminos: ");
                Console.WriteLine("");
                Console.WriteLine("-cuento: ");
                Console.WriteLine("");
                Console.WriteLine("relata un suceso de trama sencilla y con pocos personajes.");
                Console.WriteLine("");
                Console.WriteLine("-Leyenda:");
                Console.WriteLine("");
                Console.WriteLine("Las leyendas narran eventos fantasticos.");
                Console.WriteLine("");
                Console.WriteLine("-fabula:");
                Console.WriteLine("");
                Console.WriteLine("son relatos de ficcion con una moraleja.");
                Console.WriteLine("");
                Console.WriteLine("-mito:");
                Console.WriteLine("");
                Console.WriteLine("narran sucesesos maravillosos sobre el origen de las cosas");
                Console.WriteLine("");
                Console.WriteLine("-novela:");
                Console.WriteLine("");
                Console.WriteLine("narracion extensa.");
                Console.WriteLine("");
                Console.WriteLine("conclusion: ");
                Console.WriteLine("");
                Console.WriteLine("1|para expresar sentimientos.(genero lirico{habla el autor[yo]}");
                Console.WriteLine("");
                Console.WriteLine("2|para contar historias.(genero narrativo{habla el autor y los personajes[narrador]})");
                Console.WriteLine("");
                Console.WriteLine("3|para representar en un escenario(genero dramatico{hablan los personajes[actores]})");
                Console.WriteLine("");
                Console.WriteLine("4|para mostrar opiniones(genero ensayistico{habla el autor[real]})");
                }
            OnE();
            }
        //tipos-narrador
       public static void thRee(){

                static void TwO()
            {

                Console.WriteLine("El narrador");
                Console.WriteLine("");
                Console.WriteLine("El el genero narrativo , la intencionalidad del autor es contar lo que les sucede a unos personajes.");
                Console.WriteLine("");
                Console.WriteLine("La narracion se concreta por medio del narrador o voz narrativa. ");
                Console.WriteLine("");
                Console.WriteLine("Narrador y autor no son lo mismo.");
                Console.WriteLine("");
                Console.WriteLine("El autor es el creador del texto, es tanto que el narrador es una instancia del texto que inventa el autor.");
                Console.WriteLine("");
                Console.WriteLine("El narrador es la entidad que relata una histora.");
                Console.WriteLine("");
                Console.WriteLine("Es himportante distinguir al narrador del escritor real.");
                Console.WriteLine("");
                Console.WriteLine("El narrador no es una persona real sino una entidad abstracta. ");
                Console.WriteLine("");
                Console.WriteLine("Por eso, en algunos casos el narrador puede ser el protagonista mismo de la historia; es decir, un personaje ficticio.");
                Console.WriteLine("");
                Console.WriteLine("Los narradores pueden clasificarse segun la persona que en mayor medida en su narracion.");
                Console.WriteLine("");
                Console.WriteLine("se clasifican en: ");
                Console.WriteLine("");
                Console.WriteLine("focos_narrativos");
                Console.WriteLine("");
                Console.WriteLine("[1]. Primera persona");
                Console.WriteLine("");
                Console.WriteLine("Se utiliza para narrar los hechos desde el punto de vista del protagonista o de alguno de los personajes involucrados en la historia.");
                Console.WriteLine("");
                Console.WriteLine("En estors casos se habla de narrador interno, es decir, pertenece al mundo imaginario de la narracion.");
                Console.WriteLine("");
                Console.WriteLine("[2]. Segunda persona");
                Console.WriteLine("");
                Console.WriteLine("Se utiliza para crear un oyente o lector real o imaginario.");
                Console.WriteLine("");
                Console.WriteLine("Tambien se utiliza en los dialogos, pero en ese caso no es el narrador quien habla");
                Console.WriteLine("");
                Console.WriteLine("[3]. Tercera persona");
                Console.WriteLine("");
                Console.WriteLine("Se utiliza cuando no se quiere involucrar el narrador en lo que se cuenta.");
                Console.WriteLine("");
                Console.WriteLine("Tipos de narradores: ");
                Console.WriteLine("");
                Console.WriteLine("[1]. narrador omnisciente: aquel que se caracteriza por contar una historia en 3ra persona}");
                Console.WriteLine("");
                Console.WriteLine("[2]. narrador testigo: aquel que cuenta los hechos que ocurren dentro de una historia desde su punto de vista.");
                Console.WriteLine("");
                Console.WriteLine("[3]. narrador protagonista: narrador presente en relatos literariosy de otra naturaleza, que se da la tarea de contar la trama en primera persona.	");
                Console.WriteLine("");
                Console.WriteLine("[4]. narrador equisciente: aquel que relata la historia usando la 3ra persona, pero unicamente desde el punto de vista de un personaje.");
                Console.WriteLine("");
                Console.WriteLine("[5]. narrador deficiente: testigo que relata de forma objectiva solo lo que percibe a traves  de sus sentidos sin emitir opiniones acerca de lo que esta presenciando.");
                }
            TwO();
            }
//estructura-texto-narrativo
       public static void foUr(){

                static void ThreE()
            {

                Console.WriteLine("El texto narrativo consta de x tipos de estructura: ");
                Console.WriteLine("");
                Console.WriteLine("[1]orden cronologico: ");
                Console.WriteLine("");
                Console.WriteLine("se divide en 3: ");
                Console.WriteLine("");
                Console.WriteLine("-inicio(inicio, accion ascendiente)");
                Console.WriteLine("");
                Console.WriteLine("-exposicions(climax, accion)");
                Console.WriteLine("");
                Console.WriteLine("-desarrollo(accion descendiente, desenlace)");
                Console.WriteLine("");
                Console.WriteLine("ANOMALIAS SOBRE LA ESTRUCTURA: ");
                Console.WriteLine("");
                Console.WriteLine("objetivo: se refiere a cortar las acciones de unos personajes.");
                Console.WriteLine("");
                Console.WriteLine("Marco: se refiere a tiempo y lugar de la histora.");
            }
            ThreE();
        }

    }
}
