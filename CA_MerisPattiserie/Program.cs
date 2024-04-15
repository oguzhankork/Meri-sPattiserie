using BusinessLogic.Repostories;
namespace CA_MerisPattiserie
{
    class Program
    {
        public static void Main(string[] args) 
        { 
            MerisPattiserieRepostory merisPattiserieRepostory=new MerisPattiserieRepostory();
            foreach (var s in merisPattiserieRepostory.GetAll())
            {
                Console.WriteLine(s.CakeName);
            }
        }
    }
}
