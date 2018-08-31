using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAdd : MonoBehaviour
{
	[HideInInspector]
	public int coin;

	public Text coinText;

	private void Awake()
	{
		coin = PlayerPrefs.GetInt("Coin");
		UIUpdate();
	}

	public void GoldAdd(int add)
	{
		coin += add;
		PlayerPrefs.SetInt("Coin", coin);
		UIUpdate();
	}

	public void GoldMinus(int minusGold)
	{
		if(coin >= minusGold)
		{
			coin -= minusGold;
		}
		PlayerPrefs.SetInt("Coin", coin);
		UIUpdate();
	}

	public void UIUpdate()
	{
		coinText.text = "Coin : " + coin;
	}

	public void GoldReset()
	{
		PlayerPrefs.DeleteKey("Coin");
	}

}
