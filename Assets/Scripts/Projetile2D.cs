using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetile2D : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject target; //target sprite
    [SerializeField] Rigidbody2D bulletPrefab;
    
    // Update is called once per frame
    void Update()
    {
        //shoot raycast to detect mouse clicked position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 5f, Color.red, 5f);
        
        
    }
}
