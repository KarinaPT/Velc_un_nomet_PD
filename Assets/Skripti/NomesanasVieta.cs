using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāimportē, lai varētu piesaistīt IDropHandler interfeisu un lietot OnDrop funkciju
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler{
    //Uzglabās velkamā objekta rotāciju ap Z asi un noliekamās vietas rotāciju
    //Starpība uzglabās, cik liela Z ass rotācijas leņķa starpība starp abiem objektiem
    private float vietasZrot, velkamaObjeZrot, rotacijasStarpiba;
    //Uzglabās velkamā objekta un nomešanas vietas izmērus
    private Vector2 vietasIzm, velkObjIzm;
    //Uzglabās objektu x un y ass izmētu starpību
    private float xIzmeruStarpiba, yIzmeruStarpiba;
    //Norāde uz skriptu Objekti
    public Objekti objektuSkripts;

    //Nostradā, ja objektu cenšas nomest uz nometamā lauka
    public void OnDrop(PointerEventData notikums)
    {
        //Pārbauda vai kāds objekts tiek vilkts un nomests
        if(notikums.pointerDrag != null)
        {
            //Ja nomešanas laukā uzmestā attēla tags sakrīt ar lauka tagu
            if ((notikums.pointerDrag.tag.Equals(tag)))
            {
                //Iegūst objektu rotāciju grādos
                vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                velkamaObjeZrot = GetComponent<RectTransform>().transform.eulerAngles.z;
                //Aprēķina rotācijas starpību
                rotacijasStarpiba = Mathf.Abs(vietasZrot - velkamaObjeZrot);
                //Iegūst objektu izmērus
                vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
                velkObjIzm = GetComponent<RectTransform>().localScale;
                xIzmeruStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
                yIzmeruStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

                //Pārbauda vai objektu savstarpējā rotācija neatšķiras vairāk par 9 grādiem
                //un vai x un y izmēri neatšķiras vairāk par 0.15
                if((rotacijasStarpiba <=9 || (rotacijasStarpiba >= 351 && rotacijasStarpiba <= 360))
                    && (xIzmeruStarpiba <=0.15 && yIzmeruStarpiba <= 0.15))
                {
                    objektuSkripts.vaiIstajaVieta = true;
                    //Nometamo objektu iecentrē nomešanas vietā
                    notikums.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition;
                    //Pielāgo nomestā objekta rotāciju
                    notikums.pointerDrag.GetComponent<RectTransform>().localRotation =
                        GetComponent<RectTransform>().localRotation;
                    //Pielāgo nomestā objekta izmēru
                    notikums.pointerDrag.GetComponent<RectTransform>().localScale =
                       GetComponent<RectTransform>().localScale;


                    /*Pārbauda pēc tagiem, kurš no objektiem ir pareizi nomests, tad 
                    atskaņo atbilstošo skaņu*/
                    switch (notikums.pointerDrag.tag)
                    {
                        case "Atkritumi":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
                        break;

                        case "Atrie":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
                        break;

                        case "Skola":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
                        break;

                        case "Lielamaja":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[4]);
                            break;

                        case "lielamaja2":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[5]);
                            break;

                        case "Maja":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[6]);
                            break;

                        case "pils":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[7]);
                            break;

                        case "laiva":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[8]);
                            break;

                        case "Dzeltenstrissturis":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[9]);
                            break;

                        case "4malas":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[10]);
                            break;

                        case "tvaikonis":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[11]);
                            break;

            


                        default:
                            Debug.Log("Nedefinēts tags!");
                        break;
                    }
                }
            //Ja objektu tagi neskarīt un nomet nepareizajā vietā
            } else {
                objektuSkripts.vaiIstajaVieta = false;
                //Atskaņo skaņu
                objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);

                /*Atkarībā no objektu taga, kurš tika vilkts, 
                 * objekt uaizbīda uz tā sākotnējām koordinātām*/
                switch (notikums.pointerDrag.tag)
                {
                    case "Atkritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.atkrKoord;
                        break;

                    case "Atrie":
                        objektuSkripts.atroMasina.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.atroKoord;
                        break;

                    case "Skola":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.bussKoord;
                        break;

                    case "Lielamaja":
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition =
                             objektuSkripts.traktors1Koord;
                        break;

                    case "lielamaja2":
                        objektuSkripts.traktors5.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.traktors5Koord;
                        break;

                    case "Maja":
                        objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.ugunsdzesejiKoord;
                        break;

                    case "pils":
                        objektuSkripts.camantamasina.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.camantamasinaKoord;
                        break;

                    case "laiva":
                        objektuSkripts.b2.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.b2Koord;
                        break;

                    case "Dzeltenstrissturis":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.e46Koord;
                        break;

                    case "4malas":
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.policijaKoord;
                        break;

                    case "tvaikonis":
                        objektuSkripts.ekskavators.GetComponent<RectTransform>().localPosition =
                            objektuSkripts.ekskavatorsKoord;
                        break;


                    default:
                        Debug.Log("Objektam nav noteikta pārvietošanas vieta!");
                        break;
                }
            }
        }
    }
}
