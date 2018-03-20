using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ProgrammerButton : MonoBehaviour {
	public RectTransform programmerComponent;
	public Text nameLabel;
	public Image identiconImage;
	public Image backgroundImage;
	public Text progressText;
	public Text numberHiredText;

	public Button singleHire;
	public Text singleCostText;
	public Text rateText;

	public Button maxHire;
	public Text numberToHireText;
	public Text maxCostText;

	public Button autoHire;
	public Text autoCostText;

	//private Item item;
	//private ProgrammerScrollList scrollList;
	//public Text priceText;
	// Use this for initialization
	void Start () {
		//buttonComponent.onClick.AddListener (HandleClick);
	}

	public void Setup(){
		
	}

	public void HandleClick()
	{
		//scrollList.TryTransferItemToOtherShop (item);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
