using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// swith 색상변경 스크립트
public class ColorChange : MonoBehaviour 
{
	MeshRenderer my;
	int colornum = 0;
	
	void Start () 
	{
		// MeshRenderer 가져오기
		// 시작시 램덤으로 0~2 숫자 부여
		my = GetComponent<MeshRenderer>();
		colornum = Random.Range(0,3);
		ColorC(colornum);
	}
	
	public void ColorC(int a)
	{
		switch(colornum)
		{
			case 0: 
			// Color, OutlineColor 색상 변경
			my.material.SetColor("_Color", new Color32(100,0,0,255));
			my.material.SetColor("_OutlineColor", new Color32(255,0,0,255));

			break;
			
			case 1:
			my.material.SetColor("_Color", new Color32(0,100,0,255));
			my.material.SetColor("_OutlineColor", new Color32(0,255,0,255));
			break;
			
			case 2:
			my.material.SetColor("_Color", new Color32(0,0,100,255));
			my.material.SetColor("_OutlineColor", new Color32(0,0,255,255));
			break;
			
		}
	}
}
