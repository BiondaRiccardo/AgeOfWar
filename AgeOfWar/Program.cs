// See https://aka.ms/new-console-template for more information
using AgeOfWar.Personaggi;

Cavaliere CavNero = new Cavaliere(500);
Cavaliere[] SquadraNera = new Cavaliere[100];
for (int i = 0; i <= 100; i++)
{
    SquadraNera[i] = new Cavaliere(500);
    SquadraNera[i].Squadra = "Squadra nera";
}