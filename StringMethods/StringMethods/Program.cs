using System;
using System.Text;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sizin Yazdiqlariniz
            //int a = 5;

            //int b = a;

            //b = 18;

            //Console.WriteLine(a + "----" + b);


            //int [] numbers1 = { 1, 3, 4, 5, 6, 7, 8 };

            //int[] numbers2 = numbers1;

            //numbers2[0] = 99;

            //Console.WriteLine(numbers1[0] + " " + numbers2[0]);



            //int num = 13;

            //Console.WriteLine(num);

            //num += 3;

            //ShowNum(num);

            //Console.WriteLine(num);



            //int num;  //= 13; --------> Ancaq Ref yazanda da value vere bilerik 

            ////num += 5;

            //ShowNum(out num);

            //num += 2;

            //Console.WriteLine(num);



            //int num =10;  //= 13; --------> Ancaq Ref yazanda da value vere bilerik 

            ////num += 5;

            //ShowNum(ref num);

            //num += 2;

            //Console.WriteLine(num);



            //string name1 = "Qoshqar";

            //string name2 = name1;

            ////name1 = "Ramil";

            //name2 = "Cavid";

            //Console.WriteLine(name1);

            //Console.WriteLine(name2);





            //string name1; /*= "Qoshqar";*/
            //CheckStr(/*ref*/out name1);
            //Console.WriteLine(name1);




            /*
                        string str1 = "Cav";

                        string str2 = "id";

                        string name = str1 + str2;

                        Console.WriteLine(name);

                        StringBuilder str = new StringBuilder();


                        str.Append("Cav");

                        str.Append("id");


                        Console.WriteLine(str);*/

            //String name1 = new String("Lale");
            //Console.WriteLine(name1);


            ////Int32 num = new Int32();

            //int num = 55;

            //Boolean IsMarried = new Boolean();




            /*string name = "Ramil";*/  /*Azer*/

            //name = "";

            //name = String.Empty;


            //Console.WriteLine(name.Length);

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}


            //Console.WriteLine(name/*.Trim()*/);

            //Console.WriteLine(name.StartsWith("R"));

            //Console.WriteLine(name.EndsWith("R"));

            //Console.WriteLine(name.ToLower());

            //Console.WriteLine(name.ToUpper());

            //string name = "Hello Ramil";

            //name.ToLower();

            //if (name.Trim().ToLower().StartsWith("R"))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            /*Console.WriteLine(name.IndexOf("a"));*/

            //Console.WriteLine(name.LastIndexOf("a"));

            //Console.WriteLine(name.Replace("Ramil","Resul"));

            //Console.WriteLine(name.Remove(4,3));

            //Console.WriteLine(name.Substring(3));

            //var result = name.Split("");

            ////Console.WriteLine(result);

            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = name.ToCharArray();


            //string[] words = { "one" , "two" , "three" };

            //Console.WriteLine(string.Join("?",words)) ;


            /*string text = ""; */ //null olsa yes cixacaq

            //if ( string.IsNullOrEmpty(text) )
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}


            //if (string.IsNullOrWhiteSpace(text))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion

            //*****************************************************************
            /*                                                                *
             __      _       _______       _          __          _           *
            ||\\    ||      ||______|      \\        //\\        //           *
            || \\   ||      ||____          \\      //  \\      //            *
            ||  \\  ||      ||____|          \\    //    \\    //             *
            ||   \\ ||      ||______          \\  //      \\  //              *
            ||    \\||      ||______|          \\//        \\//               *
                                                                              */
            //******************************************************************

            //             Concat Method :
            //                   ||
            //                 \ || /
            //                  \||/
            /*                   \/
                        string a = "Hello";

                        string b = "World";

                        Console.WriteLine(string.Concat(a,b));*/



            //             Contains Method :
            //                   ||
            //                 \ || /
            //                  \||/
            /*                   \/
                        string a = "HelloWorld";
            
                        string b = "World";
            
                        Console.WriteLine(a.Contains(b));*/



            //             Insert Method : 
            //                   ||
            //                 \ || /
            //                  \||/
            //                   \/
            /*          string a = "Hello";

                        string b = a.Insert(3, "_World_");  //HANSI INDEKSDEN SONRA YERLESDIRECEYIN SOZU QEYD EDIRSEN.

                        Console.WriteLine(b);*/






            //             PadRight Method : // PadLeft de eyni ile soldan ara qoyur.
            //                   ||
            //                 \ || /
            //                  \||/
            /*                   \/
                        string s1 = "Hello C#"; 
            
                        string s2 = s1.PadRight(10);
            
                        Console.Write(s2);  
            
                        Console.Write("JavaTpoint");*/








            //             Compare Method :
            //                   ||
            //                 \ || /
            //                  \||/
            /*                   \/
                        string s1 = "hello";

                        string s2 = "hello";
            
                        string s3 = "csharp";
            
                        Console.WriteLine(s1.CompareTo(s2));
            
                        Console.WriteLine(s2.CompareTo(s3));*/

        }

        #region Sizin yazdiginiz Methodlar//public static void CheckStr(/*ref*/out string str)
        //{
        //    str = "Mahir";

        //    str += "- Cavid";

        //    Console.WriteLine(str);
        //}

        //********************************************************************************************

        //public static void ShowNum(out int num)
        //{
        //    num = 100;

        //    num += 2;

        //    Console.WriteLine(num);
        //}
        #endregion

    }
}
