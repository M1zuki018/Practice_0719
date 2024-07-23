using System.Collections;
using UnityEngine;

/// <summary>
/// 範囲内で、数秒おきにねこが歩き回る
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [SerializeField] float _speed = 0.8f;
    [SerializeField] int _moveInterval = 3;
    [SerializeField] int _timeInMotion = 2;

    Vector2 _direction;
    Vector3 _startingPoint;

    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _startingPoint = transform.position;
        StartCoroutine(ChangeDirection());
    }

    IEnumerator ChangeDirection()
    {
        while (true)
        {
            _rb.simulated = true;
            _direction = Random.insideUnitCircle; //ランダムな一点を取得する

            float distanceFromStart = Vector2.Distance(_startingPoint, transform.position); //スタート地点からどれだけ離れているか
            if (distanceFromStart > 1f + (_speed * 0.1f))
            {
                _direction = (_startingPoint - transform.position).normalized;
            }

            yield return new WaitForSeconds(_timeInMotion);

            _rb.simulated = false;

            yield return new WaitForSeconds(_moveInterval);
        }
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_direction * _speed);
    }
}
