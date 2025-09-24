using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound; // Lyden der skal afspilles, når mønten bliver samlet op

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
            coinSound.Play(); // Afspiller lyd, når mønten bliver samlet op
            
            GetComponent<Renderer>().enabled = false; // Gør mønten usynlig
            GetComponent<Collider>().enabled = false; // Deaktiverer kollisionsdetektering for mønten
            
            StartCoroutine(DestroyCoin()); // Starter en coroutine der ødelægger mønten efter lyden er færdig med at afspille

        }
    }
    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(coinSound.clip.length); // Venter på at lyden er færdig med at afspille
        Destroy(gameObject); // Ødelægger mønten
    }
}
