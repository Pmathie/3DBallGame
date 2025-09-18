using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    
    public void AddCoin()
    {
            coinCount++;
            UIManager.Instance.UpdateCoinCount(coinCount);
   
    }

}
