using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //GameObject, kas uzglabā visus velkamos objektus
    public GameObject atkritumuMasina;
    public GameObject atroMasina;
    public GameObject autobuss;
    public GameObject traktors1;
    public GameObject traktors5;
    public GameObject ugunsdzeseji;
    public GameObject b2;
    public GameObject camantamasina;
    public GameObject e46;
    public GameObject ekskavators;
    public GameObject policija;
    //Definējam papildu mainīgo, lai veikt punktu skaitīšanu
    public int punkti = 0;
    //Definējam papildu GameOjektu, lai izvēlēties konkrēto paneli
    public GameObject IzkritosaisLogs;

    /*Uzglabās velkamo objektu sākotnējās pozīcijas
    koordinātas (lai zinātu, kur aizmest objektu, ja tas nolikts nepareizajā vietā)*/
    //Objekti paliek Public, taču paslēpj no Inspector loga
    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 traktors1Koord;
    [HideInInspector]
    public Vector2 traktors5Koord;
    [HideInInspector]
    public Vector2 ugunsdzesejiKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 camantamasinaKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 ekskavatorsKoord;
    [HideInInspector]
    public Vector2 policijaKoord;
    //Uzglabās ainā esošo kanvu
    public Canvas kanva;
    //Uzglabās skaņas avotu, kurā atskaņot audio failu
    public AudioSource skanasAvots;
    //Masīvs, kas uzglabās visas skaņas
    public AudioClip[] skanaKoAtskanot;
    //Uzglabās objektu, kurš ir pēdējais pārvietotais
    [HideInInspector]
    public GameObject pedejaisVilktais = null;
    //Mainīgais atbild par to vai objekts ir nolikts pareizi vai nepareizi
    [HideInInspector]
    public bool vaiIstajaVieta = false;

    //Funkcija nostrādā tiklīdz nospiesta play poga
    private void Awake()
    {
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        traktors1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        traktors5Koord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsdzesejiKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        camantamasinaKoord = camantamasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        ekskavatorsKoord = ekskavators.GetComponent<RectTransform>().localPosition;
        policijaKoord = policija.GetComponent<RectTransform>().localPosition;

    }
}
