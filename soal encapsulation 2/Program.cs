using soal_encapsulation_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Biodata tunggul = new Biodata("tunggul", "teknologi informasi");
        tunggul.Nim = 2058;
        tunggul.tampilkanBiodata();
    }
}