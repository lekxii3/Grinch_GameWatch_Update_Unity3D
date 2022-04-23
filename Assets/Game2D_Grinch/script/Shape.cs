using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{   public delegate void SignalShape();
    public static event SignalShape SignalShapeLaunch;

    private Rigidbody2D rb2D;

private void Start() 
{
    rb2D = GetComponent<Rigidbody2D>();
}
  
  
  
   private void OnCollisionEnter2D(Collision2D other) 
   {     
       if(other.gameObject.CompareTag("Grinch"))
       {
           Debug.Log("coffre touché");
           SignalShapeLaunch?.Invoke();                      
        }

    }
       


}
