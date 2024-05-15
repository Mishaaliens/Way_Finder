using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
   public void navi()
    {
        SceneManager.LoadSceneAsync(1);
    }

   
}
