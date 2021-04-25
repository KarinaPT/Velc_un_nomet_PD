using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSpeli : MonoBehaviour
{
   public void RestartButton(){
        SceneManager.LoadScene("Izvelne");
   }
}
