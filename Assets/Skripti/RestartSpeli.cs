using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSpeli : MonoBehaviour
{
   //Pievienojam funkciju restart pogai, nospiežot viņu ieslēgies spēles aina
   public void RestartButton(){
        SceneManager.LoadScene("PilsetasAina");
   }

    //Pievienojam funkciju atpakaļ uz izvelni pogai, nospiežot viņu ieslēgies izvelnes aina
    public void MainMenuButton(){
        SceneManager.LoadScene("Izvelne");
    }
}
