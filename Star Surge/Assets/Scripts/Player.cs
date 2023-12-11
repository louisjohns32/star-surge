using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float sensitivity = 0.5f; // TODO move this elsewhere
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            var change = Input.GetTouch(0).deltaPosition;
            var currentPos = gameObject.transform.position;
            gameObject.transform.position = new Vector2(currentPos.x + 
                    change.x * Time.deltaTime * sensitivity,currentPos.y);
            
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        gameObject.SetActive(false);
    }
}
