using System.Collections;
//Importe, lai varetu ieladet ainas
using UnityEngine.SceneManagement;
using UnityEngine;

public class Izvelne1Skripts : MonoBehaviour
{
    //Izdarot klikšķi uz pogas "uzAinu", tiks atvērta ains "izvele1"
    public void uzIzvelni()
    {
        SceneManager.LoadScene("izvele1", LoadSceneMode.Single);
    }
}
