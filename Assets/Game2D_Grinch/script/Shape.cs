using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{   public delegate void SignalShape();
    public static event SignalShape SignalShapeLaunch;

    public Grinch grinch; 

    private Rigidbody2D rb2D;
    private Animator anim;
private void Start() 
{
    rb2D = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
}
  
  
  
   private void OnCollisionEnter2D(Collision2D other) 
   {     
       if(other.gameObject.CompareTag("grinch") && grinch.grinchCatchedGift == true)
        {          
           SignalShapeLaunch?.Invoke(); 
           anim.SetTrigger("openShape");
           grinch.grinchCatchedGift = false;     
           grinch.GiftCatched.SetActive(false);               
        }

    }
       


}
