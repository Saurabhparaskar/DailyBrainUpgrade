

namespace loopsproblems_upgrade.TypeCasting
{
    public class ImplicitCasting
    {

        int a = 10;
        Object obj;
      
        
            internal void Boxing() {
                obj = a;
            Console.WriteLine("Implicit Casting: " + obj);


        }
        internal void UnBoxing()
        {
            object ob = 10;
            int a = (int)ob;
            Console.WriteLine(a);

            object o = 's';
            char c = (char)o;
            Console.WriteLine(c);
        
        }


      


    }
}
