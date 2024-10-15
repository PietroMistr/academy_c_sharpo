// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#if DEBUG
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Siamo in DEBUG, i vale " +i);
}
#endif

#if RELEASE
for(int i = 1; i<= 20;i++){
    Console.WriteLine("siamo in Release, i vale " + i);           
}
#endif
//MEGLIO METTERE MENO CODICE POSSIBILE NEGLI IF, IN MODO DI FARE POCHI CAMBIAMENTI IN CASO CI FOSSERO E
//NON DOVER CAMBIARE OGNI SINGOLO IF INTERAMENTE
//OPPURE PREFERIBILMENTE
 // int i = 10;

 // #if RELEASE
 //   i = 20;
 // #endif
 // for(int j = 1; j<= i;j++)
 // {
 //    Console.WriteLine(j.toString());
 // }
 //// OPPURE ANCORA MEGLIO FORSE
 // #if DEBUG
 // int i = 10;
 // #endif
  
 // #if RELEASE
 // int i = 20;
 // #endif
 // for(int j = 1; j<= i; j++)
 // {
 //   Console.WriteLine(j.toString());
 // }

