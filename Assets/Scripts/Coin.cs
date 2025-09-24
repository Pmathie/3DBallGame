using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerCoinCollector>())
        {
            other.GetComponent<PlayerCoinCollector>().AddCoin();
            coinSound.Play();

            GetComponent<Renderer>().enabled = false; //Gør mønten usynlig
            GetComponent<Collider>().enabled = false; //Gør at vi ikke kan kollidere med mønten

            StartCoroutine(DestroyCoin());
           
        }
    }
    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(coinSound.clip.length); //Venter på at lyden er afspillet
        {
            Destroy(gameObject); //Ødelægger mønten
        }
    }
}
