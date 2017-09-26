using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace VerbsPractice
{
	public class MainClass
	{
		static List<Verb> _verbs;
		static string[] obj = new string[1];


		static void Error(string[] verbo)
		{
			string Path = System.Reflection.Assembly.GetEntryAssembly().Location;

			System.IO.File.AppendAllLines(Path + @"Mistakes.txt", verbo);
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome Sr. Antonio de Jesus Cortes Lagunes!!!");

			int op;
			do
			{
				Console.Clear();
				Console.WriteLine("[ 1 ] Practice Irregular Verbs easy way");
				Console.WriteLine("[ 2 ] Practice Regular Verbs easy way");
				Console.WriteLine("[ 3 ] Practice Irregular Verbs hard way");
				Console.WriteLine("[ 4 ] Practice Regular Verbs hard way");
				Console.WriteLine("[ 0 ] Exit");
				Console.WriteLine("-------------------------------------");
				Console.Write("Write an option: ");

				if(Int32.TryParse(Console.ReadLine(),out op)){
					switch (op)
					{
						case 1:
							practiceIrregularsVerbs();
							break;
						case 2:
							practiceRegularsVerbs();
							break;
						case 3:
							practiceIrregularCompleteVerbs();
							break;
						case 4:
							practiceRegularCompleteVerbs();
							break;
						default:
							System.Environment.Exit(0);
							break;
					}
					Console.ReadKey();
					Console.Clear();
				}


			}
			while (op != 0);

		}






		static void practiceRegularsVerbs()
		{
			fill();
			String answer = "";
			foreach (var i in _verbs)
			{
				Console.WriteLine("VERB: " + i.TRANSLATION);

				Console.WriteLine("INFINITIVE: ");

				answer = Console.ReadLine().Trim();

				if (answer != i.INFINITIVE.Trim())
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERROR EN EL VERBO  " + i.INFINITIVE);

					obj[0] = "[" + DateTime.Now.ToString() + "] [INFINITIVE] ["+i.INFINITIVE+"] ["+answer+"] ";

					Error(obj);
				}

				Console.WriteLine("PAST : ");

				answer = Console.ReadLine().Trim();

				if (answer != i.PAST)
				{
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("ERROR EN EL VERBO  " + i.PAST);
					obj[0] = "[" + DateTime.Now.ToString() + "] [PAST] [" + i.PAST + "] [" + answer + "] ";
					Error(obj);
				}

				Console.WriteLine("PAST PARTICIPLE : ");

				answer = Console.ReadLine().Trim();

				if (answer != i.PAST_PARTICIPLE)
				{
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("ERROR EN EL VERBO  " + i.PAST_PARTICIPLE);
					obj[0] = "[" + DateTime.Now.ToString() + "] [PAST_PARTICIPLE] [" + i.PAST_PARTICIPLE + "] [" + answer + "] ";
					Error(obj);
				}

				Console.WriteLine("PRESENT : ");

				answer = Console.ReadLine().Trim();

				if (answer != i.PRESENT)
				{
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("ERROR EN EL VERBO  " + i.PRESENT);
					obj[0] = "[" + DateTime.Now.ToString() + "] [PRESENT] [" + i.PRESENT + "] [" + answer + "] ";
					Error(obj);
				}

				Console.WriteLine("GERUND : ");

				answer = Console.ReadLine().Trim();

				if (answer != i.PRESENT_PARTICIPLE)
				{
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("ERROR EN EL VERBO  " + i.PRESENT_PARTICIPLE);
					obj[0] = "[" + DateTime.Now.ToString() + "] [PRESENT_PARTICIPLE] [" + i.PRESENT_PARTICIPLE + "] [" + answer + "] ";
					Error(obj);
				}
			}//FIN FOREACH

			Console.WriteLine("finish ..!!!");
		}
		static void PresentVerbsIrregulars()
		{

			Console.WriteLine("------Irregular Verbs------");
			Console.WriteLine("");
			int ip = 0;
			while (ip<10)
			{
				foreach (var i in _verbs)
				{
					if (i.TIPO == "IREGULAR")
					{
						Console.WriteLine("");
						Console.WriteLine("VERB: " + i.TRANSLATION);
						Console.WriteLine("");
						Console.ReadLine();
						Console.WriteLine("INFINITIVE FORM:  " + i.INFINITIVE);
						Console.WriteLine("");
						Console.ReadLine();
						Console.WriteLine("PAST FORM:  " + i.PAST);
						Console.WriteLine("");
						Console.ReadLine();
						Console.WriteLine("PRESENT FORM:  " + i.PRESENT);
						Console.WriteLine("");
						Console.ReadLine();
						Console.WriteLine("PAST PARTICIPLE FORM:  " + i.PAST_PARTICIPLE);
						Console.WriteLine("");
						Console.ReadLine();
						Console.WriteLine("PRESENT PARTICIPLE FORM:  " + i.PRESENT_PARTICIPLE);

					}
				}//FIN FOREACH
				ip++;
			}
			Console.WriteLine("finish ..!!!");
		}

		#region irregularVerbs
		static void practiceIrregularsVerbs()
		{
			fill();
			String answer = "";
			int ip = 0;
			while (ip < 1)
			{
				foreach (var i in _verbs)
				{
					if (i.TIPO == "IREGULAR")
					{

						Console.WriteLine("VERB: " + i.TRANSLATION);

						Console.WriteLine("INFINITIVE: ");

						answer = Console.ReadLine().Trim();

						if (answer != i.INFINITIVE.Trim())
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("ERROR EN EL VERBO  " + i.INFINITIVE);

							obj[0] = "[" + DateTime.Now.ToString() + "] [INFINITIVE] [" + i.INFINITIVE + "] [" + answer + "] ";

							Error(obj);
						}

						Console.WriteLine("PAST : ");

						answer = Console.ReadLine().Trim();

						if (answer != i.PAST)
						{
							Console.ForegroundColor = ConsoleColor.Red;

							Console.WriteLine("ERROR EN EL VERBO  " + i.PAST);
							obj[0] = "[" + DateTime.Now.ToString() + "] [PAST] [" + i.PAST + "] [" + answer + "] ";
							Error(obj);
						}

						Console.WriteLine("PAST PARTICIPLE : ");

						answer = Console.ReadLine().Trim();

						if (answer != i.PAST_PARTICIPLE)
						{
							Console.ForegroundColor = ConsoleColor.Red;

							Console.WriteLine("ERROR EN EL VERBO  " + i.PAST_PARTICIPLE);
							obj[0] = "[" + DateTime.Now.ToString() + "] [PAST_PARTICIPLE] [" + i.PAST_PARTICIPLE + "] [" + answer + "] ";
							Error(obj);
						}

						Console.WriteLine("PRESENT : ");

						answer = Console.ReadLine().Trim();

						if (answer != i.PRESENT)
						{
							Console.ForegroundColor = ConsoleColor.Red;

							Console.WriteLine("ERROR EN EL VERBO  " + i.PRESENT);
							obj[0] = "[" + DateTime.Now.ToString() + "] [PRESENT] [" + i.PRESENT + "] [" + answer + "] ";
							Error(obj);
						}

						Console.WriteLine("GERUND : ");

						answer = Console.ReadLine().Trim();

						if (answer != i.PRESENT_PARTICIPLE)
						{
							Console.ForegroundColor = ConsoleColor.Red;

							Console.WriteLine("ERROR EN EL VERBO  " + i.PRESENT_PARTICIPLE);
							obj[0] = "[" + DateTime.Now.ToString() + "] [PRESENT_PARTICIPLE] [" + i.PRESENT_PARTICIPLE + "] [" + answer + "] ";
							Error(obj);
						}
					}//FIN FOREACH
				}
				ip++;
			}
			obj[0] = "[" + DateTime.Now.ToString() + "] "+" Termino de ejercicio correcto ";
			Console.WriteLine("finish ..!!!");
		}
