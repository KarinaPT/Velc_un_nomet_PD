using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IzvelnesLogs : MonoBehaviour {
    
    public void PlayGame() {
        //Šī rinda atbild par scēnu pārslēgšanu, palielina buildIndex par viens lai pārslēgt uz nākamo scēnu (indeksus scēnam var salikt Build settingos
        //uzspiežot Ctrl+Shift+B vai aizējot uz File/Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
    
    public void QuitGame(){
        //Konsolē printē - "Spēle ir izslēgta!"
        Debug.Log("Spēle ir izslēgta!");
        //Islēdz aplikāciju/spēli/scēnu
        Application.Quit();
    }
}