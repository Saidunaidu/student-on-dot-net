namespace vv
{
    class Vote
    {
        public static void Main (String[] args)
        {
            string name, ad,email,userid,ps;
            int s,a, ph, age, aa,id;
            Console.WriteLine("              VOTER REGISTRATION            ");
            Console.WriteLine("            ------------------------          ");
            Console.WriteLine();
            Console.WriteLine("     WELCOME TO THE VOTE REGISTER PORTAL  ");
            Console.WriteLine("    --------------------------------------  ");
            Console.WriteLine();
            Console.WriteLine("   ARE YOU NEW REGISTER  ?");
            Console.WriteLine("  -----------------------");
            Console.WriteLine();
            Console.WriteLine("1.YES \n2.no");
            Console.WriteLine();
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine(" WELCOME TO THE VOTER ID REGISTER PORTAL");
                Console.WriteLine();
                Console.Write("NAME : ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("FATHER NAME : ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("MOTHER NAME : ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write(" age of the new voter id person : ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Aadhar number : ");
                aa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Mobile Number : ");
                ph = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Address of the person: ");
                ad = Console.ReadLine();
                Console.WriteLine();
                Console.Write("E MAIL ID: ");
                email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the Voter id number: ");
                id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
            }
            else if (a == 2)
            {
                Console.WriteLine("log into the voter id portal");
            }
            else
            {
                Console.WriteLine("no users exists");
            }
            Console.WriteLine("age of the person");
            Console.WriteLine();
            age= Convert.ToInt32(Console.ReadLine());
            
            if (age <= 18)
            {
                Console.WriteLine("you were not eligible for vote");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("  you will be not eligible for vote");
                Console.WriteLine("----------------------------------------");
                               
            }
            Console.WriteLine("LOG IN");
            Console.WriteLine();
            Console.Write("USER ID: ");
            userid= Console.ReadLine(); 
            Console.WriteLine();
            Console.Write("PASSWORD: ");
            ps= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("     LogIn Successfully   ");
            Console.WriteLine() ;
            Console.WriteLine("you have to choose the party right to vote");
            Console.WriteLine("1.jananesa ,\n 2.tdp \n 3.ycp");
            Console.WriteLine();
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Console.WriteLine("janasena party");
                Console.WriteLine();
            }
            else if (s == 2)
            {
                Console.WriteLine("tdp party");
                Console.WriteLine();
            }
            else
            {
                {
                    Console.WriteLine("ycp party");
                    Console.WriteLine();
                }
                Console.WriteLine("      THANK YOU FOR VOTING     ");
            }


        }



    }
}















