using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public GameObject item = GameObject.Find("Goggles");
    public GameObject eSprite = GameObject.Find("eIcon");
    public float interactionDistance = 1.0f;
    private bool playerNearby = false;

    void Update()
    {
        if (playerNearby)
        {
            eSprite.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                item.SetActive(false);
                eSprite.SetActive(false);
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
