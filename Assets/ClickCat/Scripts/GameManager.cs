using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �Q�[���X�^�[�g�A�^�C�}�[�A�X�|�i�[�I���I�t�A���U���g��ʂ֑J��
/// </summary>

public class GameManager : MonoBehaviour
{
    public static int _score;
    [SerializeField] public float _time = 15;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;

        if (_time <= 0)
        {
            SceneManager.LoadScene("2_ClickCat");
        }
    }
}
