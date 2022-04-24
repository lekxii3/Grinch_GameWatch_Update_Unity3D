using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int CurrentGiftCatch = 0;
    public int CurrentLife =3;

    private Vector2[] positionGift = new Vector2[3] {new Vector2 (-4f,2f),new Vector2 (-0.75f,2f),new Vector2 (2.5f,2f)}; 
    private int indexPositionGift = 0; 

    [SerializeField] private GameObject instantiateGift;
    


    private void Update() 
    {
        StartCoroutine(InstantiateGift());
    }

    void OnEnable() 
   {
       Shape.SignalShapeLaunch += GiftDeposite;
       Gift.SignalGiftLaunch += LifeLost;
   }

   void OnDisable() 
   {
       Shape.SignalShapeLaunch -= GiftDeposite;
       Gift.SignalGiftLaunch -= LifeLost;
   }

    public void GiftDeposite()
    {
        CurrentGiftCatch ++;       
    }

    public void LifeLost()
    {
        CurrentLife --;
    }

    public IEnumerator InstantiateGift()
    {
        
        if(indexPositionGift<positionGift.Length-1 && indexPositionGift>=0)
        {
         yield return new WaitForSeconds(5);
         indexPositionGift = Random.Range(0,3);
         transform.position = positionGift[indexPositionGift];
         Instantiate<GameObject>(instantiateGift, transform.position, transform.rotation);
         
         }
        
       
      
    }

    
}
