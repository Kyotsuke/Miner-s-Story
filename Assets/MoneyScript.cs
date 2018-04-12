using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyScript : MonoBehaviour {


	private static float currentMoney;
	public float earnedMoney;

	void Awake()
	{
		DontDestroyOnLoad(this);
		var mText = GetComponent<TextMeshProUGUI>();
		mText.text = currentMoney.ToString() + " $";
	}


	public void setValue (float value) {
		var mText = GetComponent<TextMeshProUGUI>();
		currentMoney += value;
		earnedMoney += value;

		mText.text = currentMoney.ToString() + " $";
	}
}