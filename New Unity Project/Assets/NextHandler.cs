using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextHandler : MonoBehaviour
{
    public void NextInstruction() {
		//after halt disable the button
		if (data.cpu.ParseNextOp())
			GameObject.Find("Next Instruction").GetComponent<Button>().interactable = false;

		//poll registers and flags for data

		GameObject.Find("AX Text").GetComponent<Text>().text = "AX: " + data.cpu.GetRegister(0).Data.ToString("X4");
		GameObject.Find("BX Text").GetComponent<Text>().text = "BX: " + data.cpu.GetRegister(1).Data.ToString("X4");
		GameObject.Find("CX Text").GetComponent<Text>().text = "CX: " + data.cpu.GetRegister(2).Data.ToString("X4");
		GameObject.Find("DX Text").GetComponent<Text>().text = "DX: " + data.cpu.GetRegister(3).Data.ToString("X4");
		GameObject.Find("SP Text").GetComponent<Text>().text = "SP: " + data.cpu.GetRegister(4).Data.ToString("X4");
		GameObject.Find("BP Text").GetComponent<Text>().text = "BP: " + data.cpu.GetRegister(5).Data.ToString("X4");
		GameObject.Find("S0 Text").GetComponent<Text>().text = "S0: " + data.cpu.GetRegister(6).Data.ToString("X4");
		GameObject.Find("S1 Text").GetComponent<Text>().text = "S1: " + data.cpu.GetRegister(7).Data.ToString("X4");

		GameObject.Find("PC Text").GetComponent<Text>().text = "PC: " + data.cpu.Rd.PC.ToString("X4");
	}
}
