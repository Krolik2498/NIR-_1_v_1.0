//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Jellyai : MonoBehaviour
//{
//    public Transform target;
//    public float speed = 0.5f;
//    private Rigidbody rb;
//    public float jumpforce = 5f;
//    private Vector3 jmp;

//    void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//        jmp = transform.up * jumpforce;
//    }

//    void Update()
//    {
//        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
//        transform.LookAt(target);
//        if (transform.position.y < target.position.y)
//        {
//            Jump();
//        }
//        if (Vector3.Distance(transform.position, target.position) < 2f)
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//        }
//    }

//    bool isGrounded()
//    {
//        Collider[] cc = Physics.OverlapSphere(new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z), 0.7f);
//        int j = 0;
//        for (int i = 0; i < cc.Length; i++)
//        {
//            if (cc[i].gameObject != gameObject)
//            {
//                j++;
//            }
//        }
//        return j > 0;
//    }

//    void Jump()
//    {
//        if (isGrounded())
//        {
//            rb.AddForce(jmp, ForceMode.Impulse);
//        }
//    }
//}
