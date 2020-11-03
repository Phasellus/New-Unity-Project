using UnityEngine;
using System.Collections;

public class Wierza : MonoBehaviour
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
        myszka();
    }
    private void myszka()
    {
      
            float myszLewoPrawo = Input.GetAxis("Mouse X") * czuloscMyszki;
            transform.Rotate(0, myszLewoPrawo, 0);
 
    }
}