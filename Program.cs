namespace _5_Polimorphisim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çok biçimlilik ==> base üyelerinin alt sınıflarda davranışlarının değiştirilme yaklaşımıdır..
            
            //  Miras alan sınıf, miras veren sınıf gibi davranır. bazı durumlarda miras alan sınıfın üyeleri baseden gelen üyeye göre farklılık gösterebilir. bu farklılıklar çok biçimlilik olarak adlandırılır.


            Calisan c = new Calisan();
            c.Dusunce();

            Patron p = new Patron();
            p.Dusunce();

            Insan i = new Insan();
            i.Dusunce();

            Goster(c);
            Goster(p);
           
            Console.ReadKey();
        }

        public static void Goster(Insan ins)
        {
            Console.WriteLine($"Kimlik No : {ins.KimlikNo}");
            ins.Dusunce();
        }

    }
}