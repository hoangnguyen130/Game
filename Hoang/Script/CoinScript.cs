using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Text CoinText;
    private int CoinNum;

    void Start(){
        CoinNum = 0;
        CoinText.text = "Coin: " + CoinNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin){
        if(Coin.tag == "MyCoin"){
            CoinNum += 1;
            Destroy(Coin.gameObject);
            CoinText.text = "Coin: " + CoinNum;

        }
    }

    void Update(){
         
    }
}
