using UnityEngine;
using UnityEngine.Tilemaps;

public class DigInteraction : MonoBehaviour
{
    public GameObject TilesToDig;
    public GameObject eSprite;
    public float interactionDistance = 1.0f;
    private bool playerNearby = false;
    public bool ShovelGot = false;
    public bool HoleSeen = false;
    public bool NormalVision = false;

    private Tilemap TilemapToDig;

    public GameObject otherObject;
    public HoleOnScreen HoleOnScreenScript;

    public GameObject other2Object;
    public ShovelInteraction ShovelInteractionScript;

    public GameObject other3Object;
    public GoggleSwitch GoggleSwitchScript;

    private void Start()
    {
        TilemapToDig = TilesToDig.GetComponent<Tilemap>();

        HoleOnScreenScript = otherObject.GetComponent<HoleOnScreen>();
        ShovelInteractionScript = other2Object.GetComponent<ShovelInteration>();
        GoggleSwitchScript = other3Object.GetComponent<GoggleSwitch>();
    }

    void Update()
    {
        HoleSeen = HoleOnScreenScript.HoleSeen;
        ShovelGot = ShovelInteractionScript.ShovelGot;
        NormalVision = GoggleSwitchScript.NormalVision;

        if (playerNearby && ShovelGot && HoleSeen && NormalVision)
        {
            eSprite.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                item.SetActive(false);
                eSprite.SetActive(false);
                ItemGot = true;
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
