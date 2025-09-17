using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerCoinCollector>())
        {
            other.GetComponent<PlayerCoinCollector>().AddCoin();
            Destroy(gameObject);
        }
    }
}
