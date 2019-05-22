//using UnityEngine;
//using UnityEngine.Networking;
//using UnityEngine.UI;

//public class Player : NetworkBehaviour
//{

//    [SerializeField]
//    private float maxHealth = 100;
//    public Text HP;
//    [SyncVar]
//    private float currHealth;

//    //void Update()
//    //{
//        //HP.text = "+" + currHealth.ToString("0");
//        //if (currHealth <= 0)
//        //{
//            //currHealth = 0;
//            //Dead();
//        //}
//    //}

//    void Awake()
//    {
//        currHealth = maxHealth;
//    }

//    public void TakeDamage(float damage)
//    {
//        currHealth -= damage;
//        //HP.text = "+" + currHealth.ToString("0");
//        Debug.Log(transform.name + " имеет уровень здоровья равный: " + currHealth);
//    }

//     void Dead()
//     {
        
//     }


//}
