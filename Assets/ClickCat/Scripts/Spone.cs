using UnityEngine;

public class Spone : MonoBehaviour
{
    [SerializeField] GameObject _catPrefab;

    [SerializeField] Transform _rangeA;
    [SerializeField] Transform _rangeB;
    [SerializeField] float _sponeInterval = 3f;
    float _time;
    GameObject[] _cats;

    private void Start()
    {
        CatSpone();
        CatSpone();
        CatSpone();
    }
    // Update is called once per frame
    void Update()
    {
        _cats = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log(_cats.Length);
        _time += Time.deltaTime;

        if (_time > _sponeInterval || _cats.Length == 0)
        {
            CatSpone();
            CatSpone();
            CatSpone();
            _time = 0;
        }

    }

    void CatSpone()
    {
        float x = Random.Range(_rangeA.position.x, _rangeB.position.x);
        float y = Random.Range(_rangeA.position.y, _rangeB.position.y);
        float z = Random.Range(_rangeA.position.z, _rangeB.position.z);

        Instantiate(_catPrefab, new Vector3(x, y, z), Quaternion.identity);
    }
}
