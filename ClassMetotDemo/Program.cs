// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;


Musteri musteri1 = new Musteri();
musteri1.Id = 001;
musteri1.Name = "Ömer Faruk";
musteri1.SecondName = "Didin";
musteri1.Yas = 20;

Musteri musteri2 = new Musteri();
musteri2.Id = 002;
musteri2.Name = "Hamit";
musteri2.SecondName = "Didin";
musteri2.Yas = 50;

Musteri musteri3 = new Musteri();
musteri3.Id = 003;
musteri3.Name = "Öznur";
musteri3.SecondName = "Didin";
musteri3.Yas = 48;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, };
foreach (var musteri in musteriler)
{
    Console.WriteLine(musteri.Name + " " + musteri.SecondName);
}

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add();
musteriManager.Add();
musteriManager.Add();
musteriManager.List();
musteriManager.Delete();
musteriManager.Delete();
musteriManager.Delete();



