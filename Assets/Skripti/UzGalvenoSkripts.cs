using System.Collections;
//Importe, lai varetu ieladet ainas
using UnityEngine.SceneManagement;
using UnityEngine;

public class UzGalvenoSkripts : MonoBehaviour
{
    //Izdarot klikski uz pogas "uzIzvelni", tiks atverta ainna "galvenaAina"
    public void uzGalveno()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
   }
