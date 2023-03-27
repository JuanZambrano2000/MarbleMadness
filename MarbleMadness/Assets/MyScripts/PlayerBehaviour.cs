using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    private float _velocity;

    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        Assert.IsNotNull(_transform,"Es necesario para movimiento tener un transform");
    }

    // Update is called once per frame
    void Update()
    {
        
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        _transform.Translate(
            horizontal *_speed*Time.deltaTime,
            0,
            vertical *_speed*Time.deltaTime,
            Space.World
        );
        
    }
}
