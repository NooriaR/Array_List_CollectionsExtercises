//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MethodCollections
//{
//    internal class ArrayExersice
//    {
//        // Be användaren ange hur många tal som ska lagras.
//        private int antalTal;

//        public ArrayExersice()
//        {
//            Console.WriteLine("Ange hur många tal som ska lagras:");
//            antalTal = Convert.ToInt32(Console.ReadLine());


//            //Skapa en int[] med den storleken.
//            int[] talArray = new int[antalTal];

//            //Be användaren mata in varje tal och spara det i arrayen.
//            for (int i = 0; i < talArray.Length; i++)
//            {
//                Console.WriteLine($"Ange tal nummer {i + 1}:");
//                talArray[i] = Convert.ToInt32(Console.ReadLine());

//            }

//            //Skriv ut alla tal som användaren matade in.
//            Console.WriteLine("De tal som matades in är:");
//            foreach (int tal in talArray)
//            {
//                Console.WriteLine(tal);
//            }
//        }
////    }
//}
