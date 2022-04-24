using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Gift : MonoBehaviour
{
    public delegate void SignalGift();
    public static event SignalGift SignalGiftLaunch;
   private void OnCollisionEnter2D(Collision2D other) 
   {            

        if(other.gameObject.CompareTag("ground"))
        {
            SignalGiftLaunch?.Invoke();
            Destroy(gameObject);    
        }   

               
   }


}
