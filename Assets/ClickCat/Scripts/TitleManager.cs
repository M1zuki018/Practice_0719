using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SwitchGame()
    {
        SceneManager.LoadScene("1_ClickCat");
    }
}
