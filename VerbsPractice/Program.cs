using System;
using System.Collections.Generic;
namespace VerbsPractice
{
	public class MainClass
	{
		static List<Verb> _verbs;
		static string[] obj = new string[1];


		static void Error(string[] verbo)
		{
			string Path = System.Reflection.Assembly.GetEntryAssembly().Location;

			System.IO.File.AppendAllLines(Path+@"Mistakes.txt", verbo);
		}

		public static void Main(string[] args)
		{
			
			fill();
			Console.WriteLine("Welcome Sr. Antonio de Jesus Cortes Lagunes!!!");

			//PresentVerbsIrregulars();
			practiceIrregularsVerbs();


		}


		static void practiceRegularsVerbs()
		{
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

				if (Console.ReadLine() != i.PAST_PARTICIPLE)
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


		static void practiceIrregularsVerbs()
		{
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
				new Verb(){ INFINITIVE="TO DATE",     PAST="DATED",      PAST_PARTICIPLE="DATED",      PRESENT="DATE",      PRESENT_PARTICIPLE="DATING",       TRANSLATION="SALIR"      ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DELIVER",  PAST="DELIVERED",  PAST_PARTICIPLE="DELIVERED",  PRESENT="DELIVER",   PRESENT_PARTICIPLE="DELIVERING",   TRANSLATION="ENTREGAR"   ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DRESS",    PAST="DRESSED",    PAST_PARTICIPLE="DRESSED",    PRESENT="DRESS",     PRESENT_PARTICIPLE="DRESSING",     TRANSLATION="VESTIR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO END",      PAST="ENDED",      PAST_PARTICIPLE="ENDED",      PRESENT="END",       PRESENT_PARTICIPLE="ENDING",       TRANSLATION="TERMINAR"   ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ENJOY",    PAST="ENJOYED",    PAST_PARTICIPLE="ENJOYED",    PRESENT="ENJOY",     PRESENT_PARTICIPLE="ENJOYING",     TRANSLATION="DISFRUTAR"  ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO ERASE",    PAST="ERASED",     PAST_PARTICIPLE="ERASED",     PRESENT="ERASE",     PRESENT_PARTICIPLE="ERASING",      TRANSLATION="BORRAR"     ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO EXPECT",   PAST="EXPECTED",   PAST_PARTICIPLE="EXPECTED",   PRESENT="EXPECT",    PRESENT_PARTICIPLE="EXPECTING",    TRANSLATION="ESPERAR"    ,TIPO="REGULAR"},
				new Verb(){ INFINITIVE="TO DREAM",    PAST="DREAMT",     PAST_PARTICIPLE="DREAMT",     PRESENT="DREAM",     PRESENT_PARTICIPLE="DREAMING",     TRANSLATION="SOÑAR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO EAT",      PAST="ATE",        PAST_PARTICIPLE="EATEN",      PRESENT="EAT",       PRESENT_PARTICIPLE="EATING",       TRANSLATION="COMER"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO FINISH",   PAST="FINISHED",   PAST_PARTICIPLE="FINISHED",   PRESENT="FINISH",    PRESENT_PARTICIPLE="FINISHING",    TRANSLATION="TERMINAR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO SEE",      PAST="SAW",        PAST_PARTICIPLE="SEEN",       PRESENT="SEE",       PRESENT_PARTICIPLE="SEEING",       TRANSLATION="VER"        ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO REST",     PAST="RESTED",     PAST_PARTICIPLE="RESTED",     PRESENT="REST",      PRESENT_PARTICIPLE="RESTING",      TRANSLATION="DESCANSAR"  ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO KNOW",     PAST="KNEW",       PAST_PARTICIPLE="KNOWN",      PRESENT="KNOW",      PRESENT_PARTICIPLE="KNOWING",      TRANSLATION="CONOCER"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GO",       PAST="WENT",       PAST_PARTICIPLE="GONE",       PRESENT="GO",        PRESENT_PARTICIPLE="GOING",        TRANSLATION="IR"         ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO BEGIN",    PAST="BEGAN",      PAST_PARTICIPLE="BEGUN",      PRESENT="BEGIN",     PRESENT_PARTICIPLE="BEGINNING",    TRANSLATION="EMPEZAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO DRIVE",    PAST="DROVE",      PAST_PARTICIPLE="DRIVEN",     PRESENT="DRIVE",     PRESENT_PARTICIPLE="DRIVING",      TRANSLATION="MANEJAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO COME",     PAST="CAME",       PAST_PARTICIPLE="COME",       PRESENT="COME",      PRESENT_PARTICIPLE="COMING",       TRANSLATION="VENIR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO WRITE",    PAST="WROTE",      PAST_PARTICIPLE="WRITTEN",    PRESENT="WRITE",     PRESENT_PARTICIPLE="WRITING",      TRANSLATION="ESCRIBIR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO READ",     PAST="READ",       PAST_PARTICIPLE="READ",       PRESENT="READ",      PRESENT_PARTICIPLE="READING",      TRANSLATION="LEER"       ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO BE",       PAST="WAS/WERE",   PAST_PARTICIPLE="BEEN",       PRESENT="BE",        PRESENT_PARTICIPLE="BEING",        TRANSLATION="SER/ESTAR"  ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO CUT",      PAST="CUT",        PAST_PARTICIPLE="CUT",        PRESENT="CUT",       PRESENT_PARTICIPLE="CUTING",       TRANSLATION="CORTAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO FLY",      PAST="FLEW",       PAST_PARTICIPLE="FLOWN",      PRESENT="FLY",       PRESENT_PARTICIPLE="FLYING",       TRANSLATION="VOLAR"      ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO WALK",     PAST="WALKED",     PAST_PARTICIPLE="WALKED",     PRESENT="WALK",      PRESENT_PARTICIPLE="WALKING",      TRANSLATION="CAMINAR"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO TAKE",     PAST="TOOK",       PAST_PARTICIPLE="TAKEN",      PRESENT="TAKE",      PRESENT_PARTICIPLE="TAKING",       TRANSLATION="TOMAR DE LA MANO"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO STUDY",    PAST="STUDIED",    PAST_PARTICIPLE="STUDIED",    PRESENT="STUDY",     PRESENT_PARTICIPLE="STUDYING",     TRANSLATION="ESTUDIAR"   ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GET",      PAST="GOT",        PAST_PARTICIPLE="GOTTEN",     PRESENT="GET",       PRESENT_PARTICIPLE="GETTING",      TRANSLATION="OBTENER"    ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO SWIM",     PAST="SWAM",       PAST_PARTICIPLE="SWUM",       PRESENT="SWIM",      PRESENT_PARTICIPLE="SWIMMING",     TRANSLATION="NADAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO TEACH",     PAST="TAUGHT",    PAST_PARTICIPLE="TAUHT",      PRESENT="TEACH",     PRESENT_PARTICIPLE="TEACHING",     TRANSLATION="ENSEÑAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO LEANR",     PAST="LEARNED",   PAST_PARTICIPLE="LEARNED",    PRESENT="LEARN",     PRESENT_PARTICIPLE="LEARNING",     TRANSLATION="APRENDER"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO MOUNT",     PAST="MOUNTED",   PAST_PARTICIPLE="MOUNTED",    PRESENT="MOUNT",     PRESENT_PARTICIPLE="MOUNTING",     TRANSLATION="MONTAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GIVE",      PAST="GAVE",      PAST_PARTICIPLE="GIVEN",      PRESENT="GIVE",      PRESENT_PARTICIPLE="GIVING",       TRANSLATION="DAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO DRINK",     PAST="DRANK",     PAST_PARTICIPLE="DRUNK",      PRESENT="DRINK",     PRESENT_PARTICIPLE="DRINKING",     TRANSLATION="TOMAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO CATCH",     PAST="CAUGHT",    PAST_PARTICIPLE="CAUGHT",     PRESENT="CATCH",     PRESENT_PARTICIPLE="CATCHING",     TRANSLATION="ATRAPAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO FIND",      PAST="FOUND", 	 PAST_PARTICIPLE="FOUND",      PRESENT="FIND",      PRESENT_PARTICIPLE="FINDING",      TRANSLATION="ENCONTRAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO STEAL",     PAST="STOLE",     PAST_PARTICIPLE="STOLEN",     PRESENT="STEAL",     PRESENT_PARTICIPLE="STEALING",     TRANSLATION="ROBAR"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO HOLD",      PAST="HELD",      PAST_PARTICIPLE="HELD",       PRESENT="HOLD",      PRESENT_PARTICIPLE="HOLDING",      TRANSLATION="SOSTENER"     ,TIPO="IREGULAR"},
				new Verb(){ INFINITIVE="TO GET WET",   PAST="GOT WET",   PAST_PARTICIPLE="I'VE BEEN WET",PRESENT="GET WET", PRESENT_PARTICIPLE="GETTING WET",     TRANSLATION="NADAR"     ,TIPO="IREGULAR"},
				};

		}

	}
}
