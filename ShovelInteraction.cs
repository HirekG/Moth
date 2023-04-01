using UnityEngine;

public class ShovelInteraction : MonoBehaviour
{
    public GameObject Shovel;
    public GameObject eSprite;
    public float interactionDistance = 1.0f;
    private bool playerNearby = false;
    public bool ShovelGot = false;

    void Update()
    {
        if (playerNearby)
        {
            eSprite.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Shovel.SetActive(false);
                eSprite.SetActive(false);
                ShovelGot = true;
            }
        }
        else
        {
            eSprite.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            eSprite.SetActive(false);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionDistance);
    }
}
