public class Program
{
    public static void Main(string[] args)
    {
        //KODE POS
        Console.WriteLine("Masukkan nama kelurahan: ");
        string kel = Console.ReadLine();

        KodePos kp = new KodePos();
        int kode = kp.getKodePos(kel);

        Console.WriteLine("Kode Pos: " + kode);

        Console.WriteLine();

        //DOOR MACHINE
        DoorMachine.Main2();
    }
}

public class KodePos
{
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

public class  DoorMachine
{
    public enum State { TERKUNCI, TERBUKA }
    public static void Main2()
    {

        State state = State.TERKUNCI;
        if(state == State.TERKUNCI)
        {
            System.Console.WriteLine("Pintu terkunci");
        }
        else
        {
            System.Console.WriteLine("Pintu tidak terkunci");
        }
        Console.WriteLine(bukaPintu(state));
        Console.WriteLine(kunciPintu(state));
    }

    public static string kunciPintu(State state)
    {
        if(state == State.TERKUNCI)
        {
            return "Pintu sudah terkunci";
        }
        else
        {
            return "Pintu terkunci";
        }
    }
    public static string bukaPintu(State state)
    {
        if (state == State.TERKUNCI)
        {
            return "Pintu tidak terkunci";
        }
        else
        {
            return "Pintu sudah terbuka";
        }
    }
}