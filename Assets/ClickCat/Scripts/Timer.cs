using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text _timeText;
    [SerializeField] GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _timeText = GetComponent<Text>();
        _timeText.text = "Time: " + _gameManager._time.ToString("F1");
    }

    // Update is called once per frame
    void Update()
    {
        _timeText.text = "Time: " + _gameManager._time.ToString("F1");
    }
}
