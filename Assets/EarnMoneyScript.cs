using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EarnMoneyScript : MonoBehaviour {

	public MoneyScript _moneyScript;
	
	// Update is called once per frame
	void Awake () {
		var mText = GetComponent<TextMeshProUGUI>();
		var earn = _moneyScript.earnedMoney;
		Debug.Log (earn);
		mText.text = earn.ToString()+ " $";
	}
}
