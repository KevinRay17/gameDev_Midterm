using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowScript : MonoBehaviour
{
	public float PWR = 0.0f; //P
	public float AIM = 0.0f; //A
	public float SPD = 0.0f; //K
	public float BAL = 0.0f; //B


	private bool throwP = false;
	private bool throwA = false;
	private bool throwK = false;
	private bool throwB = false;
	private bool THROW = false;
	public bool levelOne = true;
	public bool levelTwo = false;
	public bool levelThree = false;
	private bool hunCheckP = false;
	private bool hunCheckA = false;
	private bool hunCheckK = false;
	private bool hunCheckB = false;

	public Image PWRBar;
	public Image AIMBar;
	public Image SPDBar;
	public Image BALBar;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		PWRBar.fillAmount = PWR / 100;
		AIMBar.fillAmount = AIM / 100;
		SPDBar.fillAmount = SPD / 100;
		BALBar.fillAmount = BAL / 100;
		//LEVEL ONE POWER AND AIM
		if (levelOne)
		{
			if (!throwP)
			{
				if (Input.GetKey(KeyCode.P))
				{
					if (PWR >= 99)
						hunCheckP = true;
					if (PWR <= 1)
						hunCheckP = false;
					if (!hunCheckP)
						PWR++;
					if (hunCheckP)
						PWR--;
				}

				if (Input.GetKeyUp(KeyCode.P))
					throwP = true;
			}

			if (!throwA)
			{
				if (Input.GetKey(KeyCode.A))
				{
					if (AIM >= 99)
						hunCheckA = true;
					if (AIM <= 1)
						hunCheckA = false;
					if (!hunCheckA)
						AIM++;
					if (hunCheckA)
						AIM--;
				}

				if (Input.GetKeyUp(KeyCode.A))
					throwA = true;
			}
		}
		//LEVEL TWO POWER AND AIM AND SPEED
		if (levelTwo)
		{
			if (!throwP)
			{
				if (Input.GetKey(KeyCode.P))
				{
					if (PWR >= 99)
						hunCheckP = true;
					if (PWR <= 1)
						hunCheckP = false;
					if (!hunCheckP)
						PWR++;
					if (hunCheckP)
						PWR--;
				}

				if (Input.GetKeyUp(KeyCode.P))
					throwP = true;
			}

			if (!throwA)
			{
				if (Input.GetKey(KeyCode.A))
				{
					if (AIM >= 99)
						hunCheckA = true;
					if (AIM <= 1)
						hunCheckA = false;
					if (!hunCheckA)
						AIM++;
					if (hunCheckA)
						AIM--;
				}

				if (Input.GetKeyUp(KeyCode.A))
					throwA = true;
			}

			if (!throwK)
			{
				if (Input.GetKey(KeyCode.K))
				{
					if (SPD >= 99)
						hunCheckK = true;
					if (SPD <= 1)
						hunCheckK = false;
					if (!hunCheckK)
						SPD++;
					if (hunCheckK)
						SPD--;
				}

				if (Input.GetKeyUp(KeyCode.K))
					throwK = true;
			}
		}
		//LEVEL THREE POWER AND AIM AND SPEED AND BALANCE
		if (levelThree)
		{
			if (!throwP)
			{
				if (Input.GetKey(KeyCode.P))
				{
					if (PWR >= 99)
						hunCheckP = true;
					if (PWR <= 1)
						hunCheckP = false;
					if (!hunCheckP)
						PWR++;
					if (hunCheckP)
						PWR--;
				}

				if (Input.GetKeyUp(KeyCode.P))
					throwP = true;
			}

			if (!throwA)
			{
				if (Input.GetKey(KeyCode.A))
				{
					if (AIM >= 99)
						hunCheckA = true;
					if (AIM <= 1)
						hunCheckA = false;
					if (!hunCheckA)
						AIM++;
					if (hunCheckA)
						AIM--;
				}

				if (Input.GetKeyUp(KeyCode.A))
					throwA = true;
			}

			if (!throwK)
			{
				if (Input.GetKey(KeyCode.K))
				{
					if (SPD >= 99)
						hunCheckK = true;
					if (SPD <= 1)
						hunCheckK = false;
					if (!hunCheckK)
						SPD++;
					if (hunCheckK)
						SPD--;
				}

				if (Input.GetKeyUp(KeyCode.K))
					throwK = true;
			}
			if (!throwB)
			{
				if (Input.GetKey(KeyCode.B))
				{
					if (BAL >= 99)
						hunCheckB = true;
					if (BAL <= 1)
						hunCheckB = false;
					if (!hunCheckB)
						BAL++;
					if (hunCheckB)
						BAL--;
				}

				if (Input.GetKeyUp(KeyCode.B))
					throwB = true;
			}
		}
	}
}
