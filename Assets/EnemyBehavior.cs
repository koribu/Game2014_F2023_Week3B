using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    Vector2 _speedRange;

    float _verticalSpeed;

    [SerializeField]
    Boundries _verticalBoundries;
    [SerializeField]
    Boundries _horizontalBoundries;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - _verticalSpeed * Time.deltaTime);

        //Spawn / Reset
        if(_verticalBoundries.min > transform.position.y)
        {
            Reset();
        }

    }

    void Reset()
    {
        _verticalSpeed = Random.Range(_speedRange.x, _speedRange.y);
        transform.position = new Vector2(Random.Range(_horizontalBoundries.min, _horizontalBoundries.max), _verticalBoundries.max);
    }
}
