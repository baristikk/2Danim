using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]

public class UI {

[Serializable]

	public class HUD {
	
	[Header ("Text")]

	public Text txtCoinCount;
    public Text txtLifeCount;
	public Text txtTimer;

	public GameObject hudPanel; 	
	}
	
	[Header ("Other")]
	public HUD hud;
}
