using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Environment : MonoBehaviour
{
    [SerializeField] float moveRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position -= new Vector3(0,0,moveRate * Time.deltaTime);
    }
}
