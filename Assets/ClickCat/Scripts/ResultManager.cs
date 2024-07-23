using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + GameManager._score;
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("0_ClickCat");
    }
}