#endregion


		static void fill_error_1()
        {

            _verbs = new List<Verb>()
            {
                new Verb(){ INFINITIVE="TO DREAM",    PAST="DREAMT",     PAST_PARTICIPLE="DREAMT",     PRESENT="DREAM",     PRESENT_PARTICIPLE="DREAMING",     TRANSLATION="SOÑAR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO BEGIN",    PAST="BEGAN",      PAST_PARTICIPLE="BEGUN",      PRESENT="BEGIN",     PRESENT_PARTICIPLE="BEGINNING",    TRANSLATION="EMPEZAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GO",       PAST="WENT",       PAST_PARTICIPLE="GONE",       PRESENT="GO",        PRESENT_PARTICIPLE="GOING",        TRANSLATION="IR"         ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO FINISH",   PAST="FINISHED",   PAST_PARTICIPLE="FINISHED",   PRESENT="FINISH",    PRESENT_PARTICIPLE="FINISHING",    TRANSLATION="TERMINAR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO COME",     PAST="CAME",       PAST_PARTICIPLE="COME",       PRESENT="COME",      PRESENT_PARTICIPLE="COMING",       TRANSLATION="VENIR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO DRIVE",    PAST="DROVE",      PAST_PARTICIPLE="DRIVEN",     PRESENT="DRIVE",     PRESENT_PARTICIPLE="DRIVING",      TRANSLATION="MANEJAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO BE",       PAST="WAS/WERE",   PAST_PARTICIPLE="BEEN",       PRESENT="BE",        PRESENT_PARTICIPLE="BEING",        TRANSLATION="SER/ESTAR"  ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO KNOW",     PAST="KNEW",       PAST_PARTICIPLE="KNOWN",      PRESENT="KNOW",      PRESENT_PARTICIPLE="KNOWING",      TRANSLATION="CONOCER"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO WRITE",    PAST="WROTE",      PAST_PARTICIPLE="WRITTEN",    PRESENT="WRITE",     PRESENT_PARTICIPLE="WRITING",      TRANSLATION="ESCRIBIR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO FLY",      PAST="FLEW",       PAST_PARTICIPLE="FLOWN",      PRESENT="FLY",       PRESENT_PARTICIPLE="FLYING",       TRANSLATION="VOLAR"      ,TIPO="IREGULAR"},

			};
		}



		static void practiceIrregularCompleteVerbs(){
			
		}
		static void practiceRegularCompleteVerbs()
		{

		}



		static void fill()
		{
			/*
			soñar--
            comer--
            terminar--
            ver--
            descansar--
            conocer--
            ir--
            comenzar--
            manejar--
            venir--
            escribir-
            leer-
            ser/estar-
            cortar-
            volar-
            caminar-
            tomar de la mano-
            estudiar-
            conseguir-obtener-
            nadar-
			enseñar
            comprender-
            montar-
            dar-
            beber-
            vender-
            atrapar-
            encontrar-
            robar-
            sostener-
            mojarse-




			invitar
            nacer
			escuchar
            jugar
            costar
            llamar
            dejar-abandonar
            despertar
            saber-conocer
            respetar
            obedecer
            pagar
            repetir
            entregar
            probarse ropa
            levantarse
            averiguar
            ponerse ropa
            volver a llamar
            ver tv
            comprar
            pensar
            aprender
            preguntar
            escoger
            explicar

			*/
			_verbs = new List<Verb>()
			{	
				new Verb(){ INFINITIVE="TO ACCEPT",   PAST="ACCEPTED",   PAST_PARTICIPLE="ACCEPTED",   PRESENT="ACCEPT",    PRESENT_PARTICIPLE="ACCEPTING",    TRANSLATION="ACEPTAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ANSWER",   PAST="ANSWERED",   PAST_PARTICIPLE="ANSWERED",   PRESENT="ANSWER",    PRESENT_PARTICIPLE="ANSWERING",    TRANSLATION="RESPONDER"  ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ANNOUNCE", PAST="ANNOUNCED",  PAST_PARTICIPLE="ANNOUNCED",  PRESENT="ANNOUNCE",  PRESENT_PARTICIPLE="ANNOUNCING",   TRANSLATION="ANUNCIAR"   ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ARRIVE",   PAST="ARRIVED",    PAST_PARTICIPLE="ARRIVED",    PRESENT="ARRIVE",    PRESENT_PARTICIPLE="ARRIVING",     TRANSLATION="LLEGAR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ASK",      PAST="ASKED",      PAST_PARTICIPLE="ASKED",      PRESENT="ASK",       PRESENT_PARTICIPLE="ASKING",       TRANSLATION="PREGUNTAR"  ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO BELONG",   PAST="BELONGED",   PAST_PARTICIPLE="BELONGED",   PRESENT="BELONG",    PRESENT_PARTICIPLE="BELONGING",    TRANSLATION="PERTENECER" ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO BOTHER",   PAST="BOTHERED",   PAST_PARTICIPLE="BOTHERED",   PRESENT="BOTHER",    PRESENT_PARTICIPLE="BOTHERING",    TRANSLATION="MOLESTAR"   ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO CHANGE",   PAST="CHANGED",    PAST_PARTICIPLE="CHANGED",    PRESENT="CHANGE",    PRESENT_PARTICIPLE="CHANGING",     TRANSLATION="CAMBIAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO CLEAN",    PAST="CLEANED",    PAST_PARTICIPLE="CLEANED",    PRESENT="CLEAN",     PRESENT_PARTICIPLE="CLEANING",     TRANSLATION="LIMPIAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO CLIMB",    PAST="CLIMBED",    PAST_PARTICIPLE="CLIMBED",    PRESENT="CLIMB",     PRESENT_PARTICIPLE="CLIMBING",     TRANSLATION="ESCALAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO CLOSE",    PAST="CLOSED",     PAST_PARTICIPLE="CLOSED",     PRESENT="CLOSE",     PRESENT_PARTICIPLE="CLOSING",      TRANSLATION="CERRAR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO CONSIDER", PAST="CONSIDERED", PAST_PARTICIPLE="CONSIDERED", PRESENT="CONSIDER",  PRESENT_PARTICIPLE="CONSIDERING",  TRANSLATION="CONSIDERAR" ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO COOK",     PAST="COOKED",     PAST_PARTICIPLE="COOKED",     PRESENT="COOK",      PRESENT_PARTICIPLE="COOKING",      TRANSLATION="COCINAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO COUNT",    PAST="COUNTED",    PAST_PARTICIPLE="COUNTED",    PRESENT="COUNT",     PRESENT_PARTICIPLE="COUNTING",     TRANSLATION="CONTAR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DANCE",    PAST="DANCED",     PAST_PARTICIPLE="DANCED",     PRESENT="DANCE",     PRESENT_PARTICIPLE="DANCING",      TRANSLATION="BAILAR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DARE",     PAST="DARED",      PAST_PARTICIPLE="DARED",      PRESENT="DARE",      PRESENT_PARTICIPLE="DARING",       TRANSLATION="ATREVERSE"  ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DATE",     PAST="DATED",      PAST_PARTICIPLE="DATED",      PRESENT="DATE",      PRESENT_PARTICIPLE="DATING",       TRANSLATION="SALIR CON ALGUIEN"      ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DELIVER",  PAST="DELIVERED",  PAST_PARTICIPLE="DELIVERED",  PRESENT="DELIVER",   PRESENT_PARTICIPLE="DELIVERING",   TRANSLATION="ENTREGAR"   ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DRESS",    PAST="DRESSED",    PAST_PARTICIPLE="DRESSED",    PRESENT="DRESS",     PRESENT_PARTICIPLE="DRESSING",     TRANSLATION="VESTIR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO END",      PAST="ENDED",      PAST_PARTICIPLE="ENDED",      PRESENT="END",       PRESENT_PARTICIPLE="ENDING",       TRANSLATION="TERMINAR"   ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ENJOY",    PAST="ENJOYED",    PAST_PARTICIPLE="ENJOYED",    PRESENT="ENJOY",     PRESENT_PARTICIPLE="ENJOYING",     TRANSLATION="DISFRUTAR"  ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ERASE",    PAST="ERASED",     PAST_PARTICIPLE="ERASED",     PRESENT="ERASE",     PRESENT_PARTICIPLE="ERASING",      TRANSLATION="BORRAR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO EXPECT",   PAST="EXPECTED",   PAST_PARTICIPLE="EXPECTED",   PRESENT="EXPECT",    PRESENT_PARTICIPLE="EXPECTING",    TRANSLATION="ESPERAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DREAM",    PAST="DREAMT",     PAST_PARTICIPLE="DREAMT",     PRESENT="DREAM",     PRESENT_PARTICIPLE="DREAMING",     TRANSLATION="SOÑAR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO FINISH",   PAST="FINISHED",   PAST_PARTICIPLE="FINISHED",   PRESENT="FINISH",    PRESENT_PARTICIPLE="FINISHING",    TRANSLATION="TERMINAR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO REST",     PAST="RESTED",     PAST_PARTICIPLE="RESTED",     PRESENT="REST",      PRESENT_PARTICIPLE="RESTING",      TRANSLATION="DESCANSAR"  ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO KNOW",     PAST="KNEW",       PAST_PARTICIPLE="KNOWN",      PRESENT="KNOW",      PRESENT_PARTICIPLE="KNOWING",      TRANSLATION="CONOCER"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GO",       PAST="WENT",       PAST_PARTICIPLE="GONE",       PRESENT="GO",        PRESENT_PARTICIPLE="GOING",        TRANSLATION="IR"         ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO BEGIN",    PAST="BEGAN",      PAST_PARTICIPLE="BEGUN",      PRESENT="BEGIN",     PRESENT_PARTICIPLE="BEGINNING",    TRANSLATION="EMPEZAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO DRIVE",    PAST="DROVE",      PAST_PARTICIPLE="DRIVEN",     PRESENT="DRIVE",     PRESENT_PARTICIPLE="DRIVING",      TRANSLATION="MANEJAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO COME",     PAST="CAME",       PAST_PARTICIPLE="COME",       PRESENT="COME",      PRESENT_PARTICIPLE="COMING",       TRANSLATION="VENIR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO WRITE",    PAST="WROTE",      PAST_PARTICIPLE="WRITTEN",    PRESENT="WRITE",     PRESENT_PARTICIPLE="WRITING",      TRANSLATION="ESCRIBIR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO BE",       PAST="WAS/WERE",   PAST_PARTICIPLE="BEEN",       PRESENT="BE",        PRESENT_PARTICIPLE="BEING",        TRANSLATION="SER/ESTAR"  ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO CUT",      PAST="CUT",        PAST_PARTICIPLE="CUT",        PRESENT="CUT",       PRESENT_PARTICIPLE="CUTING",       TRANSLATION="CORTAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO WALK",     PAST="WALKED",     PAST_PARTICIPLE="WALKED",     PRESENT="WALK",      PRESENT_PARTICIPLE="WALKING",      TRANSLATION="CAMINAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO STUDY",    PAST="STUDIED",    PAST_PARTICIPLE="STUDIED",    PRESENT="STUDY",     PRESENT_PARTICIPLE="STUDYING",     TRANSLATION="ESTUDIAR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GET",      PAST="GOT",        PAST_PARTICIPLE="GOTTEN",     PRESENT="GET",       PRESENT_PARTICIPLE="GETTING",      TRANSLATION="OBTENER"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO SWIM",     PAST="SWAM",       PAST_PARTICIPLE="SWUM",       PRESENT="SWIM",      PRESENT_PARTICIPLE="SWIMMING",     TRANSLATION="NADAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO TEACH",     PAST="TAUGHT",    PAST_PARTICIPLE="TAUHT",      PRESENT="TEACH",     PRESENT_PARTICIPLE="TEACHING",     TRANSLATION="ENSEÑAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO LEANR",     PAST="LEARNED",   PAST_PARTICIPLE="LEARNED",    PRESENT="LEARN",     PRESENT_PARTICIPLE="LEARNING",     TRANSLATION="APRENDER"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO MOUNT",     PAST="MOUNTED",   PAST_PARTICIPLE="MOUNTED",    PRESENT="MOUNT",     PRESENT_PARTICIPLE="MOUNTING",     TRANSLATION="MONTAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO CATCH",     PAST="CAUGHT",    PAST_PARTICIPLE="CAUGHT",     PRESENT="CATCH",     PRESENT_PARTICIPLE="CATCHING",     TRANSLATION="ATRAPAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO STEAL",     PAST="STOLE",     PAST_PARTICIPLE="STOLEN",     PRESENT="STEAL",     PRESENT_PARTICIPLE="STEALING",     TRANSLATION="ROBAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO HOLD",      PAST="HELD",      PAST_PARTICIPLE="HELD",       PRESENT="HOLD",      PRESENT_PARTICIPLE="HOLDING",      TRANSLATION="SOSTENER"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GET WET",   PAST="GOT WET",   PAST_PARTICIPLE="I'VE BEEN WET",PRESENT="GET WET", PRESENT_PARTICIPLE="GETTING WET",     TRANSLATION="NADAR"     ,TIPO="IREGULAR"},






				new Verb(){
					INFINITIVE="TO GROW",
					PAST="GREW",
					PAST_PARTICIPLE="GROWN",
					PRESENT="GROW",
					PRESENT_PARTICIPLE="GROWING",
					TRANSLATION="CRECER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "",
					EXAMPLE_PAST = "",
					EXAMPLE_PAST_PARTICIPLE = ""
				},



				new Verb(){ 
					INFINITIVE="TO FLY",
					PAST="FLEW",
					PAST_PARTICIPLE="FLOWN",
					PRESENT="FLY",
					PRESENT_PARTICIPLE="FLYING",
					TRANSLATION="VOLAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Vicky hates to fly",
					EXAMPLE_PAST = "We flew from atlanta to Fort Lauderdale in an/one hour",
					EXAMPLE_PAST_PARTICIPLE = "We have never flown before"
				},

				new Verb(){
					INFINITIVE="TO BREAK",
					PAST="BROKE",
					PAST_PARTICIPLE="BROKEN",
					PRESENT="BREAK",
					PRESENT_PARTICIPLE="BREAKING",
					TRANSLATION="ROMPER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "You're gonna break your neck",
					EXAMPLE_PAST = "I think i broke my glasses",
					EXAMPLE_PAST_PARTICIPLE = "You have broken my heart"
				},

				new Verb(){
					INFINITIVE="TO DO",
					PAST="DID",
					PAST_PARTICIPLE="DONE",
					PRESENT="BREAK",
					PRESENT_PARTICIPLE="BREAKING",
					TRANSLATION="ROMPER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Do the best you can",
					EXAMPLE_PAST = "You did good",
					EXAMPLE_PAST_PARTICIPLE = "The carpenter has done a great job"
				},



				new Verb(){
					INFINITIVE="TO KNOW",
					PAST="KNEW",
					PAST_PARTICIPLE="KNOWN",
					PRESENT="KNOW",
					PRESENT_PARTICIPLE="KNOWING",
					TRANSLATION="CONOCER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Do you know what's going on?",
					EXAMPLE_PAST = "I knew you'd say that",
					EXAMPLE_PAST_PARTICIPLE = "We have known Billy since he was just a little kid"
				},

				new Verb(){
					INFINITIVE="TO SELL",
					PAST="SOLD",
					PAST_PARTICIPLE="SOLD",
					PRESENT="SELL",
					PRESENT_PARTICIPLE="SEELING",
					TRANSLATION="VENDER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Johny wants to sell his car",
					EXAMPLE_PAST = "They sold all of the girsl Scouts cookies",
					EXAMPLE_PAST_PARTICIPLE = "The neighbors has sold their house"
				},



				new Verb(){
					INFINITIVE="TO LEAVE",
					PAST="LEFT",
					PAST_PARTICIPLE="LEFT",
					PRESENT="LEAVE",
					PRESENT_PARTICIPLE="LEAVING",
					TRANSLATION="PARTIR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "What time do we leave?",
					EXAMPLE_PAST = "They left earlier this morning",
					EXAMPLE_PAST_PARTICIPLE = "Elvis has left the building"
				},


				new Verb(){ 
					INFINITIVE="TO TAKE",
					PAST="TOOK",
					PAST_PARTICIPLE="TAKEN",
					PRESENT="TAKE",
					PRESENT_PARTICIPLE="TAKING",
					TRANSLATION="TOMAR DE LA MANO",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "I'll take it",
					EXAMPLE_PAST = "Tim took mary home",
					EXAMPLE_PAST_PARTICIPLE = "They have taken all the puppies"
				},


				new Verb(){ 
					INFINITIVE="TO SIT",
					PAST="SAT",
					PAST_PARTICIPLE="SAT",
					PRESENT="SIT",
					PRESENT_PARTICIPLE="SITING",
					TRANSLATION="SENTARSE",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Please sit down",
					EXAMPLE_PAST = "She sat down and waited",
					EXAMPLE_PAST_PARTICIPLE ="She has sat down"
				},
				new Verb(){
					INFINITIVE="TO BUY",
					PAST="BOUGHT",
					PAST_PARTICIPLE="BOUGHT",
					PRESENT="BUY",
					PRESENT_PARTICIPLE="BUYING",
					TRANSLATION="COMPRAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "You need to buy a new phone",
					EXAMPLE_PAST = "Elizabeth bought two tickets",
					EXAMPLE_PAST_PARTICIPLE ="Jim has bought a new pair of shoes"
				},
				new Verb(){
					INFINITIVE="TO STAND",
					PAST="STOOD",
					PAST_PARTICIPLE="STOOD",
					PRESENT="STAND",
					PRESENT_PARTICIPLE="STANDING",
					TRANSLATION="PONERSE DE PIE",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Please stand up",
					EXAMPLE_PAST = "They stood by the lake",
					EXAMPLE_PAST_PARTICIPLE ="He has stood you up"
				},
				new Verb(){
					INFINITIVE="TO RIDE",
					PAST="RODE",
					PAST_PARTICIPLE="RIDDEN",
					PRESENT="RIDE",
					PRESENT_PARTICIPLE="RIDING",
					TRANSLATION="MONTAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "I'm going to ride my motorcycle o work",
					EXAMPLE_PAST = "He rode the bus to school",
					EXAMPLE_PAST_PARTICIPLE ="He has ridden a bicycle before"
				},
				new Verb(){
					INFINITIVE="TO CHOOSE",
					PAST="CHOSE",
					PAST_PARTICIPLE="CHOSEN",
					PRESENT="CHOOSE",
					PRESENT_PARTICIPLE="CHOOSING",
					TRANSLATION="ESCOGER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Which one do I choose?",
					EXAMPLE_PAST = "She chose the honda",
					EXAMPLE_PAST_PARTICIPLE ="You have chosen the best plan"
				},
				new Verb(){
					INFINITIVE="TO FALL",
					PAST="FELL",
					PAST_PARTICIPLE="FALLEN",
					PRESENT="FALL",
					PRESENT_PARTICIPLE="FALLING",
					TRANSLATION="CAER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Be careful, don't fall",
					EXAMPLE_PAST = "They fell for it",
					EXAMPLE_PAST_PARTICIPLE ="I have fallen, and I can't get up"
				},

				new Verb(){ 
					INFINITIVE="TO DRINK",
					PAST="DRANK",
					PAST_PARTICIPLE="DRUNK",
					PRESENT="DRINK",
					PRESENT_PARTICIPLE="DRINKING",
					TRANSLATION="TOMAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Drink water",
					EXAMPLE_PAST = "I drank plenty of water",
					EXAMPLE_PAST_PARTICIPLE = "They have drunk i whole gallon of milk"
				},


				new Verb(){
					INFINITIVE="TO SLEEP",
					PAST="SLEPT",
					PAST_PARTICIPLE="SLEPT",
					PRESENT="SLEEP",
					PRESENT_PARTICIPLE="SLEEPING",
					TRANSLATION="DORMIR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "I can't sleep with the lights on",
					EXAMPLE_PAST = "He slept like a baby",
					EXAMPLE_PAST_PARTICIPLE = "he has slept all day"
				},


				new Verb(){ 
					INFINITIVE="TO READ",
					PAST="READ",
					PAST_PARTICIPLE="READ",
					PRESENT="READ",
					PRESENT_PARTICIPLE="READING",
					TRANSLATION="LEER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "I can't read without my glasses",
					EXAMPLE_PAST = "I read your message",
					EXAMPLE_PAST_PARTICIPLE ="He has read all the reports"},




				new Verb(){
					INFINITIVE="TO WEAR",
					PAST="WORE",
					PAST_PARTICIPLE="WORN",
					PRESENT="WEAR",
					PRESENT_PARTICIPLE="WEARING",
					TRANSLATION="PROBARTE ALGO",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "You have to wear Dress shoes",
					EXAMPLE_PAST = "She wore her new dress to the party",
					EXAMPLE_PAST_PARTICIPLE = "Peter has worn the same shirt for days"
				},
				new Verb(){ 
					INFINITIVE="TO SEE",
					PAST="SAW",
					PAST_PARTICIPLE="SEEN",
					PRESENT="SEE",
					PRESENT_PARTICIPLE="SEEING",
					TRANSLATION="VER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "You can see the wall of china from space",
					EXAMPLE_PAST = "I saw you at the store yesterday",
					EXAMPLE_PAST_PARTICIPLE = "I think i have seen you before"
				},

				new Verb(){ 
					INFINITIVE="TO FIND",
					PAST="FOUND",
					PAST_PARTICIPLE="FOUND",
					PRESENT="FIND",
					PRESENT_PARTICIPLE="FINDING",
					TRANSLATION="ENCONTRAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "It's hard to find good Help nowadays",
					EXAMPLE_PAST = "Look what I found",
					EXAMPLE_PAST_PARTICIPLE ="He has found true love"
				},



				new Verb(){
					INFINITIVE="TO LOOSE",
					PAST="LOST",
					PAST_PARTICIPLE="LOST",
					PRESENT="LOOSE",
					PRESENT_PARTICIPLE="LOOSING",
					TRANSLATION="PERDER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Don't lose your keys",
					EXAMPLE_PAST = "Sam lost the keys to the house",
					EXAMPLE_PAST_PARTICIPLE ="they have lost the bet"
				},
				new Verb(){
					INFINITIVE="TO WIN",
					PAST="WON",
					PAST_PARTICIPLE="WON",
					PRESENT="WIN",
					PRESENT_PARTICIPLE="WINING",
					TRANSLATION="GANAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Enter to win a thousand dollars",
					EXAMPLE_PAST = "Kate won a hundred dollars",
					EXAMPLE_PAST_PARTICIPLE ="They have won the contest"
				},
				new Verb(){
					INFINITIVE="TO HEAR",
					PAST="HEARD",
					PAST_PARTICIPLE="HEARD",
					PRESENT="HEAR",
					PRESENT_PARTICIPLE="HEARING",
					TRANSLATION="ESCUCHAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Turn it up, I can't hear it",
					EXAMPLE_PAST = "I heard what you said",
					EXAMPLE_PAST_PARTICIPLE ="Have you heard the news?"
				},
				new Verb(){
					INFINITIVE="TO FEEL",
					PAST="FELT",
					PAST_PARTICIPLE="FELT",
					PRESENT="FEEL",
					PRESENT_PARTICIPLE="FEELING",
					TRANSLATION="",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "How do you feel",
					EXAMPLE_PAST = "I felt happy",
					EXAMPLE_PAST_PARTICIPLE ="She has felt weak all day"
				},


				new Verb(){ 
					INFINITIVE="TO EAT",
					PAST="ATE",
					PAST_PARTICIPLE="EATEN",
					PRESENT="EAT",
					PRESENT_PARTICIPLE="EATING",
					TRANSLATION="COMER",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Jhony, eat your dinner",
					EXAMPLE_PAST = "I already ate",
					EXAMPLE_PAST_PARTICIPLE ="She hasn't eaten her lunch yet"
				},

				new Verb(){
					INFINITIVE="TO FROGET",
					PAST="FORGOT",
					PAST_PARTICIPLE="FORGOTTEN",
					PRESENT="FORGET",
					PRESENT_PARTICIPLE="FORGETTING",
					TRANSLATION="OLVIDAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Don't forget to wash your hands",
					EXAMPLE_PAST = "I forgot i had a dentist appoiment",
					EXAMPLE_PAST_PARTICIPLE ="Becky has forgotten her password"
				},

				new Verb(){ 
					INFINITIVE="TO GIVE",
					PAST="GAVE",
					PAST_PARTICIPLE="GIVEN",
					PRESENT="GIVE",
					PRESENT_PARTICIPLE="GIVING",
					TRANSLATION="DAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Here's a houndred dollars, i can give you the rest friday",
					EXAMPLE_PAST = "I gave you a hundred dollars monday, here's the other hundred",
					EXAMPLE_PAST_PARTICIPLE ="This car has given me a lot of trouble"
				},

				new Verb(){
					INFINITIVE="TO SEND",
					PAST="SENT",
					PAST_PARTICIPLE="SENT",
					PRESENT="SEND",
					PRESENT_PARTICIPLE="SENDING",
					TRANSLATION="MANDAR",
					TIPO="IREGULAR",
					EXAMPLE_PRESENT = "Send me an email",
					EXAMPLE_PAST = "I sent you an email",
					EXAMPLE_PAST_PARTICIPLE = "They have sent him to the office twice this week"
				},

				};





		}

	}
}
