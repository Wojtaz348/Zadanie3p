﻿List<produkt> produkty = new List<produkt>();
List<Magazyn> magazyny = new List<Magazyn>();

Adres adres1 = new Adres("kolorowa", "90-421", "radom", "1b", "45");
Adres adres2 = new Adres("czarna", "58-695", "poznan", "46", "41h");
Adres adres3 = new Adres("mokra", "41-422", "lodz", "10", "11/4");
Adres adres4 = new Adres("rowerowa", "22-134", "katowice", "291", "7a");
Adres adres5 = new Adres("poprzeczna", "53-310", "czestochowa", "41", "2a");
produkt iphone = new produkt("apple", "iphone 15pro", "telefon", "48951", 32000, "najlepsza telefon na rynku");
Adres adresMagazynu = new Adres("Ul. Morska 12", "10-133", "Warszawa", "10", "C");
{
    Console.WriteLine("<--MENU-->");
    Console.WriteLine("Wybierz opcje:");
    Console.WriteLine("1. Dodaj/Edytuj/Usun - Magazyn");
    Console.WriteLine("2. Dodaj/Edytuj/Usun - produkt");
    Console.WriteLine("3. Dodaj/Usun - produkt z Magazynu");
    Console.WriteLine("4. Wyjscie");


    string wybor = Console.ReadLine();
    switch (wybor)
    {
        case "1":
            Console.WriteLine("<MAGAZYN");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj");
            Console.WriteLine("2. Edytuj");
            Console.WriteLine("3. Usun");
            Console.WriteLine("4. Wyswietl magazyny");
            Console.WriteLine("5. Wyjscie");
            string wybor1 = Console.ReadLine();
            switch (wybor1)
            {
                case "1":
                    Console.WriteLine("dodaj");
                    break;
                case "2":
                    Console.WriteLine("edytuj");
                    break;
                case "3":
                    Console.WriteLine("usun");
                    break;
                case "4":
                    Console.WriteLine("wyswietl");
                    break;
                case "5":
                    Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("nieprawidlowy wybor");
                    break;
            }
            break;
        case "2":
            Console.WriteLine("PRODUKT");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj");
            Console.WriteLine("2. Edytuj");
            Console.WriteLine("3. Usun");
            Console.WriteLine("4. Wyswietl produkty");
            Console.WriteLine("5. Wyjscie");
            string wybor2 = Console.ReadLine();
            switch (wybor2)
            {
                case "1":
                    dodaj_z_magazynu();
                    break;
                case "2":
                    Console.WriteLine("edytuj");
                    break;
                case "3":
                    Console.WriteLine("usun");
                    break;
                case "4":
                    Console.WriteLine("wyswietl");
                    break;
                case "5":
                    Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wybor jest nieprawidlowy");
                    break;
            }
            break;
        case "3":
            Console.WriteLine("PRODUKT Z MAGAZYNU");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj");
            Console.WriteLine("2. Usun");
            Console.WriteLine("3. Wyswietl produkty w magazynie");
            Console.WriteLine("4. Wyjscie");
            string wybor3 = Console.ReadLine();
            switch (wybor3)
            {
                case "1":
                    //dodajProduktDoMagazynu();
                case "2":
                    //usunProduktDoMagazynu();
                case "3":
                    //wyswietlProduktyWMagazynie();
                case "4":
                    Console.WriteLine("Porgram zostanie pomyslnie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" wybor nieprawidlowy ");
                    break;
            }
            break;
        case "4":
            Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
            break;
        default:
            Console.WriteLine("wybor nieprawidlowy ");
            break;

    }
    static void dodaj_z_magazynu()
    {
        Console.WriteLine("DODAWANIE PRODUKTU");
        Console.WriteLine("Dodaj nazwe producenta:");
        string nazwaProducenta = Console.ReadLine();
        Console.WriteLine("Dodaj nazwe produktu:");
        string nazwaProduktu = Console.ReadLine();
        Console.WriteLine("Dodaj kategorie:");
        string kategoria = Console.ReadLine();
        Console.WriteLine("Dodaj kod produktu:");
        string kodProduktu = Console.ReadLine();
        Console.WriteLine("Dodaj cene:");
        if (int.TryParse(Console.ReadLine(), out int cena))
        {
            Console.WriteLine("Podaj opis produktu:");
            string opis = Console.ReadLine();
            produkt nowy = new produkt(nazwaProducenta, nazwaProduktu, kategoria, kodProduktu, cena, opis);
            Console.WriteLine("Produkt pomyslnie zostal dodny");
        }
        else
        {
            Console.WriteLine("Nieprawidlowe cena produktu. Produkt nie zostanie  dodany pomyslnie");
        }





        static void dodaj_produkt()
        {
            Console.WriteLine("DODAWANIE PRODUKTU");
            Console.WriteLine("Dodaj nazwe producenta:");
            string nazwaProducenta = Console.ReadLine();
            Console.WriteLine("Dodaj nazwe produktu:");
            string nazwaProduktu = Console.ReadLine();
            Console.WriteLine("Dodaj kategorie:");
            string kategoria = Console.ReadLine();
            Console.WriteLine("Dodaj kod produktu:");
            string kodProduktu = Console.ReadLine();
            Console.WriteLine("Dodaj cene:");
            if (int.TryParse(Console.ReadLine(), out int cena))
            {
                Console.WriteLine("Podaj opis produktu:");
                string opis = Console.ReadLine();
                produkt nowy = new produkt(nazwaProducenta, nazwaProduktu, kategoria, kodProduktu, cena, opis);
                Console.WriteLine("Produkt pomyslnie zostal dodny");
            }
            else
            {
                Console.WriteLine("Nieprawidlowe cena produktu. Produkt nie zostanie  dodany pomyslnie");
            }
        }

    }
    }
    


public
 class Adres
{
    public string ulica;
    public string kodPocztowy;
    public string miejscowosc;
    public string numerLokalu;
    public string numerPosesji;
    public Adres(string ulica, string kodPocztowy, string
miejscowosc, string numerLokalu, string numerPosesji)
    {
        this.ulica = ulica;
        this.kodPocztowy = kodPocztowy;
        this.miejscowosc = miejscowosc;
        this.numerLokalu = numerLokalu;
        this.numerPosesji = numerPosesji;
    }
}


/////////////////////////////////////////////////



public class Magazyn
{
    public List<produkt> produkty;
    public Adres adresMagazynu;
    public Magazyn(List<produkt> produkty, Adres
adresMagazynu)
    {
        produkty = new List<produkt>();
        this.adresMagazynu = adresMagazynu;
    }
    public void dodajProdukt(produkt produkt)
    {
        produkty.Add(produkt);
    }
    public void usunProdukt(produkt produkt)
    {
        produkty.Remove(produkt);
    }
}

/////////////////////////////////////////////





public class produkt

{
    public string nazwaProducenta;
    public string nazwaProduktu;
    public string kategoria;
    public string kodProduktu;
    public int cena;
    public string opis;
    public produkt(string nazwaProducenta, string nazwaProduktu,
string kategoria, string kodProduktu, int cena, string opis)
    {
        this.nazwaProducenta = nazwaProducenta;
        this.nazwaProduktu = nazwaProduktu;
        this.kategoria = kategoria;
        this.kodProduktu = kodProduktu;
        this.cena = cena;
        this.opis = opis;
    }
}

//////////////////////////////
