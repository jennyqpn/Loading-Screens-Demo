using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickCounter : MonoBehaviour
{
	public Canvas canvas;
	public TextMeshProUGUI text;
	private int click;

	// Start is called before the first frame update
	void Start()
    {
		click = 0;
    }

    // Update is called once per frame
    void Update()
    {
		{
			if (canvas.isActiveAndEnabled)
			{
				if (Input.GetMouseButtonDown(0))
				{
					click++;
					text.text = "How Many Times Can You Click: " + click;
				}
			}
		}
	}
}
