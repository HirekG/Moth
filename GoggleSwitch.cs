using UnityEngine;
using UnityEngine.Tilemaps;

public class RoofTilemapSortingOrder : MonoBehaviour
{
    public GameObject Retro1;
    public GameObject Retro2;
    public GameObject Retro3;

    private PrRetro1 = Retro1.GetComponent<Tilemap>();
    private PrRetro2 = Retro2.GetComponent<Tilemap>();
    private PrRetro3 = Retro3.GetComponent<Tilemap>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PrRetro1.GetComponent<Renderer>().sortingOrder = PrRetro1.GetComponent<Renderer>().sortingOrder * -1;
            PrRetro2.GetComponent<Renderer>().sortingOrder = PrRetro2.GetComponent<Renderer>().sortingOrder * -1;
            PrRetro3.GetComponent<Renderer>().sortingOrder = PrRetro3.GetComponent<Renderer>().sortingOrder * -1;
        }
    }

