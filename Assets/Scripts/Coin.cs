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

            GetComponent<Renderer>().enabled = false; //G�r m�nten usynlig
            GetComponent<Collider>().enabled = false; //G�r at vi ikke kan kollidere med m�nten

            StartCoroutine(DestroyCoin());
           
        }
    }
    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(coinSound.clip.length); //Venter p� at lyden er afspillet
        {
            Destroy(gameObject); //�del�gger m�nten
        }
    }
}
