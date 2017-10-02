//with if/else
namespace VowelOrDigit
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            char character = char.Parse(Console.ReadLine());
            if ((char)character == 'a' || (char)character == 'e' || (char)character == 'i' || (char)character == 'o' || (char)character == 'u' || (char)character == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if ((char) character == '0' || (char) character == '1' || (char) character == '2' ||
                     (char) character == '3' || (char) character == '4' || (char) character == '5' ||
                     (char) character == '6' || (char) character == '7' || (char) character == '8' ||
                     (char) character == '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

////with switch/case
//namespace VowelOrDigit
//{
//    using System;
//    public class StartUp
//    {
//        public static void Main()
//        {
//            char character = char.Parse(Console.ReadLine());
//            switch (character)
//            {
//                case 'a':
//                    Console.WriteLine("vowel");
//                    break;
//                case 'e':
//                    Console.WriteLine("vowel");
//                    break;
//                case 'i':
//                    Console.WriteLine("vowel");
//                    break;
//                case 'o':
//                    Console.WriteLine("vowel");
//                    break;
//                case 'u':
//                    Console.WriteLine("vowel");
//                    break;
//                case 'y':
//                    Console.WriteLine("vowel");
//                    break;
//                case '0':
//                    Console.WriteLine("digit");
//                    break;
//                case '1':
//                    Console.WriteLine("digit");
//                    break;
//                case '2':
//                    Console.WriteLine("digit");
//                    break;
//                case '3':
//                    Console.WriteLine("digit");
//                    break;
//                case '4':
//                    Console.WriteLine("digit");
//                    break;
//                case '5':
//                    Console.WriteLine("digit");
//                    break;
//                case '6':
//                    Console.WriteLine("digit");
//                    break;
//                case '7':
//                    Console.WriteLine("digit");
//                    break;
//                case '8':
//                    Console.WriteLine("digit");
//                    break;
//                case '9':
//                    Console.WriteLine("digit");
//                    break;
//                default:
//                    Console.WriteLine("other");
//                    break;
//            }
//        }
//    }
//}
