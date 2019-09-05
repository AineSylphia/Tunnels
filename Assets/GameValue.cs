using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameValue : MonoBehaviour
{
	[SerializeField] int widthNum = 5;
	[SerializeField] int heightNum = 6;
	int tunnelMax = 0;
	int tunnleNum = 0;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public int getWidth()
	{
		return widthNum;
	}

	public int getHeight()
	{
		return heightNum;
	}

	public void setMax(int tunnelMax_)
	{
		if (tunnelMax_ <= 0)
		{
			Debug.Log("1以上の値が欲しいいいいいいい");
			return;
		}
		tunnelMax = tunnelMax_;
	}

	public int getMax()
	{
		return tunnelMax;
	}

	public void incTunnelNum(int tunnel)
	{
		if (tunnel <= 0)
		{
			Debug.Log("1以上の値が欲しいいいいいいい");
			return;
		}
		tunnelMax += tunnel;
	}

	public int getTunnleNum()
	{
		return tunnleNum;
	}
}

