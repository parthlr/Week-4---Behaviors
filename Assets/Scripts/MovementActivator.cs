using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    [SerializeField] bool moveTrigger;
    [SerializeField] bool rotateTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (moveTrigger) {
            objectToActivate.GetComponent<MoveObject>().enabled = true;
        } else if (rotateTrigger) {
            objectToActivate.GetComponent<RotateObject>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (moveTrigger) {
            objectToActivate.GetComponent<MoveObject>().enabled = true;
        } else if (rotateTrigger) {
            objectToActivate.GetComponent<RotateObject>().enabled = false;
        }
    }
}
