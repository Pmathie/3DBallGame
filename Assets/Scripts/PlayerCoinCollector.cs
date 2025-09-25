using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    
    public void AddCoin()
    {
            coinCount++;
        if(UIManager.Instance != null) 
            UIManager.Instance.UpdateCoinCount(coinCount);
   
    }

}
