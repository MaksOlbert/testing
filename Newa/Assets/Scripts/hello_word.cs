using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello_word : MonoBehaviour
{   // metoda / funkcja = krotki kawalek kody ktory ma za zadanie wykonac jakies 
    // metody -> dzialaja na obiektach 
    // funkcje -> jezyk struc
    // string / int/ float/ doublr/ long /char/
    // string -> "ala ma kota"
    // int => 1,2,3,4,5,6
    // float => 5.33333333333333333333333333333333333
    // double => 5.3333333333333333333333333333333333333333333333333333333333333333333333
    // char ???



    double MilenaKilometry (double a)
    {
        a = a * 1.609344;
        print(a);
        return 0;
    }





    // Start is called before the first frame update
    /*fsdfdsfsdfsdfsdffsdfsdfsd
    dasd
    da
    sd
    ad
    asd

    sd
    ad
    as*/
    void Start()
    { 
        // BIALE ZNAKI SPACJA , ENTER , TABLICY 
        MilenaKilometry(14.5);
        int min = 1;
        int max = 1000;
        // zmienna nazwa czesc pamieci komputera
        // RAM = pamiec w tej pamieci swoje adresy komorki sa podzielone ma wiersze i kolumny
        print("Witaj w liczbowym czarodzieju"); // STRING = ""
        print("Wybierz liczbe od 1 do 1000");
        print("Maksymalna liczba którą możesz wybrać to " + max);
        // + operator przeciaza ktory powoduje ze mozemy mieszac typy 
        // string + int = poprawia wyslwietlony kounikat w konsoli 
        // string -> łańcuch znaków
        // int liczby -> całkowite 
        // bool true and false 
        print("Minimalna liczba którą możesz wybrać to " + min);
        print(" Czy twoja lidczba jest mniejsza lub wieksza od 500?");
        print("Nacisnij strzalke w gore aby odpowiedziec ze wieksza");
        print("Nacisnij strzalke w dol aby odpowiedziec ze mnijesza");
        print("Nacisnij enter aby potwierdzic ze komputer zgadl liczbe");

        if (Input.GetKeyDown(KeyCode.UpArrow)) // instrukcja warunkowa < wartosc true 
        {
            //
        }

      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
