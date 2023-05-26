using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("GameObject Component:")]
    public MeshRenderer Renderer;

    [Header("Transform Position Private Variables:")]
    [SerializeField] private float _xPos;
    [SerializeField] private float _yPos;
    [SerializeField] private float _zPos;
    
    [Header("Transform Scale Private Variables:")]
    [SerializeField] private float _locScale;
    
    [Header("Color Private Variables:")]
    [SerializeField] private float _red;
    [SerializeField] private float _green;
    [SerializeField] private float _blue;
    [SerializeField] private float _alpha;

    [Header("Rotate Private Variables:")]
    [SerializeField] private float _xAngle;
    [SerializeField] private float _yAngle;
    [SerializeField] private float _zAngle;

    void Start()
    {
        transform.position = new Vector3(_xPos, _yPos, _zPos);
        transform.localScale = Vector3.one * _locScale;
        
        Material material = Renderer.material;
    }
    
    void FixedUpdate()
    {
        transform.Rotate(_xAngle * Time.fixedDeltaTime, _yAngle, _zAngle);
    }
}
