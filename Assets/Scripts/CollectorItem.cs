using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorItem : MonoBehaviour
{
    // Start is called before the first frame update
    public float detectionRange;
    public LayerMask layerMask;
    public KeyCode keyCode = KeyCode.E;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectItem();
    }

    void DetectItem()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit,detectionRange,layerMask))
        {
            Debug.Log("ItemDetected: "+ hit.collider.gameObject.name);
        }

        if (Input.GetKeyDown(keyCode))
        {
            hit.collider.gameObject.GetComponent<CollectibleItem>().CollectItem();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * detectionRange);
    }
}
