namespace CA20200114
{
    class Jatekos
    {
        public string Nev { get; set; }
        public int[] Tippek { get; set; }
        public Jatekos(string sor)
        {
            var t = sor.Split(' ');

            Nev = t[0];

            Tippek = new int[t.Length - 1];
            for (int i = 0; i < Tippek.Length; i++)
                Tippek[i] = int.Parse(t[i + 1]);
        }
    }
}
