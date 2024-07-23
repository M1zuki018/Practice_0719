using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        _text.text = "Score: " + GameManager._score;
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Score: " + GameManager._score;
    }
}
