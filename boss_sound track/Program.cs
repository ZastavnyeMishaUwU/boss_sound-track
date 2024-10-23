namespace boss_sound_track
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Частоти нот
            const int D4 = 294;
            const int F4 = 349;
            const int G4 = 392;
            const int A4 = 440;
            const int B4 = 494;
            const int C5 = 523;

            



                Console.Beep(D4, 800);
                Console.Beep(D4, 800);
                Thread.Sleep(200);

                Console.Beep(F4, 700);
                Console.Beep(D4, 700);
                Thread.Sleep(200);

                Console.Beep(G4, 600);
                Console.Beep(F4, 600);
                Console.Beep(D4, 600);
                Thread.Sleep(200);

                Console.Beep(A4, 600);
                Console.Beep(G4, 600);
                Console.Beep(F4, 600);
                Thread.Sleep(200);


                Console.Beep(B4, 600);
                Console.Beep(A4, 600);
                Console.Beep(G4, 600);
                Thread.Sleep(200);


                Console.Beep(F4, 800);
                Console.Beep(E4, 800); 
                Thread.Sleep(200);

                Console.Beep(D4, 800);
                Console.Beep(C5, 800);
                Thread.Sleep(200);


                Console.Beep(B4, 700);
                Console.Beep(A4, 700);
                Console.Beep(G4, 700);
                Thread.Sleep(200);


                Console.Beep(D4, 1000);
            }
    }
}
