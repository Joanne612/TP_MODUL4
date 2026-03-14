public class KodePos
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Masukkan nama kelurahan: ");
        string kel = Console.ReadLine();

        KodePos kp = new KodePos();
        int kode = kp.getKodePos(kel);

        System.Console.WriteLine("Kode Pos: " + kode);
    }
    public int getKodePos(string kelurahan)
    {
        int[] kodePos = {40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274};
        string[] Kelurahan = {"Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer"};

        for(int i = 0; i < Kelurahan.Length; i++)
        {
            if(kelurahan == Kelurahan[i])
            {
                return kodePos[i];
            }
        }
        return 0;
    }
}
