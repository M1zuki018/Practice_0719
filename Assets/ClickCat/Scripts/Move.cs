using System.Collections;
using UnityEngine;

/// <summary>
/// �͈͓��ŁA���b�����ɂ˂����������
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
            _direction = Random.insideUnitCircle; //�����_���Ȉ�_���擾����

            float distanceFromStart = Vector2.Distance(_startingPoint, transform.position); //�X�^�[�g�n�_����ǂꂾ������Ă��邩
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
