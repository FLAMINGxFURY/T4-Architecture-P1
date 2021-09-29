using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class OFButtonHandler : MonoBehaviour
{
    public void createOFD() {
		data.cpu.Rd.fileStr = EditorUtility.OpenFilePanel("File", "../", "*");
		data.cpu.Rd.OpenFile();

		//Display Hex for Program
		List<string> dispProgMem = new List<string>();

		foreach (ushort x in data.cpu.Rd.proMem) {
			string add = x.ToString("X4"); //4 digits of hex
			add = add.Insert(2, " ");
			dispProgMem.Add(add);
		}
		
		string progDisplay = "";
		
		foreach (string s in dispProgMem) {
			progDisplay += (s + " ");
		}		

		Text binaryText = GameObject.Find("Binary Text").GetComponent<Text>();

		binaryText.text = progDisplay;

	}
}
