﻿using System;
using System.IO;
using System.Collections.Generic;

namespace KryptographBibliothek
{
    public class Entfernen

    {
        public static string Zeichen_Entfernen()

        {
            string str = "_-A a k Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal. Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu. Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI-Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4-Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu (khur T.2.-Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo-Apalsu buk klu Lersbzpc-Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu-Rvuzvsl nlspliäbnlsa dlyklu. ";

            
            do
            {

                    Console.WriteLine("Eingabe:exit\t->\tZeichen Entfernen beendet");
                    Console.WriteLine("-------------------------------------------------");



                    Console.WriteLine("                                                                                                                     CHIFFRE");
                    Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");
                    Console.WriteLine(str);
                    Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");

                    Console.WriteLine("Welches zeichen wollen Sie davon Entfernt haben");
                    Console.Write("Eingabe:");



                string charsToRemove = Console.ReadLine();

                if (charsToRemove == "exit")
                {

                    Environment.Exit(0);

                }
                else
                {

                  




                    str = str.Replace(charsToRemove.ToLower(), "");

                    str = str.Replace(charsToRemove.ToUpper(), "");

                }



                Console.Clear();
            

            } while (true);


            return str;


        }
    }
}
