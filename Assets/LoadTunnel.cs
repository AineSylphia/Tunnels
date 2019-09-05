using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTunnel : MonoBehaviour
{
	const int tunnelMax = 16;
	[SerializeField] Sprite[] imgTunnel = new Sprite[tunnelMax];
	[SerializeField] GameObject maptiles;

	// Start is called before the first frame update
	void Start()
	{
		if (imgTunnel == null)
			imgTunnel = Resources.LoadAll<Sprite>("./Assets/Graphics/Tunnel/tunnel.png");
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			GameValue value = new GameValue();
			for (int y = 0; y < value.getHeight(); ++y)
			{
				for (int x = 0; x < value.getWidth(); ++x)
				{
					maptiles.GetComponent<SpriteRenderer>().sprite = imgTunnel[value.getTunnleNum()];
					Instantiate(maptiles, new Vector3(x * 0.3f, y * 0.3f, 0), Quaternion.identity);
					value.incTunnelNum(1);
				}
			}
		}
	}
}
