using UnityEngine;
using System.Collections;

public class Tankcontrol : MonoBehaviour
{

    //Obiekt odpowiedzialny za ruch gracza.
    public CharacterController characterControler;

    public float predkoscPoruszania = 9.0f;
    public float aktualnaWysokoscSkoku = 0f;
    public float predkoscBiegania = 7.0f;
    public float czuloscMyszki = 3.0f;
    public float zakresMyszyGoraDol = 90.0f;
    void Start()
    {
        characterControler = GetComponent<CharacterController>();
    }
    void Update()
    {
        klawiatura();
    }
    private void klawiatura()
    {
        float rochPrzodTyl = Input.GetAxis("Vertical") * predkoscPoruszania;
        float rochLewoPrawo = Input.GetAxis("Horizontal") * predkoscPoruszania * 0;
        aktualnaWysokoscSkoku += Physics.gravity.y * Time.deltaTime;
        Debug.Log(Physics.gravity.y);

        if (Input.GetKeyDown("left shift"))
        {
            predkoscPoruszania += predkoscBiegania;
        }
        else if (Input.GetKeyUp("left shift"))
        {
            predkoscPoruszania -= predkoscBiegania;
        }
        Vector3 ruch = new Vector3(rochLewoPrawo, aktualnaWysokoscSkoku, rochPrzodTyl);
        ruch = transform.rotation * ruch;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 20);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 20);
        }

        characterControler.Move(ruch * Time.deltaTime);
    }
}
