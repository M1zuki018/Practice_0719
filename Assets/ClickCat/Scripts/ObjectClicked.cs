using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectClicked : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] AudioClip _clip;
    SE _seController;
    GameObject _starObj;

    private void Start()
    {
        GameObject seObj = GameObject.Find("SE");
        _seController = seObj.GetComponent<SE>();
        _starObj = transform.GetChild(0).gameObject;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameManager._score += 100;
        _seController.PlaySe(_clip); //����炷
        _starObj.SetActive(true); // �L���L�����o��
        Destroy(gameObject, 1f);
        enabled = false;
    }
}
