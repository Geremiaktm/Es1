int età;
float sogliaNaerobica ;
Console.WriteLine("inserire l'età; ");
età = Convert.ToInt16(Console.ReadLine());
sogliaNaerobica = (float)((220 - età) * 0.935);
Console.WriteLine("la tua soglia anaerobica è: " +sogliaNaerobica);
