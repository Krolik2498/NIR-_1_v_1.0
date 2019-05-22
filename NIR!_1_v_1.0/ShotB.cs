//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ShotB : MonoBehaviour
//{


//    void Update()
//    {
//        if (Input.GetButtonDown("Fire1"))
//        {
//            RaycastHit hit;
//            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f) && (hit.collider.gameObject != gameObject))
//            {
//                if (hit.collider.gameObject.GetComponent<Jellyai>())
//                    Destroy(hit.collider.gameObject);
//            }
//        }
//    }
//}

