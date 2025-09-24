using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound; // Lyden der skal afspilles, n�r m�nten bliver samlet op

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
            coinSound.Play(); // Afspiller lyd, n�r m�nten bliver samlet op
            
            GetComponent<Renderer>().enabled = false; // G�r m�nten usynlig
            GetComponent<Collider>().enabled = false; // Deaktiverer kollisionsdetektering for m�nten
            
            StartCoroutine(DestroyCoin()); // Starter en coroutine der �del�gger m�nten efter lyden er f�rdig med at afspille

        }
    }
    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(coinSound.clip.length); // Venter p� at lyden er f�rdig med at afspille
        Destroy(gameObject); // �del�gger m�nten
    }
}
