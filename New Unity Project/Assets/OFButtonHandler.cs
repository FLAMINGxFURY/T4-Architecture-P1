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

		//enable next button
		GameObject.Find("Next Instruction").GetComponent<Button>().interactable = true;

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

		//Display Code for Program
		List<string> dispProgCode = new List<string>();

		foreach (ushort x in data.cpu.Rd.proMem) {
			string output = "";

			//get opcode
			ushort op = (ushort)(x >> 11);
			output += data.cpu._operations[op].ToString() + " ";

			//get rest
			ushort remainder = (ushort)(0b_0000_0111_1111_1111 & x); //bit mask for removing opcode
			output += data.cpu._operations[op].ToText(remainder);

			dispProgCode.Add(output);
		}

		string codeDisplay = "";

		foreach (string s in dispProgCode) {
			codeDisplay += s + "\n";
		}

		Text codeText = GameObject.Find("Asm Text").GetComponent<Text>();

		codeText.text = codeDisplay;

	}
}
