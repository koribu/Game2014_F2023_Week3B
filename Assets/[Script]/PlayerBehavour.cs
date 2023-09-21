using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavour : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2;

    [SerializeField]
    private Boundries _horizontalBoundries, _verticalBoundries;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime;
        float yAxis = Input.GetAxisRaw("Vertical") * _speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + xAxis, transform.position.y + yAxis, 0); //new Vector3(xAxis, yAxis, 0);


        if(transform.position.x < _horizontalBoundries.min)
        {
            transform.position = new Vector3(_horizontalBoundries.max, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _horizontalBoundries.max)
        {
            transform.position = new Vector3(_horizontalBoundries.min, transform.position.y, transform.position.z);
        }

        if(transform.position.y > _verticalBoundries.max)
        {
            transform.position = new Vector3(transform.position.x, _verticalBoundries.max);
        }

        if (transform.position.y < _verticalBoundries.min)
        {
            transform.position = new Vector3(transform.position.x, _verticalBoundries.min, 5);
          
        }
    }
}